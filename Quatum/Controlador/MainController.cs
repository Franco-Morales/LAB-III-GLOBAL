using System;
using System.Windows.Forms;
using Quatum.Vista.MenuPrincipalUI;
using Quatum.Vista.LibroDiarioUI;
using Quatum.BDPlanCuentas.Consultas;

namespace Quatum.Controlador
{
    /// <summary>
    /// Controlador principal
    /// </summary>
    class MainController
    {
        private MenuPrincipal vistaMenu;


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
            vistaMenu.PlanCuenta.Click += new EventHandler(PlanCuentaOpen);
            vistaMenu.help.Click += new EventHandler(ayuda);

        }


        #region Gestión de EVENTOS

        private void cerrar(Object sender, EventArgs e)
        {
            if(Mensaje.respuesta(1,"¿Está seguro que desea salir?") == DialogResult.Yes)
            {
                Application.Exit();
            }
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

        private void ayuda(Object sender, EventArgs e)
        {
            Mensaje.Mostrar(2,"Acción no disponible");
        }

        private void Excel(Object sender, EventArgs e)
        {
            Mensaje.Mostrar(2, "Acción no disponible");
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
            catch (Exception)
            {
                Mensaje.Mostrar(0, "Error al abrir el libro diario");  
            }
            
        }

        #endregion

        #region Plan de Cuenta : Eventos

        public void PlanCuentaOpen(Object sender,EventArgs e)
        {
            try {
                ConsultaPC pcVista = new ConsultaPC();
                pcVista.Show();
            }
            catch (Exception)
            { 
                Mensaje.Mostrar(0, "Error al abrir el plan de cuentas");
            }
        }

        #endregion


    }
}
