using System.Windows.Forms;


namespace Quatum.Vista.LibroMayorUI
{
    public partial class LMayor : Form
    {

        LMController controlador;
        public LMayor()
        {
            InitializeComponent();
        }

        private void LMayor_Load(object sender, System.EventArgs e)
        {
            controlador = new LMController(this);
            // TODO: esta línea de código carga datos en la tabla 'libroDiarioDatos.TablaDatos' Puede moverla o quitarla según sea necesario.
            this.tablaDatosTableAdapter.Datos(this.libroDiarioDatos.TablaDatos);
            controlador.fechasCargadas();
            controlador.cuentasCargadas();
            controlador.cargarCombo();

        }
    }
}
