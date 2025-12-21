using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gateway.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }

       [HttpPost]
        public IActionResult Create([FromBody] CreateUserRequest request)
        {
            return CreatedAtAction(nameof(GetById), new { id = Guid.NewGuid() }, null);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, [FromBody] UpdateUserRequest request)
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            return NoContent();
        }
        public class CreateUserRequest
        {
            public int MyProperty { get; set; }
        }
        public class UpdateUserRequest
        {
            public int MyProperty { get; set; }
        }
    }
}
