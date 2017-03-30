using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EscuelaMVC.Models;
using System.Data.Entity;

namespace EscuelaMVC.ViewModel
{
    public class AlumnoViewModel
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

        public static Alumno ObtenerContenido(int ID)
        {
            try
            {
                var ctx = new DataModel();
                return ctx.Alumno.Where(r => r.pkAlumnos == ID && r.bStatus == true).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Actualizar(AlumnosViewModel datos)
        {
            try
            {
                Alumno talumno = ObtenerContenido(datos.txtpkalumno);
                talumno.sNombre = datos.txtNombre;
                talumno.sApellido = datos.txtApellido;
                talumno.sGrupo = datos.txtGrupo;

                var ctx = new DataModel();
                ctx.Entry(talumno).State = EntityState.Modified;
                ctx.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void Agregar(AlumnosViewModel datos)
        {
            try
            {
                Alumno talumno = new Alumno();
                talumno.sNombre = datos.txtNombre;
                talumno.sApellido = datos.txtApellido;
                talumno.sGrupo = datos.txtGrupo;

                var ctx = new DataModel();
                ctx.Entry(talumno).State = EntityState.Added;
                ctx.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void Borrar(int id)
        {
            try
            {
                Alumno talumno = ObtenerContenido(id);
                talumno.bStatus = false;

                var ctx = new DataModel();
                ctx.Entry(talumno).State = EntityState.Modified;
                ctx.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
