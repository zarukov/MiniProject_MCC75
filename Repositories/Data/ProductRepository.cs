using MiniProject_MCC75.Contexts;
using MiniProject_MCC75.Models;

namespace MiniProject_MCC75.Repositories.Data;

public class ProductRepository : GeneralRepository<int, Product>
{
    private readonly MyContext context;

    public ProductRepository(MyContext context) : base(context)
	{
        this.context = context;
    }
}
