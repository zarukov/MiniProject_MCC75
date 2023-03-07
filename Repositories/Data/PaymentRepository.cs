using MiniProject_MCC75.Contexts;
using MiniProject_MCC75.Models;

namespace MiniProject_MCC75.Repositories.Data;

public class PaymentRepository : GeneralRepository<string, Payment>
{
    private readonly MyContext context;

    public PaymentRepository(MyContext context) : base(context)
	{
        this.context = context;
    }
}
