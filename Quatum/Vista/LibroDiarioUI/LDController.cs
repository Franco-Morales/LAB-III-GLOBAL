using System;
using Quatum.Vista.ModalUI;

namespace Quatum.Vista.LibroDiarioUI
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

        private void cerrar(object sender, EventArgs e)
        {
            vistaPrincipal.Close();
        }

        private void Agregar(object sender, EventArgs e)
        {
            Modal ventanaEmergente = new Modal();
            ventanaEmergente.ShowDialog();
        }
        #endregion
    }
}
