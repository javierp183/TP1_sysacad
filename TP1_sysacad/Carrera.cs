using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_sysacad
{
    class Carrera
    {
        public string Nombre { get; set; }
        public string Sede { get; set; }
        public string Id { get; set; }
        Docente docente = new Docente();
        Materia materia = new Materia();
    }
}
