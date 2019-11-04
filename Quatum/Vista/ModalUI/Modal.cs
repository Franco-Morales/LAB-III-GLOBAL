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

namespace Quatum.Vista.ModalUI
{
    public partial class Modal : Form
    {
        public Modal()
        {
            InitializeComponent();
            ModalController controlador = new ModalController(this);
        }

        private void Modal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'globalDataSet1.asientos' Puede moverla o quitarla según sea necesario.
            this.asientosTableAdapter.Fill(this.globalDataSet1.asientos);

        }

    }

}