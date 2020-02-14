using System;

namespace _11.vectorInverso
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX=15;
            // Creamos los dos vectores
            double [] vectorOriginal=new double [MAX];
            double[] vectorInverso=new double[MAX];
            //Para los numeros aleatorios
            Random aleatorio= new Random();
            //Llenamos el primer vector con numeros aleatorios.
            for(int i=0; i<MAX; i++){
                vectorOriginal[i]=aleatorio.Next(1,1000);
            }
            Console.WriteLine("-- Vector original --");
            imprime(vectorOriginal);
            int contador=MAX;
            //Llenamos el vector inverso
            for(int i=0;i<MAX;i++){
                vectorInverso[i]=vectorOriginal[contador-1];
                contador--;
            }
            Console.WriteLine("-- Vector inverso --");
            imprime(vectorInverso);

            
        }

        static void imprime(double[] v){
            for(int i=0;i<v.Length;i++){
                Console.Write($"{v[i]} " );
            }
            Console.WriteLine();
        }
    }
}
