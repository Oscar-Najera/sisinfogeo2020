using System;

namespace ExamenParcial_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Red redPatito;
            redPatito=Inicializa();
            imprimirReporte(redPatito);
        }

        static Red Inicializa(){
            Red redPatito = new Red("Red Patito, S.A. de C.V.","Mr Pato Macdonald","Av. Princeton 123, Orlando Florida");
            Nodo servidor1= new Nodo("192.168.0.10","servidor",5,10,"linux");
            Nodo equipoActivo1= new Nodo("192.168.0.12","equipo activo",2,12,"ios");
            Nodo computadora1= new Nodo("192.168.0.20","computadora",8,5,"windows");
            Nodo servidor2= new Nodo("192.168.0.15","servidor",10,22,"linux");
            Vulnerabilidad vulnerabilidad1= new Vulnerabilidad("CVE-2015-1635","microsoft","HTTP.sys permite a atacantes remotos ejecutar código arbitrario","remota","14/04/2015");
            Vulnerabilidad vulnerabilidad2= new Vulnerabilidad("CVE-2017-0004","microsoft","El servicio LSASS permite causar una denegación de servicio","local","01/10/2019");
            Vulnerabilidad vulnerabilidad3= new Vulnerabilidad("CVE-2017-3847","cisco","Cisco Firepower Management Center XSS","remota","21/02/2017");
            Vulnerabilidad vulnerabilidad4= new Vulnerabilidad("CVE-2009-2504","microsoft","Múltiples desbordamientos de enteros en APIs Microsoft .NET 1.1","local","13/11/2009");
            Vulnerabilidad vulnerabilidad5= new Vulnerabilidad("CVE-2016-7271","microsoft","Elevación de privilegios Kernel Segura en Windows 10 Gold","local","20/12/2016");
            Vulnerabilidad vulnerabilidad6= new Vulnerabilidad("CVE-2017-2996","adobe","Adobe Flash Player 24.0.0.194 corrupción de memoria explotable","remota","15/02/2017");

            //Añadimos los nodos a la red
            redPatito.agregarNodo(servidor1);
            redPatito.agregarNodo(equipoActivo1);
            redPatito.agregarNodo(computadora1);
            redPatito.agregarNodo(servidor2);
            redPatito.ListaNodos[0].AgregaVulnerabilidad(vulnerabilidad1);
            redPatito.ListaNodos[0].AgregaVulnerabilidad(vulnerabilidad2);
            redPatito.ListaNodos[1].AgregaVulnerabilidad(vulnerabilidad3);
            redPatito.ListaNodos[2].AgregaVulnerabilidad(vulnerabilidad4);
            redPatito.ListaNodos[2].AgregaVulnerabilidad(vulnerabilidad5);
            redPatito.ListaNodos[2].AgregaVulnerabilidad(vulnerabilidad6);
            
            return redPatito;
        }

        static void imprimirReporte(Red redImprimir){
            Console.WriteLine($">> Datos generales de la red: \n Empresa: {redImprimir.Empresa}. \n Propietario: {redImprimir.Propietario}. \n Domicilio: {redImprimir.Domicilio}.");
            Console.WriteLine($"\tTotal nodos en la red: {redImprimir.obtenerTotalNodos()}.");
            foreach(Nodo nodo in redImprimir.ListaNodos){
                redImprimir.obtenerTotalVulnerabilidades(nodo);
            }
            Console.WriteLine($"\tTotal vulnerabilidades en la red {redImprimir.TotalVulnerabilidades}.");
            Console.WriteLine($">> Datos generales de los nodos de la red: ");
            foreach (Nodo nodo in redImprimir.ListaNodos){
                Console.WriteLine($" Ip: {nodo.DireccionIp}, Tipo: {nodo.Tipo}, Puertos: {nodo.Puertos}, Saltos: {nodo.Saltos}, SO:  {nodo.SistemaOperativo}, Total vulnerabilidades: {nodo.obtenerTotalVulnerabilidades()}. ");
            }
            redImprimir.obtenerNumeroMayorSalto();
            redImprimir.obtenerNumeroMenorSalto();
            Console.WriteLine($"\t Mayor número de saltos: {redImprimir.MayorSalto}");
            Console.WriteLine($"\t Mayor número de saltos: {redImprimir.MenorSalto}");
                
            Console.WriteLine($">> Vulnerabilidades por nodo: ");
            foreach (Nodo nodo in redImprimir.ListaNodos)
            {
                Console.WriteLine($"Ip: {nodo.DireccionIp}, Tipo: {nodo.Tipo}.");  
                Console.WriteLine($"Vulnerabilidades: "); 

                foreach(Vulnerabilidad vln in nodo.ListaVulnerabilidades){
                    Console.WriteLine($"Clave: {vln.Clave}, Vendedor: {vln.Vendedor}, Descripcion: {vln.Descripcion}, Tipo: {vln.Tipo}, Fecha: {vln.Fecha}, Antiguedad: {vln.Antiguedad}.");
                }
                if(nodo.ListaVulnerabilidades.Count==0){
                        Console.WriteLine("No tiene vulnerabilidades.");
                }
                  
            }
            
           
            
        }




    }
}
