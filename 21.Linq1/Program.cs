using System;
using System.Linq;
using System.Collections.Generic;

namespace _21.Linq1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Usos de Linq");
            int[] numeros= new int[]{
                10,20,30,40,50,60,70,80,94,102
                -10,-20,0,1000,2007,3009,4000,5000,
                10,20,30,40,50,60,70,83,90,100,
                -10,-20,0,1003,2001,3005,4009,5009
            };

            //Consulta 1 pares (regresa un Ienumerable <int>)
            var consulta =
                from num in numeros
                where num%2==0
                select num;

            //Ejecutar consulta
            foreach(var num in consulta)
                Console.Write($"{num} ");

            //Consulta 2, impares no negativos, ni ceros en un arreglo (regresa un arreglo de int[])
            Console.WriteLine("\n\n------------------Consulta 2----------------");
            var consulta2=(from num in numeros where num%2!=0 && num>0 select num).ToArray();
            for(int i=0;i<consulta2.Count();i++)
                Console.Write($"{consulta2[i]} ");

            //Consulta 3
            var consulta3=
                (from num in numeros
                    where num<0
                    select num ).ToList();
            Console.WriteLine("\n\n------------------Consulta 3----------------------");
            consulta3.ForEach(num=>Console.Write(num));
        }
    }
}
