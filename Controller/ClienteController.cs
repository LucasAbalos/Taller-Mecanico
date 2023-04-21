using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ClienteController
    {
        public void ABMClientes(string nombre, string apellido, string dni, string direccion, string telefono, string email)
        {
            try
            {
                ConexionBD conec = new ConexionBD();
                SqlConnection connection = conec.devConexion();

                // Crear un objeto SqlDataAdapter para obtener los datos de la tabla Cliente
                string selectQuery = "SELECT * FROM Cliente";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connection);

                // Crear un objeto SqlCommandBuilder para generar los comandos INSERT, UPDATE y DELETE automáticamente
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Obtener los datos de la tabla Cliente en un objeto DataSet
                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset, "Cliente");

                // Crear una nueva fila en el objeto DataTable de la tabla Cliente
                DataRow newRow = dataset.Tables["Cliente"].NewRow();
                newRow["nombre"] = nombre;
                newRow["apellido"] = apellido;
                newRow["dni"] = dni;
                newRow["direccion"] = direccion;
                newRow["telefono"] = telefono;
                newRow["email"] = email;

                // Agregar la nueva fila al objeto DataTable de la tabla Cliente
                dataset.Tables["Cliente"].Rows.Add(newRow);

                // Guardar los cambios en la base de datos
                dataAdapter.Update(dataset, "Cliente");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar los registros: " + ex.Message);
            }
        }
    }
}
