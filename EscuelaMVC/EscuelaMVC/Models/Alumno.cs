using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EscuelaMVC.Models
{
    public class Alumno
    {
        [Key]
        public int pkAlumnos { get; set; }

        [Required(ErrorMessage = "Nombre del alumnos requerido")]
        public String sNombre { get; set; }

        [Required(ErrorMessage = "Apellidos del alumnos requeridos")]
        public String sApellido { get; set; }

        [Required(ErrorMessage = "Grupo del alumnos requerido")]
        public String sGrupo { get; set; }

        public String sImagen { get; set; }

        public Boolean bStatus { get; set; }

        public Alumno()
        {
            this.bStatus = true;
        }
    }
}
