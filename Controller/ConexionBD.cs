﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ConexionBD
    {
        public SqlConnection devConexion()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TallerMecanico;User ID=admin;Password=m3canico;";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
