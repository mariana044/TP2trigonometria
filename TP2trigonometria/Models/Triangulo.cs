using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TP2trigonometria.Models
{
    public class Triangulo
    {

        [Required] 
        [Range(0.01, double.MaxValue, ErrorMessage ="El lado a debe ser mayor que 0.")]
        public double a {  get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "El lado a debe ser mayor que 0.")]
        public double b { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "El lado a debe ser mayor que 0.")]
        public double c { get; set; }
        }
    }