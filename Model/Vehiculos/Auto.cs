using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Vehiculos
{
    public class Auto : Vehiculo
    {
        public new int Id { get; set; } // utilizo el new para que el compilador no confunda el Id de Moto con el de Vehiculo
        public TipoAuto Tipo { get; set; }
        public int CantidadPuertas { get; set; }

        public Auto(string marca, string modelo, string patente, Cliente cliente, TipoAuto tipo, int cantidadPuertas) : base(marca, modelo, patente, cliente)
        {
            Tipo = tipo;
            CantidadPuertas = cantidadPuertas;
        }
    }
}
