using System;
using System.Collections.Generic;
using System.Linq;
namespace _23.Linq3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Estudiante> grupo= new List<Estudiante>();
            grupo.Add(new Estudiante{Id=1234,Nombre="Jose",Ciudad="Zacatecas",Calle="1a de mayo",Cals=new List<int>{90,80,70,60}});
            grupo.Add(new Estudiante{Id=4567,Nombre="Maria",Ciudad="Fresnillo",Calle="Benito Juarez",Cals=new List<int>{90,50,60,60}});
            grupo.Add(new Estudiante{Id=7888,Nombre="Miguel",Ciudad="Jerez",Calle="Garcia Salinas",Cals=new List<int>{50,50,50,40}});
            grupo.Add(new Estudiante{Id=6666,Nombre="Lourdes",Ciudad="Zacatecas",Calle="El Vergel",Cals=new List<int>{100,100,100,90}});

            //Imprimir los datos
            Console.WriteLine("\n Todo de todos: \n");
            grupo.ForEach(est=>Console.WriteLine(est.ToString()));

            //Todos ordenados por nombre
            Console.WriteLine("\n Todo ordenado por nombre: \n");
            var q1= (from est in grupo orderby est.Nombre select est).ToList();
            q1.ForEach(est => Console.WriteLine(est.ToString()));
            
            //Nada mas los de zacatecas
             Console.WriteLine("\n Los de Zacatecas: \n");
             var q2=(from est in grupo where est.Ciudad=="Zacatecas" select est).ToList();
             q2.ForEach(est=>Console.WriteLine(est.ToString()));

             //Los estudiantes con promedio arriba de 70
             Console.WriteLine("\n --------Los estudiantes con promedio arriba de 70 ----------");
             var q3=(from est in grupo where est.Cals.Average()>70 select new{nombre=est.Nombre, promedio=est.Cals.Average()}).ToList();
             q3.ForEach(est=>Console.WriteLine($"Nombre: {est.nombre}, Promedio: {est.promedio}"));   
            
            //Agrupar por ciudad
            Console.WriteLine($"\n-------Los estudiantes por ciudad----------");
            var q4=(from est in grupo group est by est.Ciudad);
            foreach (var ciudad in q4)
            {
                Console.WriteLine(ciudad.Key);
                foreach(var est in ciudad){
                    Console.WriteLine(est.ToString());
                }
            }

        }
    }
}
