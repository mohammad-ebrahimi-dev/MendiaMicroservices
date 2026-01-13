using Microsoft.AspNetCore.Mvc;
using UserService.Infrastructure.Repository;

namespace Gateway.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser _user;

        public UserController(IUser user)
        {
            _user = user;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _user.Get();
            return Ok(result);
        }

       [HttpPost]
        public IActionResult Create([FromBody] CreateUserRequest request)
        {
            var result = _user.Create("test");
            return CreatedAtAction(nameof(GetById), new { id = Guid.NewGuid() }, null);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UpdateUserRequest request)
        {
            var result = _user.Update("test");

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _user.Delete("test");
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
