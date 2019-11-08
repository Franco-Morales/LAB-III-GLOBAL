using Quatum.Vista.LibroDiarioUI;
using Quatum.Vista.ModalUI;
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
        public void LibroDiario_Load(object sender, System.EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'libroDiarioDatos.TablaDatos' Puede moverla o quitarla según sea necesario.
            this.tablaDatosTableAdapter.Datos(this.libroDiarioDatos.TablaDatos);

        }
    }
}
