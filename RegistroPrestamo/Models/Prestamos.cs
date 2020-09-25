using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroPrestamo.Models
{
    public class Prestamos
    {
        [Key]
        public int PrestamoId { get; set; }
        [Required(ErrorMessage = "Introduzca una Fecha")]
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "Introduzca una PersonaId")]
        public int PersonaId { get; set; }
        [Required(ErrorMessage = "Introduzca un Conepto")]
        public string Concepto { get; set; }
        [Required(ErrorMessage = "Introduzca un Monto")]
        public decimal Monto { get; set; }
        [Required(ErrorMessage = "Introduzca un Balance")]
        public decimal Balance { get; set; }
        public Prestamos()
        {
            PrestamoId = 0;
            Fecha = DateTime.Now;
            PersonaId = 0;
            Concepto = string.Empty;
            Monto = 0;
            Balance = 0;
        }
    }
}