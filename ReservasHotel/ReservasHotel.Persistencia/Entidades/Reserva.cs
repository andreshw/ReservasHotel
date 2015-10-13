using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasHotel.Persistencia.Entidades
{
    public class Reserva
    {
        public int Id { get; set; }

        [NotMapped]
        public int IdCliente { get; set; }

        public virtual Cliente Cliente { get; set; }

        public DateTime FerchaInicio { get; set; }

        public DateTime FechaFin { get; set; }
    }
}
