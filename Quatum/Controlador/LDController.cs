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
    /// Controlador del Libro Diario
    /// </summary>
    class LDController
    {
        LibroDiario vistaPrincipal;

        public LDController() { }

        public LDController(LibroDiario libroDiarioVista)
        {
            vistaPrincipal = libroDiarioVista;

            vistaPrincipal.btnCLOSE.Click += new EventHandler(cerrar);
            vistaPrincipal.btnAdd.Click += new EventHandler(Agregar);

        }

        #region Gestión de EVENTOS

        private void cerrar(Object sender, EventArgs e)
        {
            vistaPrincipal.Close();
        }

        private void Agregar(Object sender,EventArgs e)
        {
            Modal ventanaEmergente = new Modal();
            ventanaEmergente.ShowDialog();
        }
        #endregion
    }
}
