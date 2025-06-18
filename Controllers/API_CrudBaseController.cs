using Microsoft.AspNetCore.Mvc;

namespace API_Crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class API_CrudBaseController : ControllerBase
    {
        public string Author { get; set; } = "Jorge";
    }
}
