using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace pracSoapCalculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcController : ControllerBase
    {
        private readonly Calculator obj;

        public CalcController(Calculator obj)
        {
            this.obj = obj;
        }

        [HttpPost("Addition")]
        public IActionResult Add(int n1, int n2)
        {
            int res = obj.sum(n1, n2);
            return Ok(res);
        }

        [HttpPost("Multiplication")]
        public IActionResult multi(int n1, int n2)
        {
            int res = obj.multiply(n1, n2);
            return Ok(res);
        }
        [HttpPost("Divison")]
        public IActionResult div(int n1, int n2)
        {
            int res = obj.divide(n1, n2);
            return Ok(res);
        }
        [HttpPost("Modulus")]
        public IActionResult mod(int n1, int n2)
        {
            int res = obj.modulus(n1, n2);
            return Ok(res);
        }
        [HttpPost("Subtraction")]
        public IActionResult sub(int n1, int n2)
        {
            int res = obj.subtract(n1, n2);
            return Ok(res);
        }
    }
}
