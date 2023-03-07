using MiniProject_MCC75.Contexts;
using MiniProject_MCC75.Models;

namespace MiniProject_MCC75.Repositories.Data;

public class ProductLineRepository : GeneralRepository<int, ProductLine>
{
    private readonly MyContext context;

    public ProductLineRepository(MyContext context) : base(context)
	{
        this.context = context;
    }
}
