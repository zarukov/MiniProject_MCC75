using MiniProject_MCC75.Contexts;
using MiniProject_MCC75.Models;

namespace MiniProject_MCC75.Repositories.Data;

public class OrderProductRepository : GeneralRepository<int, OrderProduct>
{
    private readonly MyContext context;

    public OrderProductRepository(MyContext context) : base(context)
	{
        this.context = context;
    }
}
