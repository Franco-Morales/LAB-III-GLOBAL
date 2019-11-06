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

        private void LibroDiario_Load(object sender, System.EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'globalDataSetLibroDiario.DataTable1' Puede moverla o quitarla según sea necesario.
            this.dataTable1TableAdapter.Fill(this.globalDataSetLibroDiario.DataTable1);

        }
    }
}
