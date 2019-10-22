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
            _ = new ModalController(this);
        }
    }
}
