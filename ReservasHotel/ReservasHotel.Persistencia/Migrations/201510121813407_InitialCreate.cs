namespace ReservasHotel.Persistencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumeroIdentificacion = c.String(),
                        Nombres = c.String(),
                        Apellidos = c.String(),
                        Ciudad = c.String(),
                        FechaNacimiento = c.DateTime(nullable: false),
                        Direccion = c.String(),
                        Telefono = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Habitacions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumeroHabitacion = c.Int(nullable: false),
                        Capacidad = c.Int(nullable: false),
                        TipoHabitacion = c.String(),
                        TieneVistaMarBien = c.Boolean(nullable: false),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Habitacions");
            DropTable("dbo.Clientes");
        }
    }
}
