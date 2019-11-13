using System;
using System.Windows.Forms;
using Quatum.Controlador;
using Quatum.BDPlanCuentas.Consultas;
using MySql.Data.MySqlClient;

namespace Quatum.Vista.ModalUI
{
    /// <summary>
    /// Controlador del "Modal"
    /// </summary>
    public class ModalController
    {
        int controlCheckBox;//Control para los checkbox
        int cantidadCuentas = 2;
        int cantidadCargar;//auxliar para el boton cargar cuenta
        int montoProvisorio;//auxiliar para el monto provisorio
        int id; //Id de la cuenta seleccionada a usar
        String dhProvisorio = "Debe";//auxiliar para el debe o haber provisorio
        String fechaProvisoria;//auxiliara para la fecha provisoria;
        String descripcionProvisoria;//
        Modal ventana;//Ventana Modal
        Mensaje mensaje = new Mensaje();
        public ConsultaPC consulta; //ConsultaPc

        /// <summary>
        /// Comandos mysql
        /// </summary>
        MySqlConnection conexion = new MySqlConnection("server=localhost;user id=root;database=global");
        public ModalController() { }


        public ModalController(Modal ventanaEmergente)
        {
            ventana = ventanaEmergente;
           //entana.btnEnviar.Enabled = false;
            ventana.checkBoxDebe.Checked = true;
            ventana.btnEnviar.Enabled = false;

            ventana.btnAumentar.Click += new EventHandler(btnAumentar_Click);
            ventana.btnDisminuir.Click += new EventHandler(btnDisminuir_Click);


            ventana.checkBoxDebe.Click += new EventHandler(btnDebe_checked);
            ventana.checkBoxHaber.Click += new EventHandler(btnHaber_checked);

            ventana.txtMonto.KeyPress += new KeyPressEventHandler(textMonto);
            ventana.txtSeleccionado.TextChanged += new EventHandler(cuentaProvisoria_Texto);

            ventana.btnEnviar.Click += new EventHandler(cargarCuentaProvisoria_Click);

            ventana.seleccionarCuenta.Click += new EventHandler(consultaDeCuenta_Click);

            ventana.cargarBD.Click += new EventHandler(cargarCuentaFinal_click);
        }
        /// <summary>
        /// Cargar a la base de datos en el libro diario ya finalizada, todavia no termina
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cargarCuentaFinal_click(object sender, EventArgs e)
        {
            bool equilibrado = montosEquilibrados();
            if(equilibrado == true){
            //Comando de SQL
            MySqlCommand comando = conexion.CreateCommand();
            
            for (int i = cantidadCuentas-1; i > -1; i--)
            {
                String fecha = Convert.ToString(ventana.dataGridProvisorio.Rows[i].Cells["fechaProvisoria"].Value);
                String tipoDH = Convert.ToString(ventana.dataGridProvisorio.Rows[i].Cells["tipo"].Value);
                int monto = Convert.ToInt32(ventana.dataGridProvisorio.Rows[i].Cells["saldo"].Value);
                int idFinal = Convert.ToInt32(ventana.dataGridProvisorio.Rows[i].Cells["Column2"].Value); ;
                comando.CommandText = comando.CommandText = "INSERT INTO asientos (asiento_fecha, asiento_tipo, asiento_valor, cuentas) VALUES ('" + fecha + "','" + tipoDH + "'," + monto + "," + idFinal + ")"; 
                if (i == 0) {
                    MessageBox.Show("Cuentas cargadas al libro diario y la base de datos");
                    ventana.Close();
                }
                try
                {
                    conexion.Open();
                }
                catch (Exception ex)
                {
                    string mensaje = "Error en la conexion \n Excepcion: " + ex.Message;
                    Mensaje.Mostrar(0, mensaje);
                    throw;
                }
                MySqlDataReader reader = comando.ExecuteReader();
                conexion.Close();
            }
            }else{
            MessageBox.Show("Las cuentas no estan equilibradas por favor revise los saldos");
            
            }
        }
        private void consultaDeCuenta_Click (Object sender, EventArgs e){
            consulta = new ConsultaPC(this);
            consulta.Text = "Elegir cuenta a usar";
            consulta.btnAgregar.Enabled = false;
            consulta.btnDelete.Enabled = false;
            consulta.btnMod.Enabled = false;
            consulta.cuentaSeleccionada.Visible = true;
            consulta.Show();
            consulta.cuentaSeleccionada.Click += new EventHandler(botonConsultaAceptar);
        }
        private void botonConsultaAceptar(Object sender, EventArgs e) {
            //Comando de SQL
            MySqlCommand comando = conexion.CreateCommand();
            id = int.Parse(consulta.dataSet.CurrentRow.Cells[2].Value.ToString());
            comando.CommandText = "SELECT cuentas_descripcion FROM plan_cuentas WHERE (cuentas_id = "+ id +")";
            ventana.txtSeleccionado.Text = consulta.dataSet.CurrentRow.Cells[0].Value.ToString();
            try
            {
                conexion.Open();
                Mensaje.Mostrar(2, "Cargado al libro provisorio");
            }
            catch (Exception ex)
            {
                string mensaje = "Error en la conexion \n Excepcion: " + ex.Message;
                Mensaje.Mostrar(0, mensaje);
                throw;
            }
            MySqlDataReader reader = comando.ExecuteReader();
            conexion.Close();
            consulta.Close();

        }
        /// <summary>
        /// Boton cargar cuenta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cargarCuentaProvisoria_Click(object sender, EventArgs e) {
            cantidadCargar++;
            try
            {
                montoProvisorio = int.Parse(ventana.txtMonto.Text);
            }
            catch (Exception exc)
            {
                Mensaje.Mostrar(0, "El monto no puede estar vacio \n"+exc.Message);
            }

