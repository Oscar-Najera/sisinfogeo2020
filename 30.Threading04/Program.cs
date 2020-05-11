using System;
using System.Threading;

namespace _30.Threading04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- Programa 30 Multihilos -----------");
            Console.WriteLine("Hilo principal iniciado");
            //Crear threads con nombre.
            Thread t1=new Thread(Metodo01) {Name="Cliente 01"};
            Thread t2= new Thread(Metodo02) {Name= "Cliente 02"};
            Thread t3 = new Thread(Metodo03) {Name = "Cliente 03"};

            //Ejecutando métodos.
            t1.Start();
            t2.Start();
            t3.Start();
            Console.WriteLine("Thread principal terminado.");
        }

        static void Metodo01(){
            Console.WriteLine("Método 01 iniciado usando "+Thread.CurrentThread.Name);
            for(int i=1; i <= 5 ; i++)
                Console.WriteLine("Método 01 : "+i);
            Console.WriteLine("Método terminado usando "+Thread.CurrentThread.Name);
        }

        static void Metodo02(){
            Console.WriteLine("Método 02 iniciado usando "+Thread.CurrentThread.Name);
            for(int i=1; i<=5; i++){
                Console.WriteLine("Método 2 : "+i);
                if(i==3){
                    Console.WriteLine("Iniciando operación sobre la base de datos ");
                    Thread.Sleep(10000);
                    Console.WriteLine("Operación sobre la base de datos terminada");
                }
            }
            Console.WriteLine("Método 2 terminado usando "+Thread.CurrentThread.Name);
        }

        static void Metodo03(){
            Console.WriteLine("Método 03 iniciado usando "+Thread.CurrentThread.Name);
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Método 3 : "+ i);
            }
            Console.WriteLine("Método 3 terminado usando "+Thread.CurrentThread.Name);
        }


    }
}
