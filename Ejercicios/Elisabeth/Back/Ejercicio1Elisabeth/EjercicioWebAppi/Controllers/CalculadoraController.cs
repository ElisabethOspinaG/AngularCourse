using EjercicioWebAppi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EjercicioWebAppi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculadoraController : ControllerBase
    {
        CalculatorService calculatorService = new CalculatorService(); // Crea una instancia global
        
        [HttpGet("sumar")]
        public int sumar(int num1, int num2)
        {
            var suma = calculatorService.sumar(num1, num2);
            return suma;
        }

        [HttpGet("restar")]
        public int restar(int num1, int num2)
        {
            var resta = calculatorService.restar(num1, num2);
            return resta;
        }

    }
}
