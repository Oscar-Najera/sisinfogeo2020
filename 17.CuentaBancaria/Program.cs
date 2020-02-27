using System;
using System.IO;

namespace _14.CuentaBancaria
{
    [Serializable()]
    class Program
    {
        static void Inicializa(Banco banco){
            banco.AgregarCliente(new Cliente("Juan Isidro"));
            banco.AgregarCliente(new Cliente("Santiago Esparza"));
            banco.AgregarCliente(new Cliente("Juan Villa"));
            banco.AgregarCliente(new Cliente("Perla Velasco"));
            banco.AgregarCliente(new Cliente("Luis Fernando"));
            banco.AgregarCliente(new Cliente("Carlos Castañeda"));

            banco.Clientes[0].AgregaCuenta(new CuentaDeAhorro(1000,0.5));
            banco.Clientes[0].AgregaCuenta(new CuentaDeCheques(1000,200));
            
            banco.Clientes[1].AgregaCuenta(new CuentaDeAhorro(2000,0.3));
            banco.Clientes[2].AgregaCuenta(new CuentaDeAhorro(2000,0.3));
            banco.Clientes[2].AgregaCuenta(new CuentaDeAhorro(5000,0.2));
            banco.Clientes[3].AgregaCuenta(new CuentaDeAhorro(600,0.5));
            banco.Clientes[3].AgregaCuenta(new CuentaDeAhorro(5000,0.3));
            
            banco.Clientes[3].AgregaCuenta(new CuentaDeCheques(1200,300));
            banco.Clientes[5].AgregaCuenta(new CuentaDeCheques(120000,1300));
            banco.Clientes[5].AgregaCuenta(new CuentaDeAhorro(5000,0.6));
            
            banco.Clientes[4].AgregaCuenta(banco.Clientes[5].Cuentas[0]);

            banco.Clientes[5].Cuentas[0].Retira(90000);
        }

        static void Reporte(Banco banco){
            //Console.Clear();
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"{banco.Nombre}");
            Console.WriteLine("Reporte mensual de saldos");
            Console.WriteLine("------------------------------------");
            foreach(Cliente cte in banco.Clientes){
                Console.WriteLine($"{cte.Nombre}");
                foreach(CuentaBancaria cta in cte.Cuentas){
                    if(cta is CuentaDeAhorro){
                        (cta as CuentaDeAhorro).CalcularInteres();
                    }
                    Console.WriteLine(cta is CuentaDeCheques?"Cheques: ":"Ahorro: ");
                    Console.WriteLine(cta.Saldo);
                }
                Console.WriteLine($"Total de cuentas: {cte.Cuentas.Count}\n");
            }
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Cantidad de clientes: {banco.Clientes.Count}");

            


        }
        static void Main(){
            string archivo="datos";
            Banco miBanco=null;
            if(!File.Exists(archivo)){
            miBanco = new Banco("La mina de oro","Carlos Castaneda");
            Inicializa(miBanco);
            util.Grabar(archivo,miBanco);
            Console.WriteLine("--------------- Datos grabados -----------------");
            }else{
                miBanco= new Banco();
                //miBanco=util.Cargar(archivo,miBanco);
                util.Cargar(archivo, ref miBanco);
            }
            Reporte(miBanco);

        }
            
    }
}
