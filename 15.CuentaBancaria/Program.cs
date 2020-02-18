using System;

namespace _14.CuentaBancaria
{
    class Program
    {
        static void PruebaCuentaBancaria(string[] args)
        {
            CuentaBancaria chelines=new CuentaBancaria(1000);
            Console.WriteLine($"Saldo a crear {chelines.Saldo}");
            chelines.Deposita(500);
            Console.WriteLine($"Saldo despues del domingo {chelines.Saldo}");
            if(chelines.Retira(600)){
                Console.WriteLine($"Saldo despues de la peda {chelines.Saldo}");
            }else{
                Console.WriteLine("No puedes andar organizando fiestas si no tienes dinero");
            }
        }

        static void pruebaCliente(){
            //Creamos dos objetos de tipo cliente
            Cliente cliente1= new Cliente("Juan Perez");
            Cliente cliente2= new Cliente("Maria Lopez");
            Cliente cliente3=new Cliente("Mario Lopez");
            //Crea un objeto de tipo cuenta
            //Creo un objeto de tipo Cliente y le asigno una cuenta creada.
            CuentaBancaria cuenta1=new CuentaBancaria(100);
            //Asigno directamente una nueva CuentaBancaria al cliente existente
            cliente1.Cuenta=cuenta1;
            cliente1.Cuenta.Deposita(500);
            
            cliente2.Cuenta=new CuentaBancaria(200);
            cliente3.Cuenta=cliente2.Cuenta;
            cliente2.Cuenta.Retira(50);
            cliente3.Cuenta.Deposita(100);

            Console.WriteLine($"Cliente {cliente1.Nombre} tiene un saldo de {cliente1.Cuenta.Saldo}");
            Console.WriteLine($"Cliente {cliente2.Nombre} tiene un saldo de {cliente2.Cuenta.Saldo}");
            Console.WriteLine($"Cliente {cliente3.Nombre} tiene un saldo de {cliente3.Cuenta.Saldo}");
            
        }

        static void Main(){
            Banco miBanco = new Banco("Mis chelines","Carlos Ricon");

            miBanco.AgregarCliente(new Cliente("Genaro Borrego"));
            miBanco.AgregarCliente(new Cliente("Arturo Romo"));
            miBanco.AgregarCliente(new Cliente("Ricardo Monreal"));
            miBanco.AgregarCliente(new Cliente("Amalia Garcia"));
            miBanco.AgregarCliente(new Cliente("Miguel Alonso"));
            miBanco.AgregarCliente(new Cliente("Alejandro Tello"));

            miBanco.Clientes[0].Cuenta=new CuentaBancaria(15000);
            miBanco.Clientes[1].Cuenta=new CuentaBancaria(25000);
            miBanco.Clientes[2].Cuenta=new CuentaBancaria(35000);
            miBanco.Clientes[3].Cuenta=new CuentaBancaria(45000);
            miBanco.Clientes[4].Cuenta=new CuentaBancaria(55000);
            miBanco.Clientes[5].Cuenta=new CuentaBancaria(65000);

            miBanco.Clientes[2].Cuenta.Retira(15000);
            miBanco.Clientes[5].Cuenta.Retira(25000);
            miBanco.Clientes[3].Cuenta.Deposita(25000);

            foreach(Cliente cte in miBanco.Clientes){
                Console.WriteLine($"Cliente: {cte.Nombre}, Saldo: {cte.Cuenta.Saldo}");
            }

        }
            
    }
}
