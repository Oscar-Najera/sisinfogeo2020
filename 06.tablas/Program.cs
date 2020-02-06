using System;

namespace _06.tablas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Imprimir una tabla de multiplicar específica hasta cierto número");           
            imprimirTablaMultiplicar(int.Parse(args[0]),int.Parse(args[1]));
        }

        static void imprimirTablaMultiplicar(int tabla, int limite){
            for(int i=0;i<limite;i++){
                int resultado=0;
                resultado=tabla*i;
                Console.WriteLine($"{tabla} X {i} = {resultado}");
            }
        }
    }
}
