using System;

namespace Caso_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Arbol ainicio = new Arbol();
            Arbol afinal = new Arbol();

            ainicio.InsertarNodo(new Paciente(5, "Paciente 5"));
            ainicio.InsertarNodo(new Paciente(1, "Paciente 1"));
            ainicio.InsertarNodo(new Paciente(6, "Paciente 6"));
            ainicio.InsertarNodo(new Paciente(10, "Paciente 10"));
            ainicio.InsertarNodo(new Paciente(11, "Paciente 11"));
            ainicio.InsertarNodo(new Paciente(15, "Paciente 15"));

            Console.WriteLine("Registro de Historial Clínico Inicial\n");

            Console.WriteLine("Ordenamiento Inorder\n");
            ainicio.InOrder(ainicio.GetRaiz());
    
            ainicio.BuscarHistorial(15);
            Console.WriteLine();

            afinal.InsertarNodo(new Paciente(6, "Paciente 6"));
            afinal.InsertarNodo(new Paciente(5, "Paciente 5"));
            afinal.InsertarNodo(new Paciente(1, "Paciente 1"));
            afinal.InsertarNodo(new Paciente(11, "Paciente 11"));
            afinal.InsertarNodo(new Paciente(10, "Paciente 10"));
            afinal.InsertarNodo(new Paciente(15, "Paciente 15"));

            Console.WriteLine("Registro de Historial Clínico Eficiente\n");

            Console.WriteLine("Ordenamiento Inorder\n");
            afinal.InOrder(afinal.GetRaiz());

            afinal.BuscarHistorial(15);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
