﻿using System.ComponentModel.DataAnnotations;
namespace Tarea1.Models
{
    public class Ocupaciones
    {
        [Key]
        public int OcupacionId { get; set; }

        [Required(ErrorMessage ="La descripcion es requerida")]
        public string Descripcion { get; set; }

        [Range(minimum:100, maximum:2000000, ErrorMessage ="El salario no esta dentro del rango requerido ( entre 100 y 2,000,000)")]
        public float? Salario { get; set; }

      

    }
}
