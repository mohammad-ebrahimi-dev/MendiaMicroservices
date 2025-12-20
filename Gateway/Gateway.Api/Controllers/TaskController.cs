using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gateway.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private static readonly List<TaskDto> Tasks = new List<TaskDto>();

        [HttpGet]
        public ActionResult<IEnumerable<TaskDto>> GetAll()
        {
            return Ok(Tasks);
        }

        [HttpGet("{id}")]
        public ActionResult<TaskDto> GetById(int id)
        {
            var task = Tasks.Find(t => t.Id == id);
            if (task == null)
                return NotFound();

            return Ok(task);
        }

        [HttpPost]
        public ActionResult<TaskDto> Create([FromBody] TaskDto newTask)
        {
            newTask.Id = Tasks.Count + 1; 
            Tasks.Add(newTask);
            return CreatedAtAction(nameof(GetById), new { id = newTask.Id }, newTask);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] TaskDto updatedTask)
        {
            var task = Tasks.Find(t => t.Id == id);
            if (task == null)
                return NotFound();

            task.Title = updatedTask.Title;
            task.Description = updatedTask.Description;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var task = Tasks.Find(t => t.Id == id);
            if (task == null)
                return NotFound();

            Tasks.Remove(task);
            return NoContent();
        }
        public class TaskDto
        {
            public int Id { get; set; }
            public string Title { get; set; } = string.Empty;
            public string Description { get; set; } = string.Empty;
        }
    }
}
