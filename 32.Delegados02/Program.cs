using System;

namespace _32.Delegados02
{

    // Declarando un delegado.
    public delegate void MiDelegado(string msj);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- Programa 32 Delegados ----------");
            //Se declarán los delegados.
            MiDelegado d1;
            MiDelegado d2;
            MiDelegado d3;

            MiDelegado d; //Se declará el delegado multicast.

            Console.Clear();

            //Asocia d1 a Mensaje 01 y d2 a Mensaje 02
            d1=Delegados.Mensaje1;
            d2=Delegados.Mensaje2;

            d=d1+d2; //Combina delegado d1 y d2
            d("El peje");
            Console.WriteLine();

            d3=(string msj) => Console.WriteLine($"{msj} - paga todo, que no pare la fiesta.");
            d+= d3; //Agrega delegado d3.
            d("El borolas");
            Console.WriteLine();

            d-=d2; //Quita al delegado d2.
            d("Peña");
            Console.WriteLine();

            d-=d1; //Quita delegado d1.
            d("Tello");
            Console.WriteLine();

        
        }
    }
}
