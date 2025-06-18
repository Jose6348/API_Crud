using API_Crud.Comunication.Requests;
using API_Crud.Comunication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace API_Crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        // Requisição do tipo Get 

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public IActionResult GetById([FromRoute] int id)
        {
            var response = new User
            {
                Id = 1,
                Name = "Jorge",
                Age = 30
            };

            return Ok(response);
        }

        // Requisição do tipo Post

        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisterUserJson), StatusCodes.Status201Created)]
        public IActionResult Create([FromBody] RequestRegisterUserJson request)
        {
            var response = new ResponseRegisterUserJson
            {
                Id = 1,
                Name = request.Name
            };

            return Created(string.Empty, response);
        }

    // Requisição do tipo Put

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]

        public IActionResult Update(
            [FromRoute] int id,
            [FromBody] RequestUpdateUserProfileJson request)
        {
            return NoContent();
        }

        // Requisição do tipo Delete

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]

        public IActionResult Delete()
        {
            return NoContent();
        }

    }
}