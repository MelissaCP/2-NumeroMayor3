using System;
using C = System.Console;


namespace _2_NumeroMayor3
{
    class Program
    {
        /// Practica 1
        /// 2.- Encontrar el mayor de tres números.

        /// Chávez Pérez Melissa
        /// #M21210035
        static void Main(string[] args)
        {
            C.BackgroundColor = ConsoleColor.Blue;
            C.ForegroundColor = ConsoleColor.White;

            //Variables
            string va;
            int num1, num2, num3;

            C.WriteLine("\nFavor de ingresar el primer numero ");
            va = C.ReadLine();
            num1 = int.Parse(va);

            C.WriteLine("\nFavor de ingresar el segundo numero ");
            va = C.ReadLine();
            num2 = int.Parse(va);

            C.WriteLine("\nFavor de ingresar el tercer numero ");
            va = C.ReadLine();
            num3 = int.Parse(va);

            //Numero 1 Es mayor que todos. 
            if (num1 < num2)
            {
                if (num2 < num3)
                {
                    C.WriteLine("{0} es mayor", +num3);

                }
                else
                    C.WriteLine("{0} es mayor", +num2);
            }

            else if (num1 > num2)
            {
                if (num1 < num3)
                {
                    C.WriteLine("{0} es mayor", +num3);

                }
                else
                    C.WriteLine("{0} es mayor", +num1);
            }

            Console.ReadKey();
        }
    }
}
