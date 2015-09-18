using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReservasHotel.Presentacion.Models
{
    public class Habitacion
    {
        public int Id { get; set; }
        public int NumeroHabitacion { get; set; }
        public int Capacidad { get; set; }
        public string TipoHabitacion { get; set; }
        public bool TieneVistaMarBien { get; set; }
        public string Descripcion { get; set; } 
    }
}