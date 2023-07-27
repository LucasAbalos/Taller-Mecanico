using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Vehiculos
{
    public abstract class Vehiculo
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Patente { get; set; }
        public Cliente Cliente { get; set; }

        public Vehiculo(string marca, string modelo, string patente, Cliente cliente)
        {
            Marca = marca;
            Modelo = modelo;
            Patente = patente;
            Cliente = cliente;
        }
        public Vehiculo() { }
    }
}
