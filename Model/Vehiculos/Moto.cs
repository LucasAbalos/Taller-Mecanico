using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Vehiculos
{
    public class Moto : Vehiculo
    {
        public new int Id { get; set; } // utilizo el new para que el compilador no confunda el Id de Moto con el de Vehiculo
        public int Cilindrada { get; set; }

        public Moto(string marca, string modelo, string patente, Cliente cliente, int cilindrada) : base(marca, modelo, patente, cliente)
        {
            Cilindrada = cilindrada;
        }
    }
}
