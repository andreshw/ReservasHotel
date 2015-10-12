using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReservasHotel.Presentacion.Models
{
    public class DetalleReserva
    {
        public int Id { get; set; }

        public Habitacion Habitacion { get; set; }
    }
}