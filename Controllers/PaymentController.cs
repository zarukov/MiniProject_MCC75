using MiniProject_MCC75.Base;
using MiniProject_MCC75.Models;
using MiniProject_MCC75.Repositories.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MiniProject_MCC75.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : BaseController<string, Payment, PaymentRepository>
    {
        public PaymentController(PaymentRepository repository) : base(repository)
        {
        }
    }
}
