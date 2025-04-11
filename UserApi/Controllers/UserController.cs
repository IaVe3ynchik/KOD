using Microsoft.AspNetCore.Mvc;

namespace UserApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private static readonly List<string> Users = new()
        {
            "Vasya Ivanov",
            "Nikolay Ivanov",
        };

        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(Users);
        }

        [HttpPost]
        public IActionResult AddUser([FromBody] string user)
        {
            if (string.IsNullOrWhiteSpace(user))
            {
                return BadRequest("Имя не может быть пустым");
            }

            Users.Add(user);
            return CreatedAtAction(nameof(GetUsers), user);
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            if (id < 0 || id >= Users.Count)
            {
                return NotFound();
            }

            Users.RemoveAt(id);
            return NoContent();
        }

    }
}