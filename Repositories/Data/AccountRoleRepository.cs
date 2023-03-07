using MiniProject_MCC75.Contexts;
using MiniProject_MCC75.Models;

namespace MiniProject_MCC75.Repositories.Data;

public class AccountRoleRepository : GeneralRepository<int, AccountRole>
{
    private readonly MyContext context;

    public AccountRoleRepository(MyContext context) : base(context)
	{
        this.context = context;
    }
}
