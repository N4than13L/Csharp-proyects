using System;
using System.Text;

namespace curso_Csharp
{
    class Program
    {
        static void Main()
        {
            int opcion, repetir = 0;
            var con = new Conversor();

            do
            {

                Console.WriteLine("elige a converir");
                Console.WriteLine("1. Convertir de m/s a km/h");
                Console.WriteLine("2.Converir km/h a m/s");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        con.conversor_1();
                        break;
                    case 2:
                        con.conversor_2();
                        break;
                }

                Console.WriteLine("si desea seguir convirtiendo presione 1");
                repetir = Convert.ToInt32(Console.ReadLine());

            } while (repetir == 1);

        }

        class Conversor
        {
            private double Speed;

            public void conversor_1()
            {
                Console.WriteLine("Introdusca una velocidad en m/s");
                Speed = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(Speed + "m/s" + Speed * 3600 / 1000 + " km/h");
            }
            public void conversor_2()
            {
                Console.WriteLine("Introdusca una velocidad en km/h");
                Speed = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(Speed + "km/h" + Speed * 1000 / 3600 + " m/s");
            }
        }
    }
}
