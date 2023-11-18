using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace COM_DCOM
{
    internal class SERVIDOR
    {
        [ComVisible(true)]
        public class Servidor
        {
            [ComVisible(true)]
            public string ObtenerSaludo(string n)
            {
                return $"hi, {n}!";
            }
        }
    }
}
