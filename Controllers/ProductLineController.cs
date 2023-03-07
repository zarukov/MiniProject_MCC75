using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniProject_MCC75.Base;
using MiniProject_MCC75.Models;
using MiniProject_MCC75.Repositories.Data;

namespace MiniProject_MCC75.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductLineController : BaseController<int, ProductLine, ProductLineRepository>
{
    public ProductLineController(ProductLineRepository productLineRepository) : base (productLineRepository)
    {
    }
}

