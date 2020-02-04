using System;

namespace _04.ciclos
{
    class Program
    {
        static int Main(string[] args)
        {
            int opcion,contador=0,suma=0;
            if(args.Length==0) Menu();
                opcion=int.Parse(args[0]);
            Console.Clear();
            switch(opcion){
                case 1:{
                    contador=1;
                    suma=0;
                    while(contador<=100){
                        Console.Write($"{contador} ");
                        suma+=contador;
                        contador++;
                    }
                    Console.WriteLine($"\nLa suma es {suma} \n");
                }
                break;

                case 2:{
                    contador=100;
                    suma=0;
                    while(contador>=1){
                        Console.Write($"{contador} ");
                        suma+=contador;
                        contador--;
                    }
                    Console.WriteLine($"\nLa suma es {suma} \n");
                }
                break;

                case 3:{
                    suma=0;
                    for(contador=50;contador<=200;contador++){
                        Console.Write($"{contador} ");
                        suma+=contador;
                    }
                    Console.WriteLine($"\nLa suma es {suma} \n");
                }
                break;

                case 4:{
                    suma=0;
                    for(contador=2;contador<=100;contador+=2){
                        Console.Write($"{contador} ");
                        suma+=contador;
                    }
                    Console.WriteLine($"\nLa suma es {suma} \n");
                }
                break;

                case 5:{
                    suma=0;
                    for(contador=99;contador>=1;contador-=2){
                        Console.Write($"{contador} ");
                        suma+=contador;
                    }
                    Console.WriteLine($"\nLa suma es {suma} \n");
                }
                break;

                case 6:{
                    contador=272;
                    suma=0;
                    while(contador>=40){
                        Console.Write($"{contador} ");
                        suma+=contador;
                        contador-=4;
                    }
                    Console.WriteLine($"\nLa suma es {suma} \n");
                }
                break;

                default: Console.WriteLine("Opcion invalida");
                break;
            }
            return 0;
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("Programa sobre el uso de estructuras de control \n\n");
            Console.WriteLine("[1] . Numeros del 1 al 100 con ciclo while ");
            Console.WriteLine("[2] . Numeros del 100 al 1 con ciclo do ... while ");
            Console.WriteLine("[3] . Numeros del 50 al 200 con ciclo for ");
            Console.WriteLine("[4] . Números del 2 al 100 solo los pares con ciclo for ");
            Console.WriteLine("[5] . Números del 99 al 1 solo los impares con ciclo for ");
            Console.WriteLine("[6] . Números del 272 al 40 en decrementos de 4 con ciclo while ");
        }
    }
}
