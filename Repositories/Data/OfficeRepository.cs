using MiniProject_MCC75.Contexts;
using MiniProject_MCC75.Models;

namespace MiniProject_MCC75.Repositories.Data;

public class OfficeRepository : GeneralRepository<int, Office>
{
    private readonly MyContext context;

    public OfficeRepository( MyContext context) : base( context )
	{
        this.context = context;
    }
}
