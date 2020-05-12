using System;
namespace _35.Delegados05
{
    //Ejemplo de delegado como parámetro.
    public delegate void MiDelegado(string msj);

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("---------- Delegado como parámetro ----------");
            MiDelegado del; //Se crea instancia de MiDelegado

            Console.Clear();

            del=ClaseA.MetodoA;
            InvocaDelegado(del); //Se invoca al delegado.

            del=ClaseB.MetodoB;
            InvocaDelegado(del); //Se invoca al delegado.

            del=(string msj) => Console.WriteLine($"Llamado expresión lambada: {msj} ");
            InvocaDelegado(del); //Se invoca al delegado.

            Console.WriteLine();

        }

        //Esté método recibe como parámetro un delegado.
        static void InvocaDelegado(MiDelegado del){
            del("Hola Mundo."); //Se invoca al delegado.
        }
    }

    class ClaseA{
        public static void MetodoA(string msj){
            Console.WriteLine($"Llamando método A de clase A : {msj}");
        }
    }

    class ClaseB{
        public static void MetodoB(string msj){
            Console.WriteLine($"Llamando método B de clase B : {msj}");
        }
    }
}
