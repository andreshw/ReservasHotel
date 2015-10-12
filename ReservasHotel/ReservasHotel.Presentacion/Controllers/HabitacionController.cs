using ReservasHotel.Persistencia.Entidades;
using ReservasHotel.Persistencia.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReservasHotel.Presentacion.Controllers
{
    public class HabitacionController : Controller
    {
        //
        // GET: /Habitacion/
        [HttpGet]
        public ActionResult CrearHabitacion()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CrearHabitacion(Habitacion habitacion)
        {
            HabitacionRepositorio repositorio = new HabitacionRepositorio();
            repositorio.GuardarHabitacion(habitacion);
            return RedirectToAction("ListarHabitaciones");
        }

        [HttpGet]
        public ActionResult EditarHabitacion(int id)
        {
            HabitacionRepositorio repositorio = new HabitacionRepositorio();
            Habitacion habitacion = repositorio.ConsultarHabitacionPorId(id);
            return View(habitacion);
        }

        [HttpPost]
        public ActionResult EditarHabitacion(Habitacion habitacion)
        {
            HabitacionRepositorio repositorio = new HabitacionRepositorio();
            repositorio.EditarHabitacion(habitacion);
            return RedirectToAction("ListarHabitaciones");
        }

        [HttpGet]
        public ActionResult ListarHabitaciones()
        { 
            HabitacionRepositorio repositorio = new HabitacionRepositorio();
            IList<Habitacion> habitaciones = repositorio.ConsultarHabitaciones();
            return View(habitaciones);
        }
	}
}