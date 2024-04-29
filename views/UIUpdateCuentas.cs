using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaConnection.models;
using LibreriaConnection.controller;

namespace LibreriaConnection.views
{
    public partial class UIUpdateCuentas : Form
    {
        public UIUpdateCuentas()
        {
            InitializeComponent();
        }

        private void SelectCuenta(object sender, EventArgs e)
        {
            ControllerCuentas objcc = new ControllerCuentas();
            List<Cuentas> listaCuentas = objcc.SelectCuentas();
            for (int i = 0; i < listaCuentas.Count; i++)
            {
                string _nombre1Cuenta = listaCuentas[i].Nombre1Cuenta;
                string _nombre2Cuenta = listaCuentas[i].Nombre2Cuenta;
                     
                comboBox1.Items.Add(_nombre1Cuenta + " " + _nombre2Cuenta);

            }

        }
    }
}
