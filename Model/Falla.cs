using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Falla
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo_Manoobra { get; set; }
        public int Tiempo_Estimado { get; set; }

        public Falla(string descripcion, decimal costo_manoobra, int tiempo_estimado)
        {
            Descripcion = descripcion;
            Costo_Manoobra = costo_manoobra;
            Tiempo_Estimado = tiempo_estimado;
        }

    }
}
