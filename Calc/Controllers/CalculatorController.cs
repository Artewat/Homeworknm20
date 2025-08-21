using Microsoft.AspNetCore.Mvc;

namespace CalculatorApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("add")]
        public IActionResult Add([FromQuery] double a, [FromQuery] double b)
        {
            return Ok(new { Operation = "Addition", Result = a + b });
        }

        [HttpGet("subtract")]
        public IActionResult Subtract([FromQuery] double a, [FromQuery] double b)
        {
            return Ok(new { Operation = "Subtraction", Result = a - b });
        }

        [HttpGet("multiply")]
        public IActionResult Multiply([FromQuery] double a, [FromQuery] double b)
        {
            return Ok(new { Operation = "Multiplication", Result = a * b });
        }

        [HttpGet("divide")]
        public IActionResult Divide([FromQuery] double a, [FromQuery] double b)
        {
            if (b == 0)
                return BadRequest(new { Error = "Division by zero is not allowed" });

            return Ok(new { Operation = "Division", Result = a / b });
        }
    }
}
