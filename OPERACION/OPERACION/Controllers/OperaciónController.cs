using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OPERACION.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperaciónController : ControllerBase
    {
        [HttpGet]
        public string cuñape(int numero)
        {
            string respuesta = "";
            if (numero < 0)
            {
                respuesta = "ERROR";
            }
            if (numero == 0)
            {
                respuesta = "Realizado por Alejandro Horacio Sivila Guzman";
            }
            if (numero > 0)
            {
                respuesta = "https://image.freepik.com/vector-gratis/numeros-cartel-imagen_1639-6453.jpg";
            }
            return (respuesta);
        }
    }

}
