using ReservasHotel.Presentacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReservasHotel.Presentacion.Controllers
{
    public class ClienteController : Controller
    {
        //
        // GET: /Cliente/
        public ActionResult Index()
        {
            ClienteRepositorio repositorio = new ClienteRepositorio();
            IList<Cliente> clientes = repositorio.ConsultarClientes();
            return View(clientes);
        }

        [HttpGet]
        public ActionResult CrearCliente()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CrearCliente(Cliente cliente)
        {
            ClienteRepositorio repositorio = new ClienteRepositorio();
            repositorio.CrearCliente(cliente);

            IList<Cliente> clientes = repositorio.ConsultarClientes();
            return View("Index", clientes);
        }

        [HttpGet]
        public ActionResult EditarCliente(int id)
        {
            ClienteRepositorio repositorio = new ClienteRepositorio();
            Cliente cliente = repositorio.ConsultarClientePorId(id);
            return View(cliente);
        }
	}
}