using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Caso_2
{
    class Arbol
    {
        public Nodo raiz;

        public Nodo GetRaiz()
        {
            return raiz;
        }

        public void InOrder(Nodo raiz)
        {
            if (raiz != null)
            {
                InOrder(raiz.izquierdo);
                raiz.ImprimirDatos();
                InOrder(raiz.derecho);
            }
        }

        public void InsertarNodo(Paciente dato)
        {
            Nodo puntero, padre;
            Nodo nuevoNodo = new Nodo();
            nuevoNodo.dato = dato;
            if (raiz != null)
            {
                puntero = raiz;
                while (true)
                {
                    padre = puntero;
                    if (dato.historialclinico < puntero.dato.historialclinico)
                    {
                        puntero = puntero.izquierdo;
                        if (puntero == null)
                        {
                            padre.izquierdo = nuevoNodo;
                            break;
                        }
                    }
                    else
                    {
                        puntero = puntero.derecho;
                        if (puntero == null)
                        {
                            padre.derecho = nuevoNodo;
                            break;
                        }
                    }
                }
            }
            else
            {
                raiz = nuevoNodo;
            }
        }

        public void BuscarHistorial(int hc)
        {
            int contador = 0;
            Nodo puntero = raiz;
            while (puntero != null)
            {
                contador += 1;
                if (puntero.dato.historialclinico == hc)
                {
                    Console.WriteLine("Historia clínica {0} ", puntero.dato.historialclinico);
                    Console.WriteLine("Nombre: {0} ", puntero.dato.nombre);
                    Console.WriteLine("Iteraciones: " + contador);
                    return;
                }
                else
                {
                    if (hc > puntero.dato.historialclinico) puntero = puntero.derecho;
                    else puntero = puntero.izquierdo;
                }
            }
            Console.WriteLine("Historia clínica no encontrada");
            Console.WriteLine("Iteraciones realizadas:" + contador);
        }
    }
}
