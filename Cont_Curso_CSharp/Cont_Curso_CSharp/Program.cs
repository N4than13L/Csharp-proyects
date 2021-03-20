using System;
using System.Collections.Generic;
using System.Text;

namespace Cont_Curso_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var Lista = new Lisa_Nodo();

            Console.WriteLine("buevenidos al programa de los nodos \n" +
                "para obtener ayuda pulse y");

            string Instruccion = Console.ReadLine();

            switch (Instruccion)
            {
                case "mostrar nodos":
                    Lista.Listar();
                    break;

                case "insertar":
                    Console.WriteLine("Inserta un valor para agragar un nodo");
                    String Veces = Console.ReadLine();

                    while(Veces != "")
                    {
                        Console.WriteLine("Inserte un valor: \n ");
                        int nodos = int.Parse(Console.ReadLine());

                        int limite = int.Parse(Console.ReadLine());

                        if (nodos >= 0)
                        {
                            Lista.addNodo(nodos);
                            Lista.Listar();
                            
                        } 
                       
                    }

                    break;

                case "Eliminar 1":
                    Lista.Borrar_primero();
                    Lista.Listar();
                    break;

                case "y":
                    Console.WriteLine("escriba: mostrar, insertar, eliminar1,"
                        + " ");

                    break;

                case "sustituir nodo":
                    int valor_a = int.Parse(Console.ReadLine());
                    int valor_b = int.Parse(Console.ReadLine());

                    if(valor_a != 0 && valor_b != 0)
                    {
                        Lista.Sustituir(valor_a, valor_b);
                        Lista.Listar();
                    }

                    break;

                case "size":
                    Lista.Size();
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }

            Console.ReadLine();
        }
    }
}
