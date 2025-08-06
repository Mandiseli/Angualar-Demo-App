using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Server.Models;

namespace Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class DataController : ControllerBase
    {
        private static readonly List<DataItem> _items = new()
        {
            new DataItem { Id = 1, Name = "Alice", City = "Cape Town", Age = 28, Status = "Active", CreatedDate = DateTime.UtcNow },
            new DataItem { Id = 2, Name = "Bob", City = "Johannesburg", Age = 35, Status = "Inactive", CreatedDate = DateTime.UtcNow }
        };

        [HttpGet]
        public IActionResult GetAll() => Ok(_items);
    }
}
