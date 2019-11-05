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
            /*TextBox txt = new TextBox();
            txt.Text = cantidad.ToString();
            ventana.panelDescripcion.Controls.Add(txt);*/
        }

        private void top(Boolean estado) {
            ventana.pblTop.Enabled = estado;
            /*
            ventana.btnAumentar.Enabled = estado;
            ventana.btnDisminuir.Enabled = estado;
            ventana.btnAumentar.Visible = estado;
            ventana.btnDisminuir.Visible = estado;
            ventana.textCantidad.Visible = estado;
            ventana.label1.Visible = estado;
            ventana.btnAceptar.Visible = estado;
            */
        }

        private void loadPanel(Boolean estado) {
            //Estado de los paneles
            ventana.pnlFill.Enabled = estado;
        }
       
    }
}
