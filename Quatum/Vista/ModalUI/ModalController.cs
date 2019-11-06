using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quatum.Controlador;
namespace Quatum.Vista.ModalUI
{
    /// <summary>
    /// Controlador del "Modal"
    /// </summary>
    class ModalController
    {

        int aumentar;//auxiliar para el boton aumentar
        int disminuir;//auxiliar para el boton disminuir
        bool estado = false;//Control de que se debe mostrar o no
        Modal ventana;
        Mensaje mensaje = new Mensaje();


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
        }



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

        private void btnDebe_checked(object sender, EventArgs e) { 
                 if(ventana.checkBoxDebe.Checked == true){
                    ventana.checkBoxHaber.Enabled = false;
                    }else{
                    ventana.checkBoxHaber.Enabled = true;
                }
        }

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

        private void btnACeptar_Click(object sender, EventArgs e)
        {   //Boton aceptar
            int cantidad = int.Parse(ventana.textCantidad.Text);
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
            //ventana.btnEnviar.Enabled = false;
        }
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
        private void top(Boolean estado) {
            ventana.pblTop.Enabled = estado;
        }

        private void loadPanel(Boolean estado) {
            //Estado de los paneles
            ventana.pnlFill.Enabled = estado;
        }
       
    }
}
