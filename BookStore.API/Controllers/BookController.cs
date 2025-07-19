using BookStore.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController(IBookService bookService) : ControllerBase
    {
        private readonly IBookService _bookService = bookService;

        [HttpGet()] 
        public async Task<ActionResult> GetAsync() =>
            Ok(await _bookService.GetAsync());

        [HttpGet("{id}")]
        public ActionResult GetAsync(int id) =>
           Ok(new {Message = id});
    }
}
