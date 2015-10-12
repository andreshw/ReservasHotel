using ReservasHotel.Persistencia.Entidades;
using ReservasHotel.Persistencia.Repositorios;
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
        public ActionResult Index(string nombreCliente)
        {
            ClienteRepositorio repositorio = new ClienteRepositorio();
            IList<Cliente> clientes = new List<Cliente>();

            if (String.IsNullOrEmpty(nombreCliente))
            {
                clientes = repositorio.ConsultarClientes();
            }
            else
            {
                clientes = repositorio.ConsultarClientePorNombre(nombreCliente);
            }
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

        public ActionResult EditarCliente(Cliente cliente)
        {
            ClienteRepositorio repositorio = new ClienteRepositorio();
            repositorio.EditarCliente(cliente);

            IList<Cliente> clientes = repositorio.ConsultarClientes();
            return View("Index", clientes);
        }
	}
}