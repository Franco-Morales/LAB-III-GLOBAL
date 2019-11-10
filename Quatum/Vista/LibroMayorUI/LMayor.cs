using System.Windows.Forms;


namespace Quatum.Vista.LibroMayorUI
{
    public partial class LMayor : Form
    {
        public LMayor()
        {
            InitializeComponent();
            LMController controlador = new LMController(this);
        }
    }
}
