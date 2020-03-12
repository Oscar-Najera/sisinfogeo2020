using System;
using System.Collections.Generic;

namespace _20.ListasV2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear lista de tipo pieza.
            List<Pieza> misPiezas= new List<Pieza>(); 
            //Agregar elementos a la lista.
            misPiezas.Add(new Pieza(1234,"Tuerca de rosca interior"));
            misPiezas.Add(new Pieza(5678,"Tornillo de cabeza grande"));
            misPiezas.Add(new Pieza(9101,"Bateria 12 v"));
            //Agregar un rango de elementos.
            var proveedor = new List<Pieza>(){
                new Pieza(8888,"Tornillo de cabeza pequeña"),
                new Pieza(9999,"Cables para pasar corriente"),
                new Pieza(6666,"Tridente del diablo")
            };
            //Usar metodo foreach integrado en la lista para imprimir su contenido
            misPiezas.AddRange(proveedor);
            misPiezas.ForEach(p=>Console.WriteLine(p.ToString()));

            //Eliminar el ultimo elemento de la lista
            misPiezas.RemoveAt(misPiezas.Count-1);

            //Insertar un elemento en la segunda posicion.
            Console.WriteLine("Insertar un elemento en la posicion 2");
            misPiezas.Insert(1,new Pieza(2222,"Caja de 8 velocidades "));
            misPiezas.ForEach(p=>Console.WriteLine(p.ToString()));

            //Buscar todas las piezas que sean tornillos
            Console.WriteLine("Piezas que contienen tornillo");
            var t = misPiezas.FindAll(x=>x.Nombre.Contains("Tornillo"));
            t.ForEach(p=>Console.WriteLine(p.ToString()));

            //Buscar todas las piezas cuyo ID sea mayor que 5000
            Console.WriteLine("Piezas con ID > 5000");
            var t1 = misPiezas.FindAll(x=>x.Id>5000);
            t1.ForEach(p=>Console.WriteLine(p.ToString()));

        }
    }
}
