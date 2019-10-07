using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quatum.Controlador;

namespace Quatum.GUI
{
    public partial class LibroDiario : Form
    {
        public LibroDiario()
        {
            InitializeComponent();
            LDController controlador = new LDController(this);
        }
    }
}
