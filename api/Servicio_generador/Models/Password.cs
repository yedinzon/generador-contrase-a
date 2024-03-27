using System.ComponentModel.DataAnnotations;


namespace Servicio_generador.Models
{
    public class Password
    {
        [Key]
        public int idContraseñas { get; set; }
        [Required]
        public DateTime fecha {  get; set; }
        [Required]
        public string Ip { get; set; }
        [Required]
        public string contraseña { get; set; }
    }
}