            fechaProvisoria = ventana.dateTimePicker1.Text;
            descripcionProvisoria = ventana.txtSeleccionado.Text;
            ventana.dataGridProvisorio.Rows.Insert(0, fechaProvisoria,descripcionProvisoria,montoProvisorio,dhProvisorio,id);
            ventana.txtSeleccionado.Text = null;
            ventana.txtMonto.Text = null;
            if(ventana.dataGridProvisorio.Rows.Count == 1){
                ventana.btnDisminuir.Enabled = false;
            }
            else
            {
                ventana.btnDisminuir.Enabled = true;
            }
            if (cantidadCargar == cantidadCuentas)
            {
                Mensaje.Mostrar(2, "Todas las cuentas cargadas!");
                ventana.btnEnviar.Enabled = false;
                ventana.btnAumentar.Enabled = true;
                ventana.cargarBD.Visible = true;
            }
        }
        private void controlDescripcion() {
            int primer = 0;

                String cant2 = Convert.ToString(ventana.dataGridProvisorio.Rows[primer].Cells["Column1"].Value);
                if (cant2.Equals(Convert.ToString(ventana.dataGridProvisorio.Rows[primer+1].Cells["Column1"].Value)))
                {
                    cantidadCargar--;
                    ventana.dataGridProvisorio.Rows.RemoveAt(0);
                    MessageBox.Show("Error no se pueden repetir descripciones");
                }
                if (cantidadCargar == cantidadCuentas) {
                    for (int i = 1; i < cantidadCuentas; i++)
                    {
                        if (cant2.Equals(Convert.ToString(ventana.dataGridProvisorio.Rows[i].Cells["Column1"].Value))){ 
                            MessageBox.Show("Error no se pueden repetir descripciones");
                            cantidadCargar--;
                            ventana.dataGridProvisorio.Rows.RemoveAt(0);
                        }
                    }
                }
			}
        private void cuentaProvisoria_Texto(object sender, EventArgs e) {
            if (ventana.txtSeleccionado.Text != null)
            {
                ventana.btnEnviar.Enabled = true;
            }
            else {
                ventana.btnEnviar.Enabled = false;
            }
        
        }
        /// <summary>
        /// Boton aumentar click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAumentar_Click(object sender, EventArgs e)
        {
            cantidadCuentas++;
            ventana.btnAumentar.Enabled = false;
            ventana.cargarBD.Visible = false;
        }

        /// <summary>
        /// Boton disminuir click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDisminuir_Click(object sender, EventArgs e)
        {
            cantidadCargar--;
            int indice = Convert.ToInt32(ventana.dataGridProvisorio.CurrentRow.Selected);
            ventana.dataGridProvisorio.Rows.RemoveAt(indice);
        }
        /// <summary>
        /// Check debe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDebe_checked(object sender, EventArgs e) { 
                 if(ventana.checkBoxDebe.Checked == true){
                     ventana.checkBoxHaber.Checked = false;
                    controlCheckBox++;
                    dhProvisorio = "Debe";
                    } else {
                    ventana.checkBoxHaber.Enabled = true;
                    ventana.checkBoxHaber.Checked = true;
                    dhProvisorio = "Haber";
                    controlCheckBox--;
                }
        }
        /// <summary>
        /// Check haber
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHaber_checked(object sender, EventArgs e)
        {
            if (ventana.checkBoxHaber.Checked == true)
            {
                dhProvisorio = "Haber";
                ventana.checkBoxDebe.Checked= false;
                controlCheckBox++;
            }
            else
            {
                ventana.checkBoxDebe.Enabled = true;
                ventana.checkBoxDebe.Checked = true;
                dhProvisorio = "Debe";
                controlCheckBox--;
            }
        }

        /// <summary>
        /// Texbox de monto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textMonto(object sender, KeyPressEventArgs e) { 
        
        if(Char.IsLetter(e.KeyChar))//Al pulsar una letra
            {
                e.Handled = true; //No Se acepta (todo OK)
            }
        else if (Char.IsPunctuation(e.KeyChar)) {
            e.Handled = true; //Numeros con coma
        }
        else if (Char.IsControl(e.KeyChar)) //Al pulsar teclas como Borrar y eso.
        {
            e.Handled = false; //Se acepta (todo OK)
        }
        else if (Char.IsDigit(e.KeyChar))
        {
            e.Handled = false;
        }
        else //Para todo lo demas
        {
            e.Handled = true; //No se acepta (si pulsas cualquier otra cosa pues no se envia)
        }
 
        }
        private bool montosEquilibrados() {
            int sumaDebe = 0;
            int sumaHaber = 0;
            int cantidadDebe = 0;
            int cantidadHaber = 0;
            String debe = "Debe";
            for (int i = 0; i < ventana.dataGridProvisorio.Rows.Count; i++)
            {
                if (ventana.dataGridProvisorio.Rows[i].Cells["tipo"].Value.ToString().Equals(debe)) {
                    sumaDebe += Convert.ToInt32(ventana.dataGridProvisorio.Rows[i].Cells["saldo"].Value);
                    cantidadDebe++;
                }
                else
                {
                    sumaHaber += Convert.ToInt32(ventana.dataGridProvisorio.Rows[i].Cells["saldo"].Value);
                    cantidadHaber++;
                }
            }
            controlTipo(cantidadDebe, cantidadHaber);
                if (sumaDebe - sumaHaber != 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            
            
        }

        private void controlTipo(int debe, int haber) { 
            if(debe == 0 || haber == 0){
                MessageBox.Show("Error agrege al menos uno de cada tipo");
            }
        }
    }
}
