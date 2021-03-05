using System;
using System.Globalization;

namespace URItest
{
    class Program
    {
        static void Main(string[] args)
        {
            double area;
            double b;
            double altura;
            double perimetro;
            double diagonal;


            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = b * altura;
            perimetro = 2 * b + 2 * altura;            
            diagonal = Math.Sqrt(Math.Pow(b, 2.0) + Math.Pow(altura, 2.0));
            

            Console.WriteLine("Área = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));


        }
    }
}
