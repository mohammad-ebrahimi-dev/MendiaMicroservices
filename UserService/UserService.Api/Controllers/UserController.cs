using Microsoft.AspNetCore.Mvc;
using UserService.Domain.Entity;
using UserService.Infrastructure.Repository;

namespace Gateway.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IRepository _user;

        public UserController(IRepository user)
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
            //var result = _user.Get();
            return Ok();
        }

       [HttpPost]
        public IActionResult Create([FromBody] CreateUserRequest request)
        {
            var result = _user.AddAsync(new User
            {
                
            });
            return CreatedAtAction(nameof(GetById), new { id = Guid.NewGuid() }, null);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UpdateUserRequest request)
        {
            //var result = _user.Update("test");

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //var result = _user.Delete("test");
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
