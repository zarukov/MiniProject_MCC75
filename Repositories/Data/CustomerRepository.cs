using MiniProject_MCC75.Contexts;
using MiniProject_MCC75.Models;

namespace MiniProject_MCC75.Repositories.Data;

public class CustomerRepository : GeneralRepository<int, Customer>
{
    private readonly MyContext context;

    public CustomerRepository(MyContext context) : base(context)
	{
        this.context = context;
    }
}
