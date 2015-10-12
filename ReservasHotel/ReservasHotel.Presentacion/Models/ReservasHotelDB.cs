using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ReservasHotel.Presentacion.Models
{
    public class ReservasHotelDB : DbContext
    {
        public ReservasHotelDB()
            : base("DefaultConnection")
        { }
        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Habitacion> Habitaciones { get; set; }
    }
}