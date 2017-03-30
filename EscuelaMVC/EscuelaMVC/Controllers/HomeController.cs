using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using EscuelaMVC.Models;
using EscuelaMVC.ViewModel;
using EscuelaMVC.Tools;


namespace EscuelaMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Alumno> Datos = AlumnoViewModel.listarContenido();
            ViewBag.Datos = Datos;

            return View();
        }

        public PartialViewResult VerDetalle(int ID)
        {
            Alumno Datos = AlumnoViewModel.ObtenerContenido(ID);
            ViewBag.Datos = Datos;
            return PartialView();
        }

        public ActionResult getImage(int ID)
        {
            Alumno temAlumno = AlumnoViewModel.ObtenerContenido(ID);
            var temImage = ToolImage.Base64StringToBitmap(temAlumno.sImagen);
            var temMapbytes = ToolImage.BitmapToBytes(temImage);
            return File(temMapbytes,"image/jpeg");
        }

        public PartialViewResult Actualizacion(int ID)
        {
            Alumno Datos = AlumnoViewModel.ObtenerContenido(ID);
            ViewBag.Datos = Datos;
            return PartialView();
        }

        public ActionResult Actualizar(AlumnosViewModel Datos)
        {
            AlumnoViewModel.Actualizar(Datos);
            return RedirectToAction("Index");
        }

        public PartialViewResult Eliminar(int ID)
        {
            Alumno Datos = AlumnoViewModel.ObtenerContenido(ID);
            ViewBag.Datos = Datos;
            return PartialView();
        }

        public ActionResult Borrar(int txtpkalumno)
        {
            AlumnoViewModel.Borrar(txtpkalumno);
            return RedirectToAction("Index");
        }
 
        public ActionResult Agregar(AlumnosViewModel Datos)
        {
            AlumnoViewModel.Agregar(Datos);
            return RedirectToAction("Index");
        }
    }
}