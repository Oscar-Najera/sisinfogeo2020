using System;

namespace _31.Delegados01
{

    //Declarando un delegado.
    public delegate void MiDelegado(string msj);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- Programa 31: Delegados. ----------");
            MiDelegado d; // Se instancia el delegado.

            Console.Clear();

            //Delefado invoca al método Mensaje 01 de la clase mensajes.
            d=Mensajes.Mensaje1;
            d("Juan");

            //Delegado invoa al método Mensaje 02 de la clase mensajes.
            d=Mensajes.Mensaje2;
            d("Jose");

            //Delegado invoca a una expresión lambada.
            d=(string msj) => Console.WriteLine($"{msj} - paga todo que no pare la fiesta. ");
            d("Carlos");

            Console.WriteLine();

        }
    }

    public class Mensajes{
        public static void Mensaje1(string msj){
            Console.WriteLine($"{msj} - lleva el pastel.");
        }
        public static void Mensaje2(string msj){
            Console.WriteLine($"{msj} - fue el culpable de que se cancela la fiesta. ");
        }
    }
}
