using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReservasHotel.Presentacion.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }

        public DateTime FechaInicio { get; set; }

        public int NumeroAcompañantes { get; set; }

        public int FechaSalida { get; set; }
    }
}