﻿using ReservasHotel.Persistencia.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasHotel.Persistencia
{
    public class ReservasHotelDB : DbContext
    {
        public ReservasHotelDB()
            : base("DefaultConnection")
        {
            Database.SetInitializer<ReservasHotelDB>(null);
        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Habitacion> Habitaciones { get; set; }

        public DbSet<Reserva> Reservas { get; set; }
    }
}
