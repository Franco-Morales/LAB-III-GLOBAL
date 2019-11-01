using System;
using System.Data;
using System.Windows.Forms;
namespace Quatum.BDPlanCuentas.Consultas
{
    public partial class ConsultaPC : Form
    {

        public ConsultaPC()
        {
            InitializeComponent();
        }
        private void seleccionarTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = seleccionarTipo.SelectedIndex;
            
            DataTable dt = (DataTable)dataSet.DataSource;
            /*
             * ALEX : Tira error por null Referenc Exception, 
             * creo que habria que anidar dos try o especificar los catch.
             */
            switch (index)
            {
                case 0:
                    try
                    {
                        this.plan_cuentasTableAdapter.Activos(this.globalDataSet.plan_cuentas);
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                    break;
                case 1: 
                    break;
                case 2: 
                    break;
                case 3: 
                    break;
                case 4: 
                    break;
            }
            
        }

        private void ConsultaPC_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'globalDataSet.plan_cuentas' Puede moverla o quitarla según sea necesario.
            this.plan_cuentasTableAdapter.Fill(this.globalDataSet.plan_cuentas);

        }

        private void activosToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.plan_cuentasTableAdapter.Activos(this.globalDataSet.plan_cuentas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        //Consultas del plan de cuentas
        
    }
}
