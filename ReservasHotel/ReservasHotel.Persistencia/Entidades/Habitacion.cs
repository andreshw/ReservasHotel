using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasHotel.Persistencia.Entidades
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
