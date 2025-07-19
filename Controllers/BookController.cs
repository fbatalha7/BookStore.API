using Microsoft.AspNetCore.Mvc;

namespace BookStore.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        [HttpGet()] 
        public ActionResult Get() =>
            Ok(new { Message = "Welcome to the BookStore API!" });
    }
}
