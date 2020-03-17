using System;
using System.Linq;

namespace _22.Linq2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] frutas= new string[]{
                "pera", "melon", "sandia", "papaya", "durazno", "platano",
                "manzana", "kiwi", "pitayas", "mango", "cereza"
            };

            Console.WriteLine("-------------------Primera Consulta-------------------");
            var qry=
                from fruta in frutas
                where fruta.StartsWith("m")
                select fruta;

            foreach(string f in qry){
                Console.WriteLine(f);
            }
             Console.WriteLine($"Total: {qry.Count()}");

            Console.WriteLine("\n --------------------Segunda Consulta----------------------------");
            var qry2= 
                (from fruta in frutas where fruta.Contains("an") select fruta).ToList();
                qry2.ForEach(f=>Console.WriteLine(f));
                Console.WriteLine($"Total: {qry2.Count()}");


        }
    }
}
