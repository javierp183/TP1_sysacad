using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_sysacad
{
    class Mensaje
    {
        public string Contenido { get; set; }
        public string Desde { get; set; }
        public string Destino { get; set; }
        DateTime FechaHora = DateTime.Now;
    }
}
