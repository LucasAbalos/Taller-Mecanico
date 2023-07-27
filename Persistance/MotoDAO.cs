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
 En esta capa se define la clase MotoDAO que se encargará de la conexión a la base de datos y 
de realizar las operaciones de inserción, actualización y eliminación de Motos utilizando Stored Procedures.
*/
namespace Persistance
{
    public class MotoDAO
    {
        public void InsertarMoto(Moto moto)
        {
            try
            {
                ConexionBD conec = new ConexionBD();
                SqlConnection connection = conec.devConexion();

                // Crear un objeto SqlCommand para invocar el stored procedure InsertarMoto
                SqlCommand command = new SqlCommand("InsertarMoto", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros al stored procedure
                command.Parameters.AddWithValue("@marca", moto.Marca);
                command.Parameters.AddWithValue("@modelo", moto.Modelo);
                command.Parameters.AddWithValue("@patente", moto.Patente);
                command.Parameters.AddWithValue("@cliente", moto.Cliente);
                command.Parameters.AddWithValue("@cilindrada", moto.Cilindrada);

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

        public void EliminarMoto(int motoId)
        {
            try
            {
                ConexionBD conec = new ConexionBD();
                SqlConnection connection = conec.devConexion();

                // Crear un objeto SqlCommand para invocar el stored procedure EliminarMoto
                SqlCommand command = new SqlCommand("EliminarMoto", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                // Agregar parámetro al stored procedure
                command.Parameters.AddWithValue("@MotoId", motoId);

                // Abrir la conexión
                connection.Open();

                // Ejecutar el stored procedure
                command.ExecuteNonQuery();

                // Cerrar la conexión
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el Moto: " + ex.Message);
            }
        }

        public void ActualizarMoto(Moto moto)
        {
            try
            {
                ConexionBD conec = new ConexionBD();
                SqlConnection connection = conec.devConexion();

                // Crear un objeto SqlCommand para invocar el stored procedure ActualizarMoto
                SqlCommand command = new SqlCommand("ActualizarMoto", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                // Agregar parámetros al stored procedure
                command.Parameters.AddWithValue("@MotoId", moto.Id);
                command.Parameters.AddWithValue("@marca", moto.Marca);
                command.Parameters.AddWithValue("@modelo", moto.Modelo);
                command.Parameters.AddWithValue("@patente", moto.Patente);
                command.Parameters.AddWithValue("@cliente", moto.Cliente);
                command.Parameters.AddWithValue("@cilindrada", moto.Cilindrada);

                // Abrir la conexión
                connection.Open();

                // Ejecutar el stored procedure
                command.ExecuteNonQuery();

                // Cerrar la conexión
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar el Moto: " + ex.Message);
            }
        }
    }
}
