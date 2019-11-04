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
            //Indice del comboBox 
            int index = seleccionarTipo.SelectedIndex;
            
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
                    try
                    {
                        this.plan_cuentasTableAdapter.Pasivos(this.globalDataSet.plan_cuentas);
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                    break;
                case 2:
                    try
                    {
                        this.plan_cuentasTableAdapter.PN(this.globalDataSet.plan_cuentas);
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                    break;
                case 3:

                    try
                    {
                        this.plan_cuentasTableAdapter.Ingresos(this.globalDataSet.plan_cuentas);
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }

                    break;
                case 4:

                    try
                    {
                        this.plan_cuentasTableAdapter.Egresos1(this.globalDataSet.plan_cuentas);
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }

                    break;
            }
            
        }

        private void ConsultaPC_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'globalDataSet.plan_cuentas' Puede moverla o quitarla según sea necesario.
            //this.plan_cuentasTableAdapter.Fill(this.globalDataSet.plan_cuentas);

        }
        Agregar agregar;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            agregar = new Agregar();

            agregar.Show();
        }

    }
}
