using System;
using System.Collections.Generic;

namespace _18.Diccionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diccionarios");
            //Definimos el diccionario y reservamos espacio en memoria para el.
            Dictionary<string, string> larousse=new Dictionary<string, string>();

            //Agregar entradas al diccionario
            larousse.Add("txt","Archivo de texto");
            larousse.Add("jpg","Archivo de imagen");
            larousse.Add("mp3","Archivo de sonido");
            larousse.Add("htm","Archivo HTML");
            larousse.Add("exe","Archivo ejecutable de Windows");
            larousse.Add("lll","Archivo desconocido");

            //Acceder a un elemento en base a la llave.
            Console.WriteLine(larousse["htm"]);

            //Verificar si una llave existe.
            if(larousse.ContainsKey("elf")){
                Console.WriteLine("La llave ya existe");
            }else{
                larousse.Add("elf","Archivo ejecutable de Linux");
            }
            //Modificar un valor del diccionario en base a la llave
            larousse["htm"]="Archivo de texto HTML";
            Console.WriteLine("-----Modificado------");
            Console.WriteLine(larousse["htm"]);

      

            //Borrar una entrada si la llave existe
            if(larousse.ContainsKey("lll")){
                larousse.Remove("lll");
            }

            //Recorrer el diccionario e imprimir la llave y su valor.
            foreach(KeyValuePair<string,string> val in larousse){
                Console.WriteLine($"{val.Key} ---- {val.Value}");
            }

            //Imprimir solo las llaves del diccionario.
            Console.WriteLine("------Llaves------");
            foreach(string llave in larousse.Keys){
                Console.WriteLine(llave);
            }

            //Imprimir solo los valores
            Console.WriteLine("-----Valores-----");
            foreach(string valor in larousse.Values){
                Console.WriteLine(valor);
            }

            //Borrar todos los datos del diccionario
            larousse.Clear();

            //---------------------------------------------------------------------------------
            //Sorted dictionary

            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Diccionario ordenado\n");
            SortedDictionary<string,string> miDic=new SortedDictionary<string, string>();
            //Agregar entradas al diccionario
            miDic.Add("txt","Archivo de texto");
            miDic.Add("jpg","Archivo de imagen");
            miDic.Add("mp3","Archivo de sonido");
            miDic.Add("htm","Archivo HTML");
            miDic.Add("exe","Archivo ejecutable de Windows");
            miDic.Add("lll","Archivo desconocido");

            //Acceder a un elemento en base a la llave.
            Console.WriteLine(miDic["htm"]);

            //Verificar si una llave existe.
            if(miDic.ContainsKey("elf")){
                Console.WriteLine("La llave ya existe");
            }else{
                miDic.Add("elf","Archivo ejecutable de Linux");
            }
            //Modificar un valor del diccionario en base a la llave
            miDic["htm"]="Archivo de texto HTML";
            Console.WriteLine("-----Modificado------");
            Console.WriteLine(miDic["htm"]);

      

            //Borrar una entrada si la llave existe
            if(miDic.ContainsKey("lll")){
                miDic.Remove("lll");
            }

            //Recorrer el diccionario e imprimir la llave y su valor.
            foreach(KeyValuePair<string,string> val in miDic){
                Console.WriteLine($"{val.Key} ---- {val.Value}");
            }

            //Imprimir solo las llaves del diccionario.
            Console.WriteLine("------Llaves------");
            foreach(string llave in miDic.Keys){
                Console.WriteLine(llave);
            }

            //Imprimir solo los valores
            Console.WriteLine("-----Valores-----");
            foreach(string valor in miDic.Values){
                Console.WriteLine(valor);
            }

            //Borrar todos los datos del diccionario
            miDic.Clear();

            


        }
    }
}
