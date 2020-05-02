using System;

namespace _25.Interfaz01
{
    class Program
    {

        public interface IAnimal{
            string Nombre{get;set;}
            void Llorar();
        }

        class Perro : IAnimal{
            public Perro(string nombre) => Nombre=nombre;
            public string Nombre {get; set;}
            public void Llorar() => Console.WriteLine("Wooff Wooff !!");
        }

        class Gato : IAnimal {
            public Gato(string nombre) => Nombre=nombre;
            public string Nombre{get;set;}
            public void Llorar() => Console.WriteLine("Meeow Meeow !!");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("----------- Programa de interfaces ----------");
            Perro perro = new Perro("Sabuesa");
            Console.WriteLine($"El perro {perro.Nombre} -------- ");
            perro.Llorar();
            
            Gato gato= new Gato("Misifuos");
            Console.WriteLine($"El gato {gato.Nombre} ----------");
            gato.Llorar();
        }
    }
}
