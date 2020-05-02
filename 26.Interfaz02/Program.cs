using System;

namespace _26.Interfaz02
{
    public class Organismo
    {
        public void Respiracion(){
            Console.WriteLine("Respiracion");
        }
        public void Movimiento(){
            Console.WriteLine("Movimiento");
        }
        public void Crecimiento(){
            Console.WriteLine("Crecimiento");
        }
    }
    public interface IAnimales{
        void MultiCelular();
        void SangreCaliente();
    }
    public interface ICanino: IAnimales{
        void Corre();
        void CuatroPatas();
    }
    public interface IPajaro: IAnimales{
        void Vuela();
        void DosPatas();
    }
    public class Perro : Organismo, ICanino{
        public void MultiCelular()=> Console.WriteLine("Multicelular");
        public void SangreCaliente()=> Console.WriteLine("Sangre caliente");
        public void Corre() => Console.WriteLine("Corre");
        public void CuatroPatas() => Console.WriteLine("Cuatro patas");     
    }
    public class Perico : Organismo, IPajaro {
        public void MultiCelular() => Console.WriteLine("Multicelular");
        public void SangreCaliente() => Console.WriteLine("Sangre caliente");
        public void Vuela()=> Console.WriteLine("Vuela");
        public void DosPatas()=>Console.WriteLine("Dos patas");
    }

    class Program{
        
        static void Main(string[] args)
        {
            Console.WriteLine("----------- Segundo programa de interfaces. -----------");
            Perro perro =new Perro();
            Console.WriteLine("\n Caracateristicas del perro: \n");
            perro.Respiracion();
            perro.Movimiento();
            perro.Crecimiento();
            perro.Corre();
            perro.CuatroPatas();

            Perico perico=new Perico();
            Console.WriteLine("\n Caracteristicas del perico: \n");
            perico.Respiracion();
            perico.Movimiento();
            perico.Crecimiento();
            perico.Vuela();
            perico.DosPatas();
        }

    }

}

