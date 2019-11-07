using Quatum.Vista.ModalUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quatum.BDPlanCuentas.Consultas;

namespace Quatum.Vista.ModalUI
{
    public partial class Modal : Form
    {
        public Modal()
        {
            InitializeComponent();
            ModalController controlador = new ModalController(this);
            textCantidad.Text = "2";
            btnDisminuir.Enabled = false;
        }

        private void Modal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'globalDataSet.plan_cuentas' Puede moverla o quitarla según sea necesario.
            //this.plan_cuentasTableAdapter.Fill(this.globalDataSet.plan_cuentas);

        }
        
        }
    }