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
            return GeneratePasswordBack();
        }
        private string GeneratePassword(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private string GeneratePasswordBack()
        {
            string password;
            Random rnd = new Random();
            string caracteresEspeciales = "!@#$%^&*+-_.,<>/¿?;%=|(){}[]";
            string guid = Guid.NewGuid().ToString("N"); // Genera un GUID en formato sin guiones ni caracteres especiales
            password = guid.Substring(1, 2);
            string password2 = guid.Substring(4, 1);// Tomar los primeros 5 caracteres del GUID
            password += caracteresEspeciales[rnd.Next(0, caracteresEspeciales.Length)] + password2 + caracteresEspeciales[rnd.Next(0, caracteresEspeciales.Length)]; // Agregar un carácter especial al final de la contraseña
            return password;
        }


        private readonly ILogger<PasswordController> _logger;

        public PasswordController(ILogger<PasswordController> logger)
        {
            _logger = logger;
        }
    }
}