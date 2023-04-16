using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Desperfecto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo_Manoobra { get; set; }
        public int Tiempo_Estimado { get; set; }
        public Presupuesto Presupuesto { get; set; }

        public Desperfecto(string descripcion, decimal costo_manoobra, int tiempo_estimado, Presupuesto presupuesto)
        {
            Descripcion = descripcion;
            Costo_Manoobra = costo_manoobra;
            Tiempo_Estimado = tiempo_estimado;
            Presupuesto = presupuesto;
        }

    }
}
