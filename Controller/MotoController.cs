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
    public class MotoController
    {
        public void AgregarMoto(Moto moto)
        {
            MotoDAO motoDAO = new MotoDAO();
            motoDAO.InsertarMoto(moto);
        }

        public void EliminarMoto(int idMoto)
        {
            MotoDAO motoDAO = new MotoDAO();
            motoDAO.EliminarMoto(idMoto);
        }

        public void ActualizarMoto(Moto moto)
        {
            MotoDAO motoDAO = new MotoDAO();
            motoDAO.ActualizarMoto(moto);
        }
    }
}
