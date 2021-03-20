using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var Aritmetica = new Aritmetica_basica();

            Console.WriteLine("bienvenido a calculaor ");
            Console.WriteLine("para mas ayuda escriba ayuda");

            float a = float.Parse(Console.ReadLine());
            string operador = Console.ReadLine();
            float b = float.Parse(Console.ReadLine());


            if (a >= 0 && b >= 0)
            {
                if (operador == "+")
                {
                    Console.WriteLine(Aritmetica.suma(a, b));

                }
                else if (operador == "-")
                {
                    Console.WriteLine(Aritmetica.resta(a, b));
                }
                else if (operador == "*")
                {
                    Console.WriteLine(Aritmetica.multiplicacion(a, b));
                }
                else if (operador == "/")
                {
                    Console.WriteLine(Aritmetica.dividir(a, b));
                }
                else
                {
                    Console.WriteLine("necesita ayuda");
                    String ayuda = Console.ReadLine();

                    if (ayuda == "si")
                    {
                        Console.WriteLine("1.Escriba el primer valor \n" +
                            " 2. Escribe un oparador ya sea el de: + - * / \n" +
                            " 3. esciba un tercer valor y pulse enter");
                    }

                }

                Console.ReadKey();
                Console.ReadLine();

            }
        }
    }
}
