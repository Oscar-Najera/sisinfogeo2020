using System;

namespace _07.vectorpromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector={10,20,30,40,50,60,70,80,90,100,
                        10,20,30,40,50,60,70,80,90,100,
                        10,20,30,40,50,60,70,80,90,100,
                        10,20,30,40,50,60,70,80,90,100,
                        10,20,30,40,50,60,70,80,90,100,            
                        };
            int suma=0;
            float promedio =0;
            Console.WriteLine("Calcular el promedio de 50 valores constantes! \n");
            Console.WriteLine("Los elementos del arreglo son \n");
            imprime(vector);     
            promedio=prom(vector);
            Console.WriteLine($"\nEl promedio es: {promedio} "); 
            Console.WriteLine($"La cantidad de numeros mayores al promedio son {mayores(vector,promedio)}");  
        }

        static int mayores(int[] vector,float p){
            int contador=0;
            for(int i=0;i<vector.Length;i++){
                if(vector[i]>p){
                    contador++;
                }

            }
            return contador;
        }

        static void imprime(int[] v){
            for(int i=0; i<v.Length;i++){
                Console.Write($"{v[i]} ");
            }

        }

        static float prom (int[] v){
            int suma =0;
            for(int i=0; i<v.Length;i++){
                suma+=v[i];
            }
            return suma/v.Length;

        }
    }
}
