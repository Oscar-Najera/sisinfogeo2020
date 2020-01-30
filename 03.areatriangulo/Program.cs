using System;

namespace _03.areatriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double LaBase,altura,area;
            Console.WriteLine("Programa que calcula el area de un triangulo");
            Console.WriteLine("Dame la base: ");
            LaBase=double.Parse(Console.ReadLine());
            Console.WriteLine("Dame la altura: ");
            altura=double.Parse(Console.ReadLine());
            area=(LaBase*altura)/2;
            Console.WriteLine($"El area es: {area}");

        }
    }
}
