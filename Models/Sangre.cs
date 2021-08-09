﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tarea9._0.Models
{
    public class Sangre
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(5, ErrorMessage = "El campo {0} no puede contener mas de {1} caracteres)")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string Tipo { get; set; }
        [ForeignKey("IdSangre")]
        public ICollection<Persona> Personas { get; set; }

    }
}