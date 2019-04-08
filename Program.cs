using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculadora00
{
    class Program
    {
        public enum Operacion {suma, resta, multiplicacion, division}
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Escriba el primer número");
            int numeroprimero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriba el segundo número");
            int numerosegundo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Operacion a realizar:");
            string Operacion = Console.ReadLine();

            Console.WriteLine("El resultado es");
            switch (Operacion)
            {
                        case "suma":
                                Console.WriteLine(numeroprimero + numerosegundo);
                        break;

                        case "resta":
                                Console.WriteLine(numeroprimero - numerosegundo);
                        break;

                        case "multiplicacion":
                                Console.WriteLine(numeroprimero * numerosegundo);
                        break;

                        case "division":
                                Console.WriteLine(numeroprimero / numerosegundo);
                        break;

                        default :Console.WriteLine("No reconocido"); break;

            }
            Console.ReadKey();

        }

    }
}
