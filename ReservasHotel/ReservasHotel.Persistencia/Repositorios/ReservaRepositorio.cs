using ReservasHotel.Persistencia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasHotel.Persistencia.Repositorios
{
    public class ReservaRepositorio
    {
        public void CrearReserva(Reserva reserva)
        {
            using (ReservasHotelDB contexto = new ReservasHotelDB())
            {
                reserva.Cliente = contexto.Clientes.FirstOrDefault(c => c.Id == reserva.IdCliente);
                contexto.Reservas.Add(reserva);
                contexto.SaveChanges();
            }
        }
    }
}
