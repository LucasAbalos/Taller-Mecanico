using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 En esta capa se define la clase ClienteDAO que se encargará de la conexión a la base de datos y 
de realizar las operaciones de inserción, actualización y eliminación de clientes utilizando Stored Procedures.
*/
namespace Persistance
{
    public class ClienteDAO
    {
        public void InsertarCliente(Cliente cliente)
        {
            try
            {
                ConexionBD conec = new ConexionBD();
                SqlConnection connection = conec.devConexion();

                // Crear un objeto SqlCommand para invocar el stored procedure InsertarCliente
                SqlCommand command = new SqlCommand("InsertarCliente", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros al stored procedure
                command.Parameters.AddWithValue("@nombre", cliente.Nombre);
                command.Parameters.AddWithValue("@apellido", cliente.Apellido);
                command.Parameters.AddWithValue("@dni", cliente.DNI);
                command.Parameters.AddWithValue("@direccion", cliente.Direccion);
                command.Parameters.AddWithValue("@telefono", cliente.Telefono);
                command.Parameters.AddWithValue("@email", cliente.Email);

                // Abrir la conexión
                connection.Open();

                // Ejecutar el stored procedure
                command.ExecuteNonQuery();

                // Cerrar la conexión
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar los registros: " + ex.Message);
            }
        }

        public void EliminarCliente(int clienteId)
        {
            try
            {
                ConexionBD conec = new ConexionBD();
                SqlConnection connection = conec.devConexion();

                // Crear un objeto SqlCommand para invocar el stored procedure EliminarCliente
                SqlCommand command = new SqlCommand("EliminarCliente", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                // Agregar parámetro al stored procedure
                command.Parameters.AddWithValue("@clienteId", clienteId);

                // Abrir la conexión
                connection.Open();

                // Ejecutar el stored procedure
                command.ExecuteNonQuery();

                // Cerrar la conexión
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el cliente: " + ex.Message);
            }
        }

        public void ActualizarCliente(Cliente cliente)
        {
            try
            {
                ConexionBD conec = new ConexionBD();
                SqlConnection connection = conec.devConexion();

                // Crear un objeto SqlCommand para invocar el stored procedure ActualizarCliente
                SqlCommand command = new SqlCommand("ActualizarCliente", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                // Agregar parámetros al stored procedure
                command.Parameters.AddWithValue("@clienteId", cliente.Id);
                command.Parameters.AddWithValue("@nombre", cliente.Nombre);
                command.Parameters.AddWithValue("@apellido", cliente.Apellido);
                command.Parameters.AddWithValue("@dni", cliente.DNI);
                command.Parameters.AddWithValue("@direccion", cliente.Direccion);
                command.Parameters.AddWithValue("@telefono", cliente.Telefono);
                command.Parameters.AddWithValue("@email", cliente.Email);

                // Abrir la conexión
                connection.Open();

                // Ejecutar el stored procedure
                command.ExecuteNonQuery();

                // Cerrar la conexión
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar el cliente: " + ex.Message);
            }
        }
    }
}
