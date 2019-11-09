using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quatum.Controlador;
using Quatum.BDPlanCuentas.Consultas;
using Quatum.Vista.LibroDiarioUI;
using MySql.Data.MySqlClient;

namespace Quatum.Vista.ModalUI
{
    /// <summary>
    /// Controlador del "Modal"
    /// </summary>
    public class ModalController
    {
        int controlCheckBox;//Control para los checkbox
        int aumentar;//auxiliar para el boton aumentar
        int disminuir;//auxiliar para el boton disminuir
        int cantidadCuentas;
        int cantidadCargar;//auxliar para el boton cargar cuenta
        int montoProvisorio;//auxiliar para el monto provisorio
        int id; //Id de la cuenta seleccionada a usar
        String dhProvisorio = "Debe";//auxiliar para el debe o haber provisorio
        String fechaProvisoria;//auxiliara para la fecha provisoria;
        String descripcionProvisoria;//
        bool estado = false;//Control de que se debe mostrar o no
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
            loadPanel(estado);
            ventana.btnAumentar.Click += new EventHandler(btnAumentar_Click);
            ventana.btnDisminuir.Click += new EventHandler(btnDisminuir_Click);
            ventana.btnAceptar.Click += new EventHandler(btnACeptar_Click);
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
                MessageBox.Show("Cargado al libro provisorio");
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
            cantidadCuentas = int.Parse(ventana.textCantidad.Text);
            cantidadCargar++;
            if (cantidadCargar == cantidadCuentas)
            {
                MessageBox.Show("Todas las cuentas cargadas!");
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
            descripcionProvisoria = ventana.txtSeleccionado.Text;
            ventana.dataGridProvisorio.Rows.Insert(0, fechaProvisoria,descripcionProvisoria,montoProvisorio,dhProvisorio,id);
            if (cantidadCuentas >= 3 ) {
                if (cantidadCargar == cantidadCuentas-1)
	                    {
                            controlDeCuentas();
	                    }
            }
            ventana.txtSeleccionado.Text = null;
            ventana.btnEnviar.Enabled = false;
        }
        private void controlDeCuentas(){
            int cantidadDebe = 0;
            int cantidadHaber = 0;
            int sumaDebe = 0;
            int saldo = 0;
            int sumaHaber = 0;
            for (int i = 0; i < cantidadCargar; i++)
            {
                String cant  = Convert.ToString(ventana.dataGridProvisorio.Rows[i].Cells["tipo"].Value);
                saldo += Convert.ToInt32(ventana.dataGridProvisorio.Rows[i].Cells["saldo"].Value);
                if (cant.Equals("Debe"))
                {
                    cantidadDebe++;
                }
                else {
                    cantidadHaber++;
                }
            }
            for (int j = 0; j < cantidadCargar; j++)
            {
                if( Convert.ToString(ventana.dataGridProvisorio.Rows[j].Cells["tipo"].Value).Equals("Debe")){
                    sumaDebe += Convert.ToInt32(ventana.dataGridProvisorio.Rows[j].Cells["saldo"].Value);
                }
                else
                {
                    sumaHaber += Convert.ToInt32(ventana.dataGridProvisorio.Rows[j].Cells["saldo"].Value);
                }
                
            }

            ventana.checkBoxHaber.Enabled = false;
            ventana.checkBoxHaber.Checked = false;
            ventana.checkBoxDebe.Checked = true;
            ventana.checkBoxDebe.Enabled = false;
            ventana.txtMonto.Enabled = false;
            if (cantidadDebe > cantidadHaber) {
                dhProvisorio = "Haber";

                ventana.txtMonto.Text = Convert.ToString(sumaDebe-sumaHaber);
            }
            else if (cantidadHaber > cantidadDebe)
            {
                dhProvisorio = "Debe";
                ventana.txtMonto.Text = Convert.ToString(sumaHaber - sumaDebe);
            }else{
                if(sumaHaber > sumaDebe){
                    ventana.checkBoxHaber.Checked = false;
                    ventana.checkBoxHaber.Enabled = false;
                    ventana.checkBoxDebe.Checked = true;
                    dhProvisorio = "Debe";
                    ventana.txtMonto.Text = Convert.ToString(sumaHaber - sumaDebe);
                }
                else if (sumaDebe == sumaHaber){
                    MessageBox.Show("Error son iguales cambie el monto a un numero mayor o menor o seleccione el mismo tipo");
                    cantidadCargar--;
                    ventana.checkBoxDebe.Enabled = true;
                    ventana.checkBoxHaber.Enabled = true;
                    ventana.txtMonto.Enabled = true;
                    ventana.txtMonto.Text = "null";
                    ventana.dataGridProvisorio.Rows.RemoveAt(0);
                }
                else
                {
                    ventana.checkBoxDebe.Checked = false;
                    ventana.checkBoxHaber.Checked = true;
                    ventana.checkBoxDebe.Enabled = false;
                    dhProvisorio = "Haber";
                    ventana.txtMonto.Text = Convert.ToString(sumaDebe - sumaHaber);
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
            aumentar = int.Parse(ventana.textCantidad.Text);
            //SELECT cuentas_id, cuentas_descripcion, cuenta_tipo plan_cuentas (cuentas_id = 2)
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
                     ventana.checkBoxHaber.Checked = false;
                    controlCheckBox++;
                    dhProvisorio = "Debe";
                    }else
                 {
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
