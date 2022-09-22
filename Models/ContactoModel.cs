using System;
using System.ComponentModel.DataAnnotations;
namespace CRUDCORE.Models
{
    public class ContactoModel
    {
        public int IdContacto { get; set; }

        [Required(ErrorMessage ="Name is required")]

        public string? Nombre { get; set; }
        [Required(ErrorMessage = "Phone Number is required")]

        public string? Telefono { get; set; }
        [Required(ErrorMessage = "E-mail is required")]

        public string? Correo { get; set; }

    }
}

