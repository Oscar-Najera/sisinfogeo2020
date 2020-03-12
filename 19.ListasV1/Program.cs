using System;
using System.Collections.Generic;

namespace _19.ListasV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Listas");
            //Definir una lista de valores iniciales.
            List<string> mats = new List<string>(){
                "Calculo I",
                "Redacción avanzada",
                "Introducción a la ingenieria"
            };

            //Agregar elementos a la lista
            mats.Add("Matematicas discretas");
            mats.Add("Compiladores e interpretadores");

            Imprime(mats);

            //Agrega un rango de materias
            string[] mopt ={
                "Sistemas de Info Geo (op)",
                "Seguridad en Redes (op)",
                "Topicos selectos de redes (op)"
            };
            mats.AddRange(mopt);
            Imprime(mats);

            //Invertir los elementos de la lista
            mats.Reverse();
            Imprime(mats);

            //Ordenar la lista
            mats.Sort();
            Imprime(mats);

            //Buscar un elemento en la lista, en base a una condición
            Console.WriteLine("Buscar una materia que tenga la palabra Discretas");
            string mat= mats.Find(x=>x.Contains("Discretas"));
            Console.WriteLine(mat);
            //Buscar un elemento en la lista, en base a una condición
            Console.WriteLine("Buscar todas las materias que tengan la palabra (op)");
            var ms= mats.FindAll(x=>x.Contains("(op)"));
            Imprime(ms);
        }

        static void Imprime(List<string> lista){
            Console.WriteLine("---------------");
            Console.WriteLine();
            foreach (string m in lista)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine(lista.Count);
        }


    }
}
