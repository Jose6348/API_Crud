using Microsoft.AspNetCore.Mvc;

namespace API_Crud.Controllers
{
    public class DeviceController : API_CrudBaseController
    {

        [HttpGet]

        public IActionResult Get()
        {
            return Ok(Author);
        }
    }
}
