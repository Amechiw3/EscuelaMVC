using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EscuelaMVC.Models;
using System.Data.Entity;


namespace EscuelaMVC.ViewModel
{
    class AlumnoViewModel
    {
        public static List<Alumno> listarContenido()
        {
            try
            {
                var ctx = new DataModel();
                return ctx.Alumno.Where(r => r.bStatus == true).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<Alumno> ObtenerContenido(int ID)
        {
            try
            {
                var ctx = new DataModel();
                return ctx.Alumno.Where(r => r.pkAlumnos == ID && r.bStatus == true).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
