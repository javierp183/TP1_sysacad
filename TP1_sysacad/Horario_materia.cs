using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_sysacad
{
    class Horario_materia
    {
        Materia materia = new Materia();
        Docente docente = new Docente();
        public string Sede { get; set; }
        public string Horario { get; set; }
        Ayudante ayudante = new Ayudante();
    }
}
