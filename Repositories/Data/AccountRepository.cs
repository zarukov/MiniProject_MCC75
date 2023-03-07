using Microsoft.EntityFrameworkCore;
using MiniProject_MCC75.Contexts;
using MiniProject_MCC75.Handler;
using MiniProject_MCC75.Models;
using MiniProject_MCC75.ViewModels;

namespace MiniProject_MCC75.Repositories.Data;

public class AccountRepository : GeneralRepository<int, Account>
{
    private readonly MyContext context;

    public AccountRepository(MyContext context) : base(context)
	{
        this.context = context;
    }
    public async Task<int> Register(RegisterVM registerVM)
    {
        int result = 0;

        Employee employee = new Employee
        {
            OfficeCode = registerVM.OfficeCode,
            ReportsTo = registerVM.ReportsTo,
            FirstName = registerVM.FirstName,
            LastName = registerVM.LastName,
            Email = registerVM.Email,
            JobTitle = registerVM.JobTitle,
        };
        context.Employees.Add(employee);
        await context.SaveChangesAsync();

        Account account = new Account
        {
            Id = registerVM.OfficeCode,
            Password = registerVM.Password
        };
        context.Accounts.Add(account);
        await context.SaveChangesAsync();

        AccountRole accountRole = new AccountRole
        {
            AccountId = registerVM.OfficeCode,
            RoleId = 2
        };
        context.AccountRoles.Add(accountRole);
        await context.SaveChangesAsync();


        return result;
    }
    public async Task<bool> Login (LoginVM loginVM)
    {
        var result = await context.Employees
            .Include(e => e.Account)
            .Select(e => new LoginVM
            {
                Email = e.Email,
                Password = e.Account.Password
            }).SingleOrDefaultAsync(l => l.Email == loginVM.Email);
        if (result == null)
        {
            return false;
        }
        return Hashing.ValidatePassword(loginVM.Password, result.Password);
    }
    public async Task<UserdataVM> GetUserdata(string email)
    {
        var userdata = (from e in context.Employees
                        join a in context.Accounts
                        on e.Id equals a.Id
                        join ar in context.AccountRoles
                        on a.Id equals ar.AccountId
                        join r in context.Roles
                        on ar.RoleId equals r.Id
                        where e.Email == email
                        select new UserdataVM
                        {
                            Email = e.Email,
                            FullName =  String.Concat(e.FirstName, e.LastName),
                        }).FirstOrDefault();

        return userdata;
    }
    public async Task<IEnumerable<string>> GetRolesByID(string email)
    {
        var getId = await context.Employees.FirstOrDefaultAsync(e => e.Email == email); 
        return await context.AccountRoles.Where(ar => ar.AccountId ==  getId.Id).Join(
            context.Roles,
            ar => ar.RoleId,
            r => r.Id,
            (ar, r) => r.Name).ToListAsync();
    }

}
