using Quatum.Vista.LibroDiarioUI;
using System.Windows.Forms;

namespace Quatum.Vista.LibroDiarioUI
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
