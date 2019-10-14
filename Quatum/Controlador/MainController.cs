using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quatum.GUI;

namespace Quatum.Controlador
{
    /// <summary>
    /// Controlador principal
    /// </summary>
    class MainController
    {
        MenuPrincipal vistaMenu;


        public MainController() { }

        public MainController(MenuPrincipal menu)
        {
            vistaMenu = menu;

            vistaMenu.btnCLOSE.Click += new EventHandler(cerrar);
            vistaMenu.btnMIN.Click += new EventHandler(minimizar);
            vistaMenu.btnMAX.Click += new EventHandler(maximizar);
            vistaMenu.btnRESTORE.Click += new EventHandler(restaurar);

            vistaMenu.Exit.Click += new EventHandler(cerrar);
            vistaMenu.LD.Click += new EventHandler(libroDiarioOpen);
            
        }


        #region Gestión de EVENTOS

        private void cerrar(Object sender,EventArgs e)
        {
            Application.Exit();
        }

        private void maximizar(Object sender, EventArgs e)
        {
            vistaMenu.WindowState = FormWindowState.Maximized;
            vistaMenu.btnMAX.Visible = false;
            vistaMenu.btnRESTORE.Visible = true;
        }

        private void minimizar(Object sender, EventArgs e)
        {
            vistaMenu.WindowState = FormWindowState.Minimized;
        }

        private void restaurar(Object sender, EventArgs e)
        {
            vistaMenu.WindowState = FormWindowState.Normal;
            vistaMenu.btnMAX.Visible = true;
            vistaMenu.btnRESTORE.Visible = false;
        }
        #endregion

        #region Libro Diario : Eventos

        public void libroDiarioOpen(Object sender,EventArgs e)
        {
            try
            {
                    LibroDiario lbVista = new LibroDiario();
                    lbVista.MdiParent = vistaMenu;
                    lbVista.Dock = DockStyle.Fill;
                    lbVista.Show();
            }
            catch (Exception exc)
            {
                string mensaje = "Error al abrir el libro diario \nWindows dice :"+ exc.Message;
                MessageBox.Show(mensaje,"Libro Diario : Show : Error",MessageBoxButtons.OK,MessageBoxIcon.Error);   
            }
            
        }

        #endregion


    }
}
