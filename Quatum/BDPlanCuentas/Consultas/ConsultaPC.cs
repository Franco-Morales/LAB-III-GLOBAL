﻿using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Quatum.Controlador;

namespace Quatum.BDPlanCuentas.Consultas
{
    public partial class ConsultaPC : Form
    {
        AgregarActualizar agregar;
        public ConsultaPC()
        {
            InitializeComponent();
            dataSet.MultiSelect = false;//No se permite seleccionar muchas celdas
            seleccionarTipo.SelectedIndex = 0;//Empieza el combobox en el indice 1
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
                        Mensaje.Mostrar(0, ex.Message);
                        //System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                    break;
                case 1:
                    try
                    {
                        this.plan_cuentasTableAdapter.Pasivos(this.globalDataSet.plan_cuentas);
                    }
                    catch (System.Exception ex)
                    {
                        Mensaje.Mostrar(0, ex.Message);
                        //System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                    break;
                case 2:
                    try
                    {
                        this.plan_cuentasTableAdapter.PN(this.globalDataSet.plan_cuentas);
                    }
                    catch (System.Exception ex)
                    {
                        Mensaje.Mostrar(0, ex.Message);
                        //System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                    break;
                case 3:

                    try
                    {
                        this.plan_cuentasTableAdapter.Ingresos(this.globalDataSet.plan_cuentas);
                    }
                    catch (System.Exception ex)
                    {
                        Mensaje.Mostrar(0, ex.Message);
                        //System.Windows.Forms.MessageBox.Show(ex.Message);
                    }

                    break;
                case 4:

                    try
                    {
                        this.plan_cuentasTableAdapter.Egresos1(this.globalDataSet.plan_cuentas);
                    }
                    catch (System.Exception ex)
                    {
                        Mensaje.Mostrar(0, ex.Message);
                        //System.Windows.Forms.MessageBox.Show(ex.Message);
                    }

                    break;
            }
            
        }

        private void ConsultaPC_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'globalDataSet.plan_cuentas' Puede moverla o quitarla según sea necesario.
            //this.plan_cuentasTableAdapter.Fill(this.globalDataSet.plan_cuentas);

        }
      
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            agregar = new AgregarActualizar(this);
            agregar.btnActualizar.Visible = false;
            agregar.btnActualizar.Enabled = false;
            agregar.Show();
            agregar.Text = "Agregar";
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            agregar = new AgregarActualizar(this);
            agregar.button1.Visible = false;
            agregar.button1.Enabled = false;
            agregar.Show();
            agregar.Text = "Actualizar";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("server=localhost;user id=root;database=global");
            //Comando de SQL
            MySqlCommand comando = conexion.CreateCommand();
            if (dataSet.CurrentRow != null)
            {
                //Current row es la celda seleccionada actualmente
                int id = int.Parse(dataSet.CurrentRow.Cells[2].Value.ToString());
                comando.CommandText = "DELETE FROM plan_cuentas WHERE (plan_cuentas.cuentas_id = " + id + ")";
            }
            else {
                btnDelete.Enabled = false;
            }
           try
            {
                conexion.Open();
                Mensaje.Mostrar(0, "Borrado con exito");
            }
            catch (Exception ex)
            {
                string mensaje = "Error en la conexion , excepcion:" + ex.Message;
                Mensaje.Mostrar(0,mensaje);
                throw;
            }
            MySqlDataReader reader = comando.ExecuteReader();
            conexion.Close();
        }

    }
}
