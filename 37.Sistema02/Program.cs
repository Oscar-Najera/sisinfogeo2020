using System;
using System.Net;
using System.Net.NetworkInformation;

namespace _37.Sistema02
{
    //Ejemplo de información de la red.
    class Program
    {
        static void Main(string[] args)
        {
            //Procesamos los argumentos del usuario.
            Console.WriteLine("----------- Programa 37 Información de red -----------");
            if(args.Length<1) Menu();
            else{
                Console.ForegroundColor=ConsoleColor.Red;
                switch(int.Parse(args[0])){
                    case 1: Ping("www.google.com"); break;
                    case 2: DnsAndIPLocal(); break;
                    case 3: InterfacesRed(); break;
                    default: Console.WriteLine("Opción invalida ..."); break;
                }
                Console.ForegroundColor=ConsoleColor.Black;
            }
        }
        //Método para hacer el menú
        static void Menu(){
            Console.Clear();
            Console.ForegroundColor=ConsoleColor.Blue;
            Console.WriteLine("[-] Menú de opciones operaciones de red \n");
            Console.WriteLine("[-] Hacer un ping a google.com ...................... [1]");
            Console.WriteLine("[-] Obtener nombre de host e ip de mi máquina  ...................... [2]");
            Console.WriteLine("[-] Obtener interfaces de red de mi máquina ...................... [3]");
            Console.ForegroundColor=ConsoleColor.Black;        
        }
        //Método que nos permite hacer un Ping a un sitio web.
        static void Ping(string ipaddr){
            Ping ping=new Ping();
            Console.WriteLine("Haciendo un ping a google.com");
            PingReply reply=ping.Send(ipaddr,1000);
            Console.WriteLine($"Respuesta: {reply.Status.ToString()}");
        }

        //Método que nos permite obtener la ip local y el dns.
        static void DnsAndIPLocal(){
            string hostname= Dns.GetHostName();
            string ip = Dns.GetHostEntry(hostname).AddressList[0].ToString();
            Console.WriteLine($"Nombre del host : {hostname}.");
            Console.WriteLine($"Ip del host : {ip}.");
        }

        //Método que nos permite obtener las interfaces de red de la pc.
        static void InterfacesRed(){
            NetworkInterface[] interfaces= NetworkInterface.GetAllNetworkInterfaces();
            Console.WriteLine($"Interfaces wireless o ethernet: ");
            foreach(NetworkInterface interfaz in interfaces){
                if(interfaz.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 ||
                    interfaz.NetworkInterfaceType == NetworkInterfaceType.Ethernet){
                        Console.Write($"{interfaz.Id.ToString(),-8}");
                        Console.Write($"{interfaz.NetworkInterfaceType.ToString(),-10}");
                        Console.Write($"{interfaz.GetPhysicalAddress().ToString(),-13}");
                        UnicastIPAddressInformationCollection uniIPs= interfaz.GetIPProperties().UnicastAddresses;
                        foreach(UnicastIPAddressInformation ip in uniIPs)
                            Console.Write($"{ip.Address.ToString(),-30}");
                            Console.WriteLine();
                    }
            }
        }

    }
}
