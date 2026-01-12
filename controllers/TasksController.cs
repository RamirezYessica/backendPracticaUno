using Microsoft.AspNetCore.Mvc;
using Backend.Models;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        private static readonly List<TaskItem> Tasks = new();
        private static int _nextId = 1;

        //GET: api/tasks
        [HttpGet]
        public ActionResult<IEnumerable<TaskItem>> GetTasks()
        {
            return Ok(Tasks);
        }

        // POST: api/tasks
        [HttpPost]
        public ActionResult<TaskItem> CreateTask(TaskItem task)
        {
            task.Id = _nextId++;
            Tasks.Add(task);
            return Ok(task);
         
        }

        // PUT: api/tasks/{id}/complete
        [HttpPut("{id}/complete")]
        public IActionResult CompleteTask(int id)
        {
            var task = Tasks.FirstOrDefault(t => t.Id == id);

            if (task == null)
                return NotFound();

            task.IsCompleted = true;
            return NoContent();
        }
    }
}
