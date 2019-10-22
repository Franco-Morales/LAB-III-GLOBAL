using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quatum.GUI;

namespace Quatum.Controlador
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
