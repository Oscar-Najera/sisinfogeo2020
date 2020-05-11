﻿using System;
using System.Threading;

namespace _28.Threading02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------- Programa 28 Hilos -----------");
            for (int i = 1; i <= 10; i++)
            {
                Thread t = new Thread(Imprime);
                t.Start(i);
            }
        }

        static void Imprime(object o){
            int s=0;
            for (int i = 0; i <= 500000; i++)
            {
                Console.WriteLine($"Imprime en hilo {o} / {i}.");
                s+=i;
            }
            Console.WriteLine($"Suma hilo {o} = {s}.");
        }
    }
}
