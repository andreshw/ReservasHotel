﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ReservasHotel.Presentacion.Models
{
    public class ClienteRepositorio
    {
        public void CrearCliente(Cliente cliente)
        {
            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            conexion.Open();

            SqlCommand comand = new SqlCommand("INSERT INTO Clientes(NumeroIdentificacion, " +
                                               "Nombre, " +
                                               "Apellidos, " +
                                               "Ciudad, " + 
                                               "FechaNacimiento, " +
                                               "Direccion, " +
                                               "Telefono, " +
                                               "NumeroAcompanantes) " +
                                               "VALUES" +
                                               "('" + cliente.NumeroIdentificacion + "','" +
                                               cliente.Nombres + "','" +
                                               cliente.Apellidos + "','" +
                                               cliente.Ciudad + "','" +
                                               cliente.FechaNacimiento.ToShortDateString() + "','" +
                                               cliente.Direccion + "','" +
                                               cliente.Telefono + "'," +
                                               "0)", conexion);

            comand.ExecuteNonQuery();
            conexion.Close();
        }

        public IList<Cliente> ConsultarClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            conexion.Open();
            SqlCommand comando = new SqlCommand("select * from Clientes", conexion);

            SqlDataReader reader = comando.ExecuteReader();
            
            while (reader.Read())
            {
                Cliente cliente = new Cliente();

                cliente.Id = (int)reader["Id"];
                cliente.NumeroIdentificacion = reader["NumeroIdentificacion"].ToString();
                cliente.Nombres = reader["Nombre"].ToString();
                cliente.Apellidos = reader["Apellidos"].ToString();
                cliente.FechaNacimiento = (DateTime)reader["FechaNacimiento"];
                cliente.Ciudad = reader["Ciudad"].ToString();
                cliente.Direccion = reader["Direccion"].ToString();
                cliente.Telefono = reader["Telefono"].ToString();

                clientes.Add(cliente);
            }
            
            conexion.Close();
            return clientes;
        }
    }
}