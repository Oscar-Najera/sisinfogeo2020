using System;

namespace _06.tablas
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //    Console.WriteLine("Imprimir una tabla de multiplicar específica hasta cierto número");           
            //   imprimirTablaMultiplicar(int.Parse(args[0]),int.Parse(args[1]));

          
                Console.WriteLine("Imprimir las tablas deseadas hasta el número deseado.");
                imprimirTablaMultiplicarAvanzado(int.Parse(args[0]),int.Parse(args[1]),int.Parse(args[2]));
            
        }

        static void imprimirTablaMultiplicar(int tabla, int limite){
            limite++;
            for(int i=0;i<limite;i++){
                int resultado=0;
                resultado=tabla*i;
                Console.WriteLine($"{tabla} X {i} = {resultado}");
            }
        }

        static void imprimirTablaMultiplicarAvanzado(int tablaFinal, int limInf, int limSup){
            for(int i=0;i<=tablaFinal;i++){
                for(int j=limInf; j<=limSup;j++){
                    int resultado=0;
                    resultado=i*j;
                    Console.Write($"{i} X {j} = {resultado} \t");
                };
                Console.WriteLine();
                Console.WriteLine("-------------------------------------------");
            }

        }
    }
}
