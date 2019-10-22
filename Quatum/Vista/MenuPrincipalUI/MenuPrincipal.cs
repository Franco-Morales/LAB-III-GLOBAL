using System.Windows.Forms;
using Quatum.Controlador;


namespace Quatum.Vista.MenuPrincipalUI
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            MainController cont = new MainController(this);
        }
    }
}
