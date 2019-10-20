using System;
using System.Data;
using System.Data.SqlServerCe;
using System.Windows.Forms;
namespace Quatum.BDPlanCuentas.Consultas
{
    public partial class ConsultaPC : Form
    {

        SqlCeDataAdapter adaptador;
        SqlCeCommand sqlselect;
        SqlCeConnection conexion;
        DataSet dataset1;
        public ConsultaPC()
        {
            InitializeComponent();
            adaptador = new SqlCeDataAdapter();
            sqlselect = new SqlCeCommand();
            conexion = new SqlCeConnection();
            dataset1 = new DataSet();
            //Establecer la conexion
            conexion.ConnectionString = BDConectar.Conectar();
        }
        
        private void seleccionarTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            adaptador.SelectCommand = sqlselect;
            sqlselect.Connection = conexion;
            int index = seleccionarTipo.SelectedIndex;
            
            DataTable dt = (DataTable)rejilla.DataSource;
            /*
             * ALEX : Tira error por null Referenc Exception, 
             * creo que habria que anidar dos try o especificar los catch.
             */
            switch (index)
            {
                case 0: sqlselect.CommandText = "SELECT tipo,[descripcion] FROM [Plan-De-Cuentas] WHERE (tipo = N'Activo')";
                    break;
                case 1: sqlselect.CommandText = "SELECT tipo,[descripcion] FROM [Plan-De-Cuentas] WHERE (tipo = N'Pasivo')";
                    dt.Clear();
                    break;
                case 2: sqlselect.CommandText = "SELECT tipo,[descripcion] FROM [Plan-De-Cuentas] WHERE (tipo = N'Patrimonio Neto')";
                    dt.Clear();
                    break;
                case 3: sqlselect.CommandText = "SELECT tipo,[descripcion] FROM [Plan-De-Cuentas] WHERE (tipo = N'Ingreso')";
                    dt.Clear();
                    break;
                case 4: sqlselect.CommandText = "SELECT tipo,[descripcion] FROM [Plan-De-Cuentas] WHERE (tipo = N'Egreso')";
                    dt.Clear();
                    break;
            }
            try
            {
                conexion.Open();

            }
            catch (SqlCeException ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            adaptador.Fill(dataset1, "[Plan-De-Cuentas]");
            //cerrar conexion
            conexion.Close();
            rejilla.DataSource = dataset1.Tables["[Plan-De-Cuentas]"];

            rejilla.Columns["tipo"].HeaderText = "Tipo";

            rejilla.Columns[0].HeaderText = "Descripcion";
            
        }
        //Consultas del plan de cuentas
        
    }
}
