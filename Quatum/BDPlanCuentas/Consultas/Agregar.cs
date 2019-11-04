using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Quatum.BDPlanCuentas.Consultas
{
    public partial class Agregar : Form
    {
        String tipoCMB;
        String descripcionCMB;
        public Agregar()
        {
            InitializeComponent();
            tipo.SelectedIndex = 0;
            button1.Enabled = false;
        }

        private void tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Indice del combo box del boton agregar
            int indice = tipo.SelectedIndex;
            switch (indice)
            {
                case 0: tipoCMB = "Activo";
                    break;
                case 1:
                        tipoCMB = "Pasivo";
                    break;
                case 2:
                        tipoCMB = "Egreso";
                    break;
                case 3:
                        tipoCMB = "Ingreso";
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != null) {
                button1.Enabled = true;
                
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            button1.Enabled = false;
            if(char.IsControl(e.KeyChar)){
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            descripcionCMB = textBox1.Text;
            //Crea la conexion
            MySqlConnection conexion = new MySqlConnection("server=localhost;user id=root;database=global");
            //Comando de SQL
            MySqlCommand comando = conexion.CreateCommand();
            comando.CommandText = "INSERT INTO plan_cuentas (cuentas_descripcion, cuenta_tipo) VALUES ('" + descripcionCMB + "','" + tipoCMB + "')";
            try
            {

                conexion.Open();
                this.Close();
                MessageBox.Show("Creado con exito");
                ConsultaPC nuevo = new ConsultaPC();
                nuevo.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la conexion , excepcion:" + ex.Message + MessageBoxIcon.Error);
                throw;
            }
            MySqlDataReader reader = comando.ExecuteReader();
            conexion.Close();
        }
    }
}
