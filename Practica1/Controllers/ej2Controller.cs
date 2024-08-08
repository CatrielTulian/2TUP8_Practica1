using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Practica1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ej2Controller : ControllerBase
    {
        
        [HttpGet("NombreCiudad")]
        public string Get(string nombre, string ciudad)
        {
            return $"Hola {nombre}, Bienvenido a {ciudad}";
        }
    }
}