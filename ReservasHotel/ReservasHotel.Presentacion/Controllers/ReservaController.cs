using ReservasHotel.Persistencia.Entidades;
using ReservasHotel.Persistencia.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReservasHotel.Presentacion.Controllers
{
    public class ReservaController : Controller
    {
        // GET: Reserva
        [HttpGet]
        public ActionResult CrearReserva(int idCliente)
        {
            ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
            Cliente cliente = clienteRepositorio.ConsultarClientePorId(idCliente);
            Reserva reserva = new Reserva();
            reserva.Cliente = cliente;
            return View(reserva);
        }

        [HttpPost]
        public ActionResult CrearReserva(int idCliente, Reserva reserva)
        {
            ReservaRepositorio repositorio = new ReservaRepositorio();
            ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
            Cliente cliente = clienteRepositorio.ConsultarClientePorId(idCliente);
            reserva.Cliente = cliente;
            repositorio.CrearReserva(reserva);
            return RedirectToAction("VerDetalleCliente", "Cliente");
        }
    }
}