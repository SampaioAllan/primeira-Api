using Microsoft.AspNetCore.Mvc;
namespace PrimeiraApi.Web.Controllers
{
    [ApiController]
    [Route("Minha Controller")]
    public class PrimeiraController : ControllerBase
    {
        [HttpGet]
        public string PrimeiraApi(){
            return "teste";
        }

         [HttpGet("segunda Api")]
        public string SegundaApi(){
            return "teste numero 2";
        }

         [HttpGet("Terceira Api")]
        public IActionResult TerceiraApi(int entrada){
            return Ok(entrada);
        }

        [HttpGet("Quarta Api")]
        public IActionResult QuartaApi(int entrada){
            if(entrada==1)
            {
                return BadRequest("1 não é compativel");
            }
            return Ok(entrada);
        }
    }
}