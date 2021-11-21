using System;
using System.Collections.Generic;
using System.Text;

namespace Caso_2
{
    class Paciente
    {
        public int historialclinico;
        public string nombre;

        public Paciente(int historialclinico, string nombre)
        {
            this.historialclinico = historialclinico;
            this.nombre = nombre;
        }
    }
}
