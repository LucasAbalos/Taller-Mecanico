using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Desperfecto_Repuesto
    {
        public int Id { get; set; }
        public Desperfecto Desperfecto { get; set; }      
        public Repuesto Repuesto { get; set; }

        public Desperfecto_Repuesto(Desperfecto desperfecto, Repuesto repuesto)
        {
            Desperfecto = desperfecto;
            Repuesto = repuesto;
        }
    }
}
