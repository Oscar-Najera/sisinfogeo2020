using System;
using System.Collections.Generic;
namespace TercerExamenParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tercer examen parcial.");
            Menu();

        }
        static void Menu(){
            int seleccion;
            do{
                Console.WriteLine("*******************************************");
                Console.WriteLine("***** Caracteristicas Nuevas en C# 8.0 ****");
                Console.WriteLine("*******************************************");
                Console.WriteLine("*");
                Console.WriteLine("**    [1] Miembros de solo lectura.      **");
                Console.WriteLine("**    [2] Expresiones switch.            **");
                Console.WriteLine("**    [3] Patrones de propiedades.       **");
                Console.WriteLine("**    [4] Patrones de tupla.             **");
                Console.WriteLine("**    [5] Patrones posicionales.         **");
                Console.WriteLine("**    [6] Declaraciones using.           **");
                Console.WriteLine("**    [7] Funciones locales estaticas.   **");
                Console.WriteLine("**    [8] Indices y rangos.              **");
                Console.WriteLine("**    [0] Salir.                         **");
                Console.WriteLine("*");
                Console.WriteLine("*******************************************");
                seleccion=int.Parse(Console.ReadLine());
                if(seleccion<0 || seleccion>8){
                    Console.WriteLine("Por favor seleccione una opcion valida.");
                }
                switch(seleccion)
                {
                case 1:
                    Console.WriteLine("***************************************************************");
                    Console.WriteLine("Uso del read only aplicado al calculo de area de un rectangulo.");
                    Rectangulo rec = new Rectangulo();
                    Console.WriteLine("Escriba la altura: ");
                    rec.Altura=double.Parse(Console.ReadLine());
                    Console.WriteLine("Escriba la base: ");
                    rec.Base=double.Parse(Console.ReadLine());;
                    Console.WriteLine(rec.ToString());
                    Console.WriteLine("***************************************************************");
                break;
                case 2:
                    Console.WriteLine("***************************************************************");
                    Console.WriteLine("Uso del menú switch aplicado a obtener un RGB de color.");
                    Console.WriteLine("***************************************************************");
                    Console.WriteLine("*");
                    menuSwitch();
                    Console.WriteLine("***************************************************************");          
                break;
                case 3:
                    Console.WriteLine("***************************************************************");
                    Console.WriteLine("Uso de los patrones de propiedades para decidir tarifas de transporte.");
                    Console.WriteLine("***************************************************************");
                    Console.WriteLine("*");
                    patronesPropiedades();
                    Console.WriteLine("***************************************************************");
                break;
                case 4:
                    string seleccionJugadorUno;
                    string seleccionJugadorDos;
                    Console.WriteLine("***************************************************************");
                    Console.WriteLine("Uso de los patrones de tuplas para jugar piedra papel o tijeras.");
                    Console.WriteLine("***************************************************************");
                    Console.WriteLine("*");
                    Console.WriteLine("*Escribe tu seleccion:");
                    Console.WriteLine("***************************************************************");
                    Console.WriteLine("* Jugador uno ¿que escoges: Piedra, papel o tijeras?.");
                    Console.WriteLine("***************************************************************");
                    seleccionJugadorUno=Console.ReadLine();
                    Console.WriteLine("* Jugador dos ¿que escoges: Piedra, papel o tijeras?.");
                    seleccionJugadorDos=Console.ReadLine();
                    Console.WriteLine("***************************************************************");
                    Console.WriteLine("*                                                             *");
                    Console.WriteLine(JuegoTuplas(seleccionJugadorUno,seleccionJugadorDos));
                    Console.WriteLine("***************************************************************");
                break;
                case 5:
                    Point punto;
                    int puntoX,puntoY;
                    Console.WriteLine("***************************************************************");
                    Console.WriteLine("Uso de los patrones de posicionales.");
                    Console.WriteLine("***************************************************************");
                    Console.WriteLine("*");
                    Console.WriteLine("*Por favor introduce el valor de X");
                    Console.WriteLine("*");
                    puntoX=int.Parse(Console.ReadLine());
                    Console.WriteLine("*");
                    Console.WriteLine("*Por favor introduce el valor de Y");
                    Console.WriteLine("*");
                    puntoY=int.Parse(Console.ReadLine());
                    Console.WriteLine("*");
                    punto=new Point(puntoX,puntoY);
                    Console.WriteLine("*El punto que consultaste se encuentra en el cuadrante:    "+GetQuadrant(punto)+".");
                    Console.WriteLine("***************************************************************");
                break;
                case 6:
                    Console.WriteLine("***************************************************************");
                    Console.WriteLine("Declaraciones de Using para escribir un archivo de texto.");
                    Console.WriteLine("***************************************************************");
                    Console.WriteLine("* Escribiendo en archivo");
                    IEnumerable<string> lineas =  new List<string>() {"Uno","Dos","Primero","Dos","tercer","Cuarto","Segundo","Segundo"};
                    EscribeLineasEnArchivo(lineas);                                    
                    Console.WriteLine("***************************************************************");
                break;
                case 7:
                    Console.WriteLine("***************************************************************");
                    Console.WriteLine("Uso de las funciones locales estaticas para sumar dos numeros.");
                    Console.WriteLine("***************************************************************");
                    Console.WriteLine("*");
                    int M()
                    {
                        Console.WriteLine("Escribe el primer numero");
                        int y = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe el segundo numero");
                        int x = int.Parse(Console.ReadLine());
                        return Add(x, y);

                        static int Add(int left, int right) => left + right;
                    }
                    int valores=M();
                    Console.WriteLine($"*Resultado obtenido con funciones locales estaticas ------------ {valores}.");
                    Console.WriteLine("***************************************************************");
                break;
                case 8:
                    Console.WriteLine("***************************************************************");
                    Console.WriteLine("Uso del menú switch aplicado a obtener un RGB de color.");
                    Console.WriteLine("***************************************************************");
                    Console.WriteLine("*");
                    var palabras = new string[]
                    {
                                    // index de inicio    index de final
                        "The",      // 0                   ^9
                        "quick",    // 1                   ^8
                        "brown",    // 2                   ^7
                        "fox",      // 3                   ^6
                        "jumped",   // 4                   ^5
                        "over",     // 5                   ^4
                        "the",      // 6                   ^3
                        "lazy",     // 7                   ^2
                        "dog"       // 8                   ^1
                    };              // 9 (or words.Length) ^0

                    Console.WriteLine("*");
                    Console.WriteLine("La palabra que debe escribir es dog");
                    Console.WriteLine($"La ultima palabra en el texto es: {palabras[^1]}");
                    //Aqui se hace una variable con multiples palabras.
                    Console.WriteLine("Aquí hacemos una variables con multiples palabras");
                    var quickBrownFox = palabras[1..4];
                    for(int i=0;i<quickBrownFox.Length;i++){
                        Console.Write($"*-------> {quickBrownFox[i]}");
                    }
                    Console.WriteLine();
                    var lazyDog = palabras[^2..^0];
                    for(int i=0;i<lazyDog.Length;i++){
                        Console.Write($"*-------> {lazyDog[i]}");
                    } 
                    Console.WriteLine();       
                    var allWords = palabras[..]; // contiene "The" hasta "dog".
                    for(int i=0;i<allWords.Length;i++){
                        Console.Write($"*-------> {allWords[i]}");
                    }
                    Console.WriteLine();
                    var firstPhrase = palabras[..4]; // contiene "The" hasta "fox".
                    for(int i=0;i<firstPhrase.Length;i++){
                        Console.Write($"*-------> {firstPhrase[i]}");
                    }
                    Console.WriteLine();
                    var lastPhrase = palabras[6..]; // contiene "the", "lazy" y "dog".
                    for(int i=0;i<lastPhrase.Length;i++){
                        Console.Write($"*-------> {lastPhrase[i]}");
                    }
                    Console.WriteLine();
                    //Declaramos rangos como variables.
                    Range frase = 1..4;
                    Console.WriteLine($"*Guardamos una rango como variable: {frase.ToString()}");
                    Console.WriteLine("*Ponemos la frase entre corchetes y lo imprimimos.");
                    var texto = palabras[frase];
                    for(int i=0;i<texto.Length;i++){
                        Console.WriteLine($"*Imprimimos la variable entre corchetes: {texto[i]}");
                    }
                    Console.WriteLine("***************************************************************");          
                
                break;
                };
            }while(seleccion!= 0);
           
        }

        //Metodo para el uso de Read Only.
        public struct Rectangulo
        {
            public double Altura { get; set; }
            public double Base { get; set; }
            public double Area => (Base * Altura);

            public readonly override string ToString() =>
                $"(Los datos de base= {Base}, Altura= {Altura}) dan como resultado el area del rectangulo= {Area} (Este metodo fue generado con read only para asegurar que no modifique datos de salida del area \n)";
            }
    
         //Metodos para el uso del switch mejorado.  
        public enum Rainbow{
            Red,
            Orange,
            Yellow,
            Green,
            Blue,
            Indigo,
            Violet
        }

        //Metodo para el uso de switch mejorado recibe un nombre de color y regresa su valor RGB
        //Utiliza el switch de la version 8.0 de C#. 
        public static RGBColor FromRainbow(Rainbow colorBand) =>
            colorBand switch
            {
                Rainbow.Red    => new RGBColor(0xFF, 0x00, 0x00),
                Rainbow.Orange => new RGBColor(0xFF, 0x7F, 0x00),
                Rainbow.Yellow => new RGBColor(0xFF, 0xFF, 0x00),
                Rainbow.Green  => new RGBColor(0x00, 0xFF, 0x00),
                Rainbow.Blue   => new RGBColor(0x00, 0x00, 0xFF),
                Rainbow.Indigo => new RGBColor(0x4B, 0x00, 0x82),
                Rainbow.Violet => new RGBColor(0x94, 0x00, 0xD3),
                _              => throw new ArgumentException(message: "invalid enum value", paramName: nameof(colorBand)),
            };
        //Metodo para realizar un menu con el switch original.
        public static void menuSwitch(){
            int seleccionSwitch;
            Console.WriteLine("*******************************************");
            Console.WriteLine("*");
            Console.WriteLine("**    [1] Color rojo                     **");
            Console.WriteLine("**    [2] Color naranja.                 **");
            Console.WriteLine("**    [3] Color amarillo.                **");
            Console.WriteLine("**    [4] Color verde.                   **");
            Console.WriteLine("**    [5] Color azul.                    **");
            Console.WriteLine("**    [6] Color indigo.                  **");
            Console.WriteLine("**    [7] Color violeta.                 **");
            Console.WriteLine("*");
            Console.WriteLine("*******************************************");
            seleccionSwitch=int.Parse(Console.ReadLine());
       
            string nombre;
             switch (seleccionSwitch){
                case 1:
                    Console.WriteLine( FromRainbow(Rainbow.Red).ToString());
                    Console.WriteLine();
                break;
                case 2:
                     Console.WriteLine(FromRainbow(Rainbow.Orange).ToString());
                     Console.WriteLine();
                break;
                case 3:
                     Console.WriteLine(FromRainbow(Rainbow.Yellow).ToString());
                     Console.WriteLine();
                break;
                case 4:
                     Console.WriteLine(FromRainbow(Rainbow.Green).ToString());
                     Console.WriteLine();
                break;
                case 5:
                     Console.WriteLine(FromRainbow(Rainbow.Blue).ToString());
                     Console.WriteLine();
                break;
                case 6:
                     Console.WriteLine(FromRainbow(Rainbow.Indigo).ToString());
                     Console.WriteLine();
                break;
                case 7:
                     Console.WriteLine(FromRainbow(Rainbow.Indigo).ToString());
                     Console.WriteLine();
                break;
                default:
                    throw new ArgumentException("Valor no valido");
            };
        }
        //Metodo para calcular la tarifa para un vehiculo.
        public static decimal CalculateTarifa(object vehicle) =>
            vehicle switch
        {
            Carro c           => 2.00m,
            Taxi t          => 3.50m,
            Autobus a           => 5.00m,
            Camion Ca => 10.00m,
            { }             => throw new ArgumentException(message: "Es un vehiculo raro", paramName: nameof(vehicle)),
            null            => throw new ArgumentNullException(nameof(vehicle))
        };    
        //Metodo para utilizar los patrones de las propiedades.
        static void patronesPropiedades()
        {
            var carro = new Carro();
            var taxi = new Taxi();
            var autobus = new Autobus();
            var camion = new Camion();

            Console.WriteLine("**********************************************");
            Console.WriteLine($"La tarifa del carro es: {CalculateTarifa(carro)}");
            Console.WriteLine($"La tarifa del taxi es: {CalculateTarifa(taxi)}");
            Console.WriteLine($"La tarifa del autobus es: {CalculateTarifa(autobus)}");
            Console.WriteLine($"La tarifa del camion es {CalculateTarifa(camion)}");
            Console.WriteLine("**********************************************");
            try
            {
                CalculateTarifa("Esto va a fallar");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Una excepcion creada por usar el tipo incorrecto de dato.");
            }
            try
            {
                CalculateTarifa(null);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Una excepcion causada por un null.");
            }
        }
        //Metodo que a traves de tuplas nos permite jugar piedra papel o tijeras.
        public static string JuegoTuplas(string jugadorUno, string jugadorDos)
        => (jugadorUno, jugadorDos) switch
        {
            ("piedra", "papel") => "A la piedra la envuelve el papel. Gana el papel; Jugador dos.",
            ("piedra", "tijeras") => "La piedra rompe tijeras. La piedra gana; Jugador uno.",
            ("papel", "piedra") => "El papel envuelve la piedra. Gana el papel; Jugador uno.",
            ("papel", "tijeras") => "Al papel lo cortan las tijeras. Ganan tijeras; Jugador dos.",
            ("tijeras", "piedra") => "A las tijeras las rompe la piedra. Ganan piedras; Jugador dos.",
            ("tijeras", "papel") => "Las tijeras cortan papel. Ganan tijeras; Jugador uno.",
            (_, _) => "Es un empate."
        };
        //Metodo que nos apoya para el uso de los patrones posicionales que tiene una enumeración de las posiciones. 
        public enum Quadrant
        {
            Desconocido,
            Origen,
            Uno,
            Dos,
            Tres,
            Cuatro,
            Borde
        }    
        //Metodo que nos apoya para el uso de los patrones posicionales.
        static Quadrant GetQuadrant(Point point) => point switch
        {
            (0, 0) => Quadrant.Origen,
            var (x, y) when x > 0 && y > 0 => Quadrant.Uno,
            var (x, y) when x < 0 && y > 0 => Quadrant.Dos,
            var (x, y) when x < 0 && y < 0 => Quadrant.Tres,
            var (x, y) when x > 0 && y < 0 => Quadrant.Cuatro,
            var (_, _) => Quadrant.Borde,
            _ => Quadrant.Desconocido
        };
        //Metodo para usar Using escribiendo un archivo, escribe todos los numeros con excepcion de segundo.
        static int EscribeLineasEnArchivo(IEnumerable<string> lines)
        {
            using var file = new System.IO.StreamWriter("Lineas1.txt");
            // Notice how we declare skippedLines after the using statement.
            int skippedLines = 0;
            foreach (string line in lines)
            {
                if (!line.Contains("Segundo"))
                {
                    file.WriteLine(line);
                }
                else
                {
                    skippedLines++;
                }
            }
            // La variable skipped lines aun esta en el alcance.
            return skippedLines;
            // El archivo muere aquí.
        }
    
        
    }



    
}

    
    

   

