using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;




namespace Servicio_generador.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PasswordController : ControllerBase
    {
        private static readonly Random random = new Random();
        [HttpGet]
        public ActionResult<string> Get()
        {
            return GeneratePassword(5);
        }
        private string GeneratePassword(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private readonly ILogger<PasswordController> _logger;

        public PasswordController(ILogger<PasswordController> logger)
        {
            _logger = logger;
        }
    }
}