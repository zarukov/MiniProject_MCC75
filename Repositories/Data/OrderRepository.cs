using MiniProject_MCC75.Contexts;
using MiniProject_MCC75.Models;

namespace MiniProject_MCC75.Repositories.Data;

public class OrderRepository : GeneralRepository<int, Order>
{
    private readonly MyContext context;

    public OrderRepository(MyContext context) : base(context)
	{
        this.context = context;
    }
}
