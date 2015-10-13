using ReservasHotel.Persistencia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasHotel.Persistencia.Repositorios
{
    public class ClienteRepositorio
    {
        public void CrearCliente(Cliente cliente)
        {
            using (ReservasHotelDB contexto = new ReservasHotelDB())
            {
                contexto.Clientes.Add(cliente);
                contexto.SaveChanges();
            }
        }

        public IList<Cliente> ConsultarClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            using (ReservasHotelDB contexto = new ReservasHotelDB())
            {
                clientes = contexto.Clientes.ToList();
                return clientes;
            }
        }

        public Cliente ConsultarClientePorId(int idCliente)
        {
            using (ReservasHotelDB contexto = new ReservasHotelDB())
            {
                Cliente cliente = contexto.Clientes.Include("Reservas").FirstOrDefault(c => c.Id == idCliente);
                return cliente;
            }
        }

        public void EditarCliente(Cliente cliente)
        {
            using (ReservasHotelDB contexto = new ReservasHotelDB())
            {
                Cliente clienteModificar = contexto.Clientes.FirstOrDefault(c => c.Id == cliente.Id);

                clienteModificar.Nombres = cliente.Nombres;
                clienteModificar.NumeroIdentificacion = cliente.NumeroIdentificacion;
                clienteModificar.Telefono = cliente.Telefono;
                clienteModificar.FechaNacimiento = cliente.FechaNacimiento;
                clienteModificar.Direccion = cliente.Direccion;
                clienteModificar.Ciudad = cliente.Ciudad;
                clienteModificar.Apellidos = cliente.Apellidos;

                contexto.SaveChanges();
            }
        }

        public List<Cliente> ConsultarClientePorNombre(string nombreCliente)
        {
            using (ReservasHotelDB contexto = new ReservasHotelDB())
            {
                List<Cliente> clientes = contexto.Clientes.Where(c => c.Nombres.Contains(nombreCliente)).ToList();
                return clientes;
            }
        }
    }
}
