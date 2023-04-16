using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Vehiculos;

namespace Model
{
    public class Presupuesto
    {
        public int Id { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Costo_Total { get; set; }

        public Presupuesto(Vehiculo vehiculo, Cliente cliente, DateTime fecha, decimal costo_total)
        {
            Vehiculo = vehiculo;
            Cliente = cliente;
            Fecha = fecha;
            Costo_Total = costo_total;
        }
    }
}
