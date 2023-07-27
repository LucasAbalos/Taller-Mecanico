using Model.Vehiculos;
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
    public class AutoController
    {
        public void AgregarAuto(Auto auto)
        {
            AutoDAO autoDAO = new AutoDAO();
            autoDAO.InsertarAuto(auto);
        }

        public void EliminarAuto(int idAuto)
        {
            AutoDAO autoDAO = new AutoDAO();
            autoDAO.EliminarAuto(idAuto);
        }

        public void ActualizarAuto(Auto auto)
        {
            AutoDAO autoDAO = new AutoDAO();
            autoDAO.ActualizarAuto(auto);
        }
    }
}
