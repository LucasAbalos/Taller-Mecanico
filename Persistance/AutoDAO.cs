using Model;
using Model.Vehiculos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 En esta capa se define la clase AutoDAO que se encargará de la conexión a la base de datos y 
de realizar las operaciones de inserción, actualización y eliminación de Autos utilizando Stored Procedures.
*/
namespace Persistance
{
    public class AutoDAO
    {
        public void InsertarAuto(Auto auto)
        {
            try
            {
                ConexionBD conec = new ConexionBD();
                SqlConnection connection = conec.devConexion();

                // Crear un objeto SqlCommand para invocar el stored procedure InsertarAuto
                SqlCommand command = new SqlCommand("InsertarAuto", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros al stored procedure
                command.Parameters.AddWithValue("@marca", auto.Marca);
                command.Parameters.AddWithValue("@modelo", auto.Modelo);
                command.Parameters.AddWithValue("@patente", auto.Patente);
                command.Parameters.AddWithValue("@cliente", auto.Cliente);
                command.Parameters.AddWithValue("@tipo", auto.Tipo);
                command.Parameters.AddWithValue("@cantidad_puertas", auto.CantidadPuertas);

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

        public void EliminarAuto(int autoId)
        {
            try
            {
                ConexionBD conec = new ConexionBD();
                SqlConnection connection = conec.devConexion();

                // Crear un objeto SqlCommand para invocar el stored procedure EliminarAuto
                SqlCommand command = new SqlCommand("EliminarAuto", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                // Agregar parámetro al stored procedure
                command.Parameters.AddWithValue("@AutoId", autoId);

                // Abrir la conexión
                connection.Open();

                // Ejecutar el stored procedure
                command.ExecuteNonQuery();

                // Cerrar la conexión
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el Auto: " + ex.Message);
            }
        }

        public void ActualizarAuto(Auto auto)
        {
            try
            {
                ConexionBD conec = new ConexionBD();
                SqlConnection connection = conec.devConexion();

                // Crear un objeto SqlCommand para invocar el stored procedure ActualizarAuto
                SqlCommand command = new SqlCommand("ActualizarAuto", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                // Agregar parámetros al stored procedure
                command.Parameters.AddWithValue("@AutoId", auto.Id);
                command.Parameters.AddWithValue("@marca", auto.Marca);
                command.Parameters.AddWithValue("@modelo", auto.Modelo);
                command.Parameters.AddWithValue("@patente", auto.Patente);
                command.Parameters.AddWithValue("@cliente", auto.Cliente);
                command.Parameters.AddWithValue("@tipo", auto.Tipo);
                command.Parameters.AddWithValue("@cantidad_puertas", auto.CantidadPuertas);

                // Abrir la conexión
                connection.Open();

                // Ejecutar el stored procedure
                command.ExecuteNonQuery();

                // Cerrar la conexión
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar el Auto: " + ex.Message);
            }
        }
    }
}
