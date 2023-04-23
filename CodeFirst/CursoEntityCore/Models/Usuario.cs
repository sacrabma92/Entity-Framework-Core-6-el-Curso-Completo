﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CursoEntityCore.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        public string NombreUsuario { get; set; }

        // [RegularExpression(@"^[\w-\._\+%]+@(?:[\w-]+\.)+[\w]{2,6}$", ErrorMessage ="Ingrese email valido")]
        [EmailAddress(ErrorMessage = "Email no valido")]
        public string Email { get; set; }

        [Display(Name = "Direccion del usuario")]
        public string Direccion { get; set; }

        [NotMapped]
        public int Edad { get; set; }
    }
}
