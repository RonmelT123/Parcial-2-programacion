using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial_2_programacion.Models
{
    public class Suerte
    {
        [Key]
        public string NombreID { get; set; }
        public string Detalle { get; set; }
        public string Imagen { get; set; }
    }
}
