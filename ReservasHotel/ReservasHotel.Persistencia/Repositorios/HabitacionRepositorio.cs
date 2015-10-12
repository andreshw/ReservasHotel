using ReservasHotel.Persistencia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasHotel.Persistencia.Repositorios
{
    public class HabitacionRepositorio
    {
        public IList<Habitacion> ConsultarHabitaciones()
        {
            using (ReservasHotelDB contexto = new ReservasHotelDB())
            {
                IList<Habitacion> habitaciones = contexto.Habitaciones.ToList();
                return habitaciones;
            }
        }

        public Habitacion ConsultarHabitacionPorNumero(int numeroHabitacion)
        {
            using (ReservasHotelDB contexto = new ReservasHotelDB())
            {
                Habitacion habitacion = contexto.Habitaciones.FirstOrDefault(h => h.NumeroHabitacion == numeroHabitacion);
                return habitacion;
            }
        }

        public Habitacion ConsultarHabitacionPorId(int id)
        {
            using (ReservasHotelDB contexto = new ReservasHotelDB())
            {
                Habitacion habitacion = contexto.Habitaciones.FirstOrDefault(h => h.Id == id);
                return habitacion;
            }
        }

        public void GuardarHabitacion(Habitacion habitacion)
        {
            using (ReservasHotelDB contexto = new ReservasHotelDB())
            {
                contexto.Habitaciones.Add(habitacion);
                contexto.SaveChanges();
            }
        }

        public void EditarHabitacion(Habitacion habitacion)
        {
            using (ReservasHotelDB contexto = new ReservasHotelDB())
            {
                Habitacion habitacionEditar = contexto.Habitaciones.FirstOrDefault(h => h.Id == habitacion.Id);
                habitacionEditar.Capacidad = habitacion.Capacidad;
                habitacionEditar.Descripcion = habitacion.Descripcion;
                habitacionEditar.NumeroHabitacion = habitacion.NumeroHabitacion;
                habitacionEditar.TieneVistaMarBien = habitacion.TieneVistaMarBien;
                habitacionEditar.TipoHabitacion = habitacion.TipoHabitacion;

                contexto.SaveChanges();
            }
        }
    }
}
