using System;
using System.Diagnostics;
using System.Linq;
using System.Collections;


namespace _36.Sistema01
{
    //Ejemplo de información del sistema y los procesos.
    class Program
    {
        static void Main(string[] args)
        {
            //Procesamos los argumentos pasados al programa.
            Console.WriteLine("----------- Programa 36 Información del sistema -----------");
            if(args.Length < 1) Menu();
            else{
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                switch(int.Parse(args[0])){
                    case 1: InfoSistema(); break;
                    case 2: Procesos(); break;
                    case 3: ProcesoActual(); break;
                    case 4: HilosyModulos(int.Parse(args[1])); break;
                    default: Console.WriteLine("Opción invalida ..."); break;
                }
                Console.ForegroundColor=ConsoleColor.White;
            }
        }

        static void Menu(){
            //Menú de opciones.
            Console.Clear();
            Console.ForegroundColor=ConsoleColor.Blue;
            Console.WriteLine("[-] Menú: Procesos, hilos, modulos \n");
            Console.WriteLine("[-] Información del sistema ....................... [1].");
            Console.WriteLine("[-] Visualizar los procesos del sistema ....................... [2].");
            Console.WriteLine("[-] Visualizar el proceso actual ....................... [3].");
            Console.WriteLine("[-] Ver hilos y modulos de un proceso dado ....................... [4].");
            Console.ForegroundColor=ConsoleColor.Black;
        }

        static void InfoSistema(){
            //Obtener la información del sistema.
            Console.WriteLine($"Número de procesadores  : {Environment.ProcessorCount}");
            Console.WriteLine($"Usuario activo          : {Environment.UserName}");
            Console.WriteLine($"Dot Net.Core versión    : {Environment.Version}");
            Console.WriteLine($"Versión de SO           : {Environment.OSVersion}");
            Console.WriteLine($"Nombre de la máquina    : {Environment.MachineName}");
            Console.WriteLine($"El sistema es de 64 bits? {Environment.Is64BitOperatingSystem}");
            Console.WriteLine($"Directorio actual       : {Environment.CurrentDirectory}");
            Console.WriteLine($"Unidades lógicas        : {Environment.GetLogicalDrives().Count()}");
            foreach(string drv in Environment.GetLogicalDrives()) Console.WriteLine($"drv");
            Console.WriteLine($"\n Variables de entorno :{Environment.GetEnvironmentVariables().Count}");
            foreach(DictionaryEntry var in Environment.GetEnvironmentVariables()) Console.Write($"{var.Key,-35}={var.Value}\n");
        }

        static void Procesos(){
            //Obtener y listar todos los procesos del sistema.
            var procesos=(from proc in Process.GetProcesses()orderby proc.ProcessName select proc).ToList();
            Console.WriteLine($"Procesos del sistema    :{procesos.Count}");
            procesos.ForEach(p=>Console.WriteLine($"{p.Id}{p.ProcessName}"));
            Console.WriteLine();
        }

        static void ProcesoActual(){
            //Obtener y listar el proceso actual.
            var pa=Process.GetCurrentProcess();
            Console.WriteLine("El proceso que se ejecuta actualmente:");
            Console.WriteLine($"{pa.Id}, {pa.ProcessName}, {pa.StartTime}\n");
        }

        static void HilosyModulos(int proceso){
            //Obtener los threads y modules de un proceso.
            //Aquí dependera de los procesos listados en el sistema donde se ejecuta.
            try{
                //Obtenemos el proceso por el ID dado.
                Process pr= Process.GetProcessById(proceso);
                Console.WriteLine($"\n Información de un proceso: ");
                Console.WriteLine($"{pr.Id}, {pr.ProcessName}");

                //Obtener hilos del proceso en cuestión.
                ProcessThreadCollection hilos=pr.Threads;
                Console.WriteLine($"\n >> Hilos en esté proceso: {hilos.Count}");
                foreach(ProcessThread hilo in hilos){
                    Console.WriteLine($"{hilo.Id}, {hilo.ThreadState}, {hilo.StartTime}, {hilo.PriorityLevel}.");
                }

                //Módulos.
                ProcessModuleCollection modulos=pr.Modules;
                Console.WriteLine("\n >> Módulos en el proceso: ");
                foreach(ProcessModule mod in modulos){
                    Console.WriteLine($"{mod.ModuleName}");
                }
            }
            catch(ArgumentException err){
                Console.WriteLine(err.Message);
            }
        }

    }
}
