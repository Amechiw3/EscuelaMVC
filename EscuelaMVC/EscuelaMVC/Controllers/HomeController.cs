using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using EscuelaMVC.Models;
using EscuelaMVC.ViewModel;


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
            List<Alumno> Datos = AlumnoViewModel.ObtenerContenido(ID);
            ViewBag.Datos = Datos;
            return PartialView();
        }
    }
}