using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quatum.Controlador
{
    /// <summary>
    /// Clase auxiliar para administrar los mensajes mostrados a los usuario
    /// El codigo representa el tipo de mensaje
    /// </summary>
    class Mensaje
    {
        /// <summary>
        /// Mostrará un mensaje por pantalla mediante la clase MessageBox
        /// </summary>
        /// <param name="codigo">0 : Error; 1 : Advertencia; 2 : Información; 3 : Consulta;x : Mensaje no especificado</param>
        /// <param name="mensaje"></param>
        public static void Mostrar(Byte codigo,string mensaje)
        {
            
            switch (codigo)
            {
                case 0:
                    MessageBox.Show(mensaje, "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    break;
                case 1:
                    MessageBox.Show(mensaje, "Adevertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 2:
                    MessageBox.Show(mensaje, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 3:
                    MessageBox.Show(mensaje, "Pregunta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    break;
                default:

                    break;
            }
        }


        /// <summary>
        /// Mostrará un mensaje por pantalla mediante la clase MessageBox, devuelve el valor seleccionado por el usuario
        /// </summary>
        /// <param name="codigo">0 : Error; 1 : Advertencia; 2 : Información; 3 : Consulta;x : Mensaje no especificado</param>
        /// <param name="mensaje">Dialogo a mostrar</param>
        /// <returns></returns>
        public static DialogResult respuesta(Byte codigo,string mensaje)
        {
            DialogResult respuesta = DialogResult.Ignore;
            switch (codigo)
            {
                case 0:
                    respuesta = MessageBox.Show(mensaje, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    return respuesta;
                    break;
                case 1:
                    respuesta = MessageBox.Show(mensaje, "Adevertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    return respuesta;
                    break;
                case 2:
                    respuesta = MessageBox.Show(mensaje, "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    return respuesta;
                    break;
                case 3:
                    respuesta = MessageBox.Show(mensaje, "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    return respuesta;
                    break;
                default:
                    break;
            }
            return respuesta;
        }
    }
}
