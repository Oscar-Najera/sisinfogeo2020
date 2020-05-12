using System;
//Ejemplo de delegado genérico.
namespace _34.Delegados04
{
    public delegate T Suma<T>(T param1, T param2); //Declara delegado genérico.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- Delegado genérico ---------- ");
            Suma<int> d1 = Sumar; //Delegado a método Sumar de tipo int con parámetros in , int
            Console.WriteLine(d1(10,20));

            Suma<string> d2 =Concatenar; //Delegado a método concatenar de tipo string con parametros string, string
            Console.WriteLine(d2("Mi mamá me "," mima mi mamá"));
            Console.WriteLine();
        }

        public static int Sumar(int a, int b){
            return a+b;
        }

        public static string Concatenar(string a, string b){
            return a + b;
        }
    }
}
