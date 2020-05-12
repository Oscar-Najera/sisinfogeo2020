using System;

//Ejemplo de delegado multicast con parámetros.
namespace _33.Delegados03
{
    public delegate int MiDelegado(int a, int b); //Declaramos delegado.
    class Program
    {
        static void Main(string[] args)
        {
            MiDelegado d1=A.MetodoA;
            MiDelegado d2=B.MetodoB;
            Console.WriteLine("--------- Delegados multicast ----------");

            //Invocamos delegados de forma separada.
            Console.WriteLine($"La suma es de : {d1(10,20)}.");
            Console.WriteLine($"La multiplicación es {d2(10,20)}.");
            Console.WriteLine();

            //Delegado multicast que une los dos métodos.
            MiDelegado d = d1+d2;
            Console.WriteLine($"El resultado es {d(10,20)}."); //Regresa el resultado del último método invocado.
            Console.WriteLine();
            Console.WriteLine();
        }
    }

    public class A {
        public static int MetodoA(int a, int b){
            return a+b;
        }
    }

    public class B {
        public static int MetodoB(int a, int b){
            return a*b;
        }
    }
}
