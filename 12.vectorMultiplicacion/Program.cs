using System;

namespace _12.vectorMultiplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vectorA=new double[int.Parse(args[0])];
            double[] vectorB=new double[int.Parse(args[0])];
            double[] vectorC=new double[int.Parse(args[0])];
            Console.WriteLine("- Vector multiplicado -");
            vectorA=llenaVectorAleatorio(int.Parse(args[0]));
            Console.WriteLine("------- Vector A ---------");
            imprime(vectorA);
            Console.WriteLine("------- Vector B ---------");
            vectorB=llenaVectorAleatorio(int.Parse(args[0]));
            imprime(vectorB);
            Console.WriteLine("------- Vector C ---------");
            int ultimoElemento=int.Parse(args[0]);
            for(int i=0;i<int.Parse(args[0]);i++){
                vectorC[i]=vectorA[i]*vectorB[ultimoElemento-1];
                ultimoElemento--;
            }
            imprime(vectorC);
        }

        static double[] llenaVectorAleatorio(int cantidadElementos){
            Random aleatorio=new Random();
            double[] vectorAleatorio = new double[cantidadElementos];
            for(int i=0;i<cantidadElementos;i++){
                vectorAleatorio[i]=aleatorio.Next(1,1000);
            }
            return vectorAleatorio;

        }

        static double[] multiplicaVectores(int cantidadElementos, double[] vectorA, double[] vectorB){
            int ultimoElemento=cantidadElementos;
            double[] vectorResultado=new double[cantidadElementos];
            for(int i=0;i<cantidadElementos;i++){
                vectorResultado[i]=vectorA[i]*vectorB[ultimoElemento];
                ultimoElemento--;
            }
            return vectorResultado;
        }

        static void imprime(double[] v){
            for(int i=0;i<v.Length;i++){
                Console.Write($"{v[i]} " );
            }
            Console.WriteLine();
        }
    }
}
