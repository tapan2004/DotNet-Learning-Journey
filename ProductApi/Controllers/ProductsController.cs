using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using ProductApi.Models;

namespace ProductApi.Controllers
{[ApiController]
[Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
      

        [HttpGet("{Id}")]
        public ActionResult<Product> GetById(int Id)
        {
        }

    }
}