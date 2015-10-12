using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasHotel.Persistencia.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }

        public string NumeroIdentificacion { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public string Ciudad { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }
    }
}
