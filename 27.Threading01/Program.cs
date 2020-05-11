using System;
using System.Threading;
namespace _27.Threading01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- Programa 27 Hilos -----------");
            //Nombramos el thread principal
            Thread.CurrentThread.Name="Principal";

            //Creamos dos thread.
            Thread t1=new Thread(Imprime);
            Thread t2=new Thread(Imprime);

            //Damos nombre a los threads que creamos.
            t1.Name="Thread 01";
            t2.Name="Thread 02";

            //Invocamos los threads.
            t1.Start();
            t2.Start();

            //Invocamos Imprime() desde el thread principal.
            Imprime();

            Console.WriteLine("Saludos desde Main, se ha terminado todo.");
        }

        static void Imprime(){
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Imprime . {i} desde {Thread.CurrentThread.Name}.");
                Thread.Sleep(100);
            }
        }
    }
}
