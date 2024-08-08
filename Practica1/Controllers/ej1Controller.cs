using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Practica1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ej1Controller : ControllerBase
    {
        [HttpGet("Suma")]

        public int Get(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        
    }
}