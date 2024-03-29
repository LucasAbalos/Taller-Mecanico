﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.Vehiculos;

namespace TallerMecanicoChallenge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<string> tipoVehiculo = new List<string> { "Auto", "Moto" };
            cbTipoVehiculo.DataSource = tipoVehiculo;

            List<int> cantidad = new List<int> { 2, 3, 4, 5 };
            cbCantidadPuertas.DataSource = cantidad;

            TipoAuto[] valores = (TipoAuto[])Enum.GetValues(typeof(TipoAuto));
            cbSegmento.DataSource = valores;

        }

        private void cbTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoVehiculo.SelectedItem.Equals("Moto"))
            {
                cbCantidadPuertas.Hide();
                lblCantPuertas.Hide();
                cbSegmento.Hide();
                lblSegmento.Hide();
                txtCilindrada.Show();
                lblCilindrada.Show();
            }
            else
            {
                cbCantidadPuertas.Show();
                lblCantPuertas.Show();
                cbSegmento.Show();
                lblSegmento.Show();
                txtCilindrada.Hide();
                lblCilindrada.Hide();
            }
        }
    }
}
