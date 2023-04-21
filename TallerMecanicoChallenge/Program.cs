using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerMecanicoChallenge
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());


            Cliente cliente = new Cliente("nom", "ape", "dni", "dir", "tel", "mail");

            ClienteController clienteController = new ClienteController();

            clienteController.AgregarCliente(cliente);
        }
    }
}
