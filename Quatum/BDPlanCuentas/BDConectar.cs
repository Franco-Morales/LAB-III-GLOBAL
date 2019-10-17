using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quatum.Properties;
namespace Quatum.BDPlanCuentas
{
    class BDConectar
    {
        //Metodo para conectar la base de datos 
        public static string Conectar() {

            return Settings.Default.Database1ConnectionString;
        }
    }
}
