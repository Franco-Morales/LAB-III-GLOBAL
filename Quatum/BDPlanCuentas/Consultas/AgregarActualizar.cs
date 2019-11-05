using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Quatum.Controlador;

namespace Quatum.BDPlanCuentas.Consultas
{
    public partial class AgregarActualizar : Form
    {
        String tipoCMB;
        String descripcionCMB;
        ConsultaPC nuevo;
        public AgregarActualizar(ConsultaPC consulta)
        {
            InitializeComponent();
            tipo.SelectedIndex = 0;
            button1.Enabled = false;
            btnActualizar.Enabled = false;
            nuevo = consulta;
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
                btnActualizar.Enabled = true;
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
            }
            catch (Exception ex)
            {
                string mensaje = "Error en la conexion \n Excepcion: "+ex.Message;
                Mensaje.Mostrar(0, mensaje);
                throw;
            }
            MySqlDataReader reader = comando.ExecuteReader();
            conexion.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            descripcionCMB = textBox1.Text;
            MySqlConnection conexion = new MySqlConnection("server=localhost;user id=root;database=global");
            //Comando de SQL
            MySqlCommand comando = conexion.CreateCommand();
            
            if (nuevo.dataSet.CurrentRow != null)
            {
                //Current row es la celda seleccionada actualmente
                int id = int.Parse(nuevo.dataSet.CurrentRow.Cells[2].Value.ToString());
                comando.CommandText =
                "UPDATE plan_cuentas SET cuentas_descripcion = '" + descripcionCMB + "', cuenta_tipo = '" + tipoCMB + "' WHERE (plan_cuentas.cuentas_id = " + id + ")";

                nuevo.btnMod.Enabled = true;
            }
            try
            {
                conexion.Open();
                Mensaje.Mostrar(2, "Actualizado correctamente");
            }
            catch (Exception ex)
            {
                string mensaje = "Error en la conexion , excepcion:" + ex.Message;
                Mensaje.Mostrar(0, mensaje);
                throw;
            }
            MySqlDataReader reader = comando.ExecuteReader();
            conexion.Close();
        }
    }
}
