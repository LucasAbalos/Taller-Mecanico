using Model;
using Persistance;
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
        public void AgregarCliente(Cliente cliente)
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            clienteDAO.InsertarCliente(cliente);
        }

        public void EliminarCliente(int idCliente)
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            clienteDAO.EliminarCliente(idCliente);
        }

        public void ActualizarCliente(Cliente cliente)
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            clienteDAO.ActualizarCliente(cliente);
        }
    }
}
