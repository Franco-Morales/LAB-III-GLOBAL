

namespace Quatum.Vista.ModalUI
{
    /// <summary>
    /// Controlador del "modal"
    /// </summary>
    class ModalController
    {
        Modal ventana;
        public ModalController() { }

        public ModalController(Modal ventanaEmergente)
        {
            ventana = ventanaEmergente;
        }
    }
}
