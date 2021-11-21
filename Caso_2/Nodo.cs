using System;
using System.Collections.Generic;
using System.Text;

namespace Caso_2
{
    class Nodo
    {
        public Paciente dato;
        public Nodo izquierdo;
        public Nodo derecho;

        public void ImprimirDatos()
        {
            Console.WriteLine("Historia clínica: {0}, Nombre: {1}", dato.historialclinico, dato.nombre);
        }
    }
}
