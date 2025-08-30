using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!, Escribe un numero entero...");
            //{
            //    const int NUM1 = 10;
            //    string entrada1 = Console.ReadLine();
            //    int num1;
            //    if (int.TryParse(entrada1, out num1))
            //    {
            //        Console.WriteLine("El numero ingresado es: " + num1 + " Escriba otro numero (puede ser decimal)..");
            //    }
            //    else {
            //        Console.WriteLine("La entrada no es un numero valido");
            //    }
            //    string entrada2 = Console.ReadLine();
            //    double num2;
            //    if(double.TryParse(entrada2, out num2))
            //    {
            //        double resultado;
            //        resultado = num2 + num1;
            //        Console.WriteLine("El resultado de la suma es: " + resultado + " Y numero fijo es: " + NUM1);
            //    }
            //    else
            //    {
            //        Console.WriteLine("La entrada no es un numero valido");
            //    }
            //}
            const int TOPE = 10;
            int pequeño ;
            pequeño = 11;
            do
            {
                Console.WriteLine("El valor es:" + pequeño);
                pequeño++;
            } while (pequeño <= TOPE);
        }
    }
}
