using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace OurFirstHomeworkAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<string>> GetAllUsers()
        {
            return StatusCode(StatusCodes.Status200OK, UsersDb.Users);
        }

        [HttpGet("{index}")]
        public ActionResult<string> GetUserById(int index)
        {
            try
            {
                if (index < 0)
                {
                    return StatusCode(StatusCodes.Status400BadRequest, "Unfortunately a user with such an id does not exist as it's value is in the negative");
                }
                if (index > UsersDb.Users.Count)
                {
                    return StatusCode(StatusCodes.Status404NotFound, $"There is no user that can be found with the {index} id");
                }
                return StatusCode(StatusCodes.Status200OK, UsersDb.Users[index]);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] string newUser)
        {
            try
            {
                if (string.IsNullOrEmpty(newUser))
                {
                    return StatusCode(StatusCodes.Status400BadRequest, "The body on this request is not permitted to be empty!!!");
                }
                UsersDb.Users.Add(newUser);
                return StatusCode(StatusCodes.Status200OK, "New User has been created");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpDelete]
        public IActionResult DeleteUser([FromBody] string deleteNote)
        {
            if (string.IsNullOrEmpty(deleteNote))
            {
                return StatusCode(StatusCodes.Status400BadRequest, "The body of the request must not be empty");
            }
            if (!UsersDb.Users.Contains(deleteNote))
            {
                return StatusCode(StatusCodes.Status404NotFound, "The user that you want to delete has not been found in the database!!!");
            }
            UsersDb.Users.Remove(deleteNote);
            return StatusCode(StatusCodes.Status204NoContent);
        }

    }
}
