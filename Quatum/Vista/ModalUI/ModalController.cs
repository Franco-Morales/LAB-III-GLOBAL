using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quatum.Controlador;
using Quatum.BDPlanCuentas.Consultas;
using MySql.Data.MySqlClient;

namespace Quatum.Vista.ModalUI
{
    /// <summary>
    /// Controlador del "Modal"
    /// </summary>
    class ModalController
    {

        int aumentar;//auxiliar para el boton aumentar
        int disminuir;//auxiliar para el boton disminuir
        int cantidadCargar;//auxliar para el boton cargar cuenta
        int montoProvisorio;//auxiliar para el monto provisorio
        String dhProvisorio;//auxiliar para el debe o haber provisorio
        String fechaProvisoria;//auxiliara para la fecha provisoria;
        bool estado = false;//Control de que se debe mostrar o no
        Modal ventana;
        Mensaje mensaje = new Mensaje();
        ConsultaPC consulta;

        public ModalController() { }


        public ModalController(Modal ventanaEmergente)
        {
            ventana = ventanaEmergente;
            loadPanel(estado);
            ventana.btnAumentar.Click += new EventHandler(btnAumentar_Click);
            ventana.btnDisminuir.Click += new EventHandler(btnDisminuir_Click);
            ventana.btnAceptar.Click += new EventHandler(btnACeptar_Click);
            ventana.checkBoxDebe.Click += new EventHandler(btnDebe_checked);
            ventana.checkBoxHaber.Click += new EventHandler(btnHaber_checked);
            ventana.txtMonto.KeyPress += new KeyPressEventHandler(textMonto);
            ventana.btnEnviar.Click += new EventHandler(cargarCuentaProvisoria_Click);
            ventana.seleccionarCuenta.Click += new EventHandler(consultaDeCuenta_Click);
            //ventana.cargarBD.Click += new EventHandler(cargarCuentaFinal_click);
        }
        /// <summary>
        /// Cargar a la base de datos en el libro diario ya finalizada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cargarCuentaFinal_click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("server=localhost;user id=root;database=global");
            //Comando de SQL
            MySqlCommand comando = conexion.CreateCommand();
            String fecha = "asd";
            String Debe = "Debe";
            comando.CommandText = "INSERT INTO asientos" +
                "(asiento_fecha, asiento_tipo, asiento_valor, cuentas, asiento_referencia)" +
            "VALUES '" + fecha + "','" + Debe + "'," + 500 + "," + 7 + "," + 2 + ")";
            try
            {
                conexion.Open();
                MessageBox.Show("Cargado al libro diario");
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
        private void consultaDeCuenta_Click (Object sender, EventArgs e){
            consulta = new ConsultaPC();
            consulta.Show();
            consulta.Text = "Elegir cuenta a usar";
            consulta.btnAgregar.Enabled = false;
            consulta.btnDelete.Enabled = false;
            consulta.btnMod.Enabled = false;
        
        }
        /// <summary>
        /// Boton cargar cuenta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cargarCuentaProvisoria_Click(object sender, EventArgs e) {
            int cantidadCuentas = int.Parse(ventana.textCantidad.Text);
            cantidadCargar++;
            if (cantidadCargar == cantidadCuentas)
            {
                MessageBox.Show("Listo!");
                ventana.btnEnviar.Enabled = false;
                ventana.cargarBD.Visible = true;
            }
            if (cantidadCuentas == 2) { 
            switch (cantidadCargar)
                {
                case 1: dhProvisorio = "Debe"; ventana.txtMonto.ReadOnly = true; break;
                case 2: dhProvisorio = "Haber"; break;
                }
            }
            fechaProvisoria = ventana.dateTimePicker1.Text;
            montoProvisorio = int.Parse(ventana.txtMonto.Text);
            ventana.dataGridProvisorio.Rows.Insert(0, fechaProvisoria, "Descripcion", montoProvisorio, dhProvisorio);
        }
        /// <summary>
        /// Boton aumentar click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAumentar_Click(object sender, EventArgs e)
        {
            aumentar = int.Parse(ventana.textCantidad.Text);
            aumentar++;
            ventana.textCantidad.Text = aumentar.ToString();
            ventana.btnDisminuir.Enabled = true;
            if (aumentar == 5)
            {
                ventana.btnAumentar.Enabled = false;
                Mensaje.Mostrar(0, "El máximo de cuentas permitidos es 5");
            }
        }

        /// <summary>
        /// Boton disminuir click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDisminuir_Click(object sender, EventArgs e)
        {
            disminuir = int.Parse(ventana.textCantidad.Text);
            disminuir--;

            ventana.textCantidad.Text = disminuir.ToString();
            ventana.btnAumentar.Enabled = true;

            if (disminuir == 2)
            {
                ventana.btnDisminuir.Enabled = false;
                Mensaje.Mostrar(0, "El mínimo de cuentas permitidos es 2");

            }
        }
        /// <summary>
        /// Check debe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDebe_checked(object sender, EventArgs e) { 
                 if(ventana.checkBoxDebe.Checked == true){

                    ventana.checkBoxHaber.Enabled = false;

                    }else
                 {
                    ventana.checkBoxHaber.Enabled = true;
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
                ventana.checkBoxDebe.Enabled = false;
            }
            else
            {
                ventana.checkBoxDebe.Enabled = true;
            }
        }
        /// <summary>
        /// Boton aceptar la cantidad de cuentas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnACeptar_Click(object sender, EventArgs e)
        {   //Boton aceptar
            top(estado);
            estado = true;
            loadPanel(estado);
            int minimo = int.Parse(ventana.textCantidad.Text);
            if (minimo != 2)
            {
                ventana.checkBoxDebe.Enabled = true;
                ventana.checkBoxHaber.Enabled = true;
            }
            else
            {
                ventana.checkBoxDebe.Enabled = false;
                ventana.checkBoxHaber.Enabled = false;
            }
            //ventana.btnEnviar.Visible = false;


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
        /// <summary>
        /// Estado de las ventanas
        /// </summary>
        /// <param name="estado"></param>
        private void top(Boolean estado) {
            ventana.pblTop.Enabled = estado;
        }
        /// <summary>
        /// Estado de los paneles
        /// </summary>
        /// <param name="estado"></param>
        private void loadPanel(Boolean estado) {
            //Estado de los paneles
            ventana.pnlFill.Enabled = estado;
        }
       
    }
}
