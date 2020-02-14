using System;

namespace _13.vectorEstadisticas
{
    class Program
    {
        static void Main(string[] args)
        {
            double mayor=0, menor=0, media=0, varianza=0, desviacionEstandar=0;
            double[] vectorA=new double[int.Parse(args[0])];
            
            vectorA=llenaVectorAleatorio(int.Parse(args[0]));
            Console.WriteLine("---Vector estadisticas---");
            Console.WriteLine("---------- Vector ----------");
            imprime(vectorA);
            mayor=elementoMayor(vectorA);
            Console.WriteLine($"Numero mayor {mayor} ");
            menor=elementoMenor(vectorA);
            Console.WriteLine($"Numero menor {menor} ");
            media=obtenMedia(vectorA);
            Console.WriteLine($"La media es: {media}");
            varianza=obtenVarianza(vectorA,media);
            Console.WriteLine($"La varianza es: {varianza}");
            desviacionEstandar=obtenDesviacionEstandar(varianza);
            Console.WriteLine($"La desviacion estandar es: {desviacionEstandar}");
        }

        static double[] llenaVectorAleatorio(int cantidadElementos){
            Random aleatorio=new Random();
            double[] vectorAleatorio = new double[cantidadElementos];
            for(int i=0;i<cantidadElementos;i++){
                vectorAleatorio[i]=aleatorio.Next(1,1000);
            }
            return vectorAleatorio;

        }

        static void imprime(double[] v){
            for(int i=0;i<v.Length;i++){
                Console.Write($"{v[i]} " );
            }
            Console.WriteLine();
        }

        static double elementoMayor(double[] vector){
            double numeroMayor=0;
            for(int i=0;i<vector.Length;i++){
                if(numeroMayor<vector[i]){
                    numeroMayor=vector[i];
                }else{
                    //es mayor el numero actual
                }
            }
            return numeroMayor;
        }

        static double elementoMenor(double[] vector){
            double numeroMenor=vector[0];
            for(int i=0;i<vector.Length;i++){
                if(numeroMenor>vector[i]){
                    numeroMenor=vector[i];
                }else{
                    //Es menor que el actual
                }
            }
            return numeroMenor;
        }

        static double obtenMedia(double[] vector){
            double media=0, sumatoria=0;
            for(int i=0;i<vector.Length;i++){
                sumatoria+=vector[i];
            }
            media=sumatoria/vector.Length;
            return media;
        }

        static double obtenVarianza(double[] vector, double media){
            double valorVarianza=0;
            for(int i=0;i<vector.Length;i++){
                valorVarianza+=(Math.Pow((vector[i]- media),2));
            }
            valorVarianza=valorVarianza/(vector.Length-1);
            return valorVarianza;
        }

        static double obtenDesviacionEstandar(double varianza){
            double desviacionEstandar=0;
            desviacionEstandar=Math.Sqrt(varianza);
            return desviacionEstandar;
        }
    }
}
