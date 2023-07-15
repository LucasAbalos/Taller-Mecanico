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
        public Falla Falla { get; set; }
        public Presupuesto Presupuesto { get; set; }

        public Desperfecto(Falla falla, Presupuesto presupuesto)
        {
            Falla = falla;
            Presupuesto = presupuesto;
        }

    }
}
