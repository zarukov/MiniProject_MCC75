using MiniProject_MCC75.Base;
using MiniProject_MCC75.Models;
using MiniProject_MCC75.Repositories.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MiniProject_MCC75.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : BaseController<int, Role, RoleRepository>
    {
        public RoleController(RoleRepository repository) : base(repository)
        {
        }
    }
}
