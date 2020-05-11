using System;
using System.Threading;
namespace _29.Threading03
{
    class Impresora{
        public void imprime(object o){
            lock(this){
                for (int i = 1; i <= 10; i++)
                {
                    Thread.Sleep(100);
                    Console.WriteLine($"{o} - {i} .");
                }
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- Programa 29 Hilos ----------");
            Impresora i = new Impresora();
            Thread t1= new Thread(i.imprime);
            Thread t2 =new Thread(i.imprime);

            t1.Start(t1.ManagedThreadId);
            t2.Start(t2.ManagedThreadId);

            i.imprime(Thread.CurrentThread.ManagedThreadId);
        }
    }
}
