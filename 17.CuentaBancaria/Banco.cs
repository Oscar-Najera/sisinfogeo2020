using System;
using System.Collections.Generic;

namespace _14.CuentaBancaria{
    [Serializable()]
    class Banco{
        private string nombre;
        private string propietario;
        private List<Cliente> clientes;

        public Banco(){
            clientes=new List<Cliente>();
        }


        public Banco(string nombre, string propietario){
            this.nombre=nombre;
            this.propietario=propietario;
            clientes=new List<Cliente>();
        }
        public String Nombre{
            get{return nombre;}
            set{nombre=value;}
        }
        public String Propietario{
            get{return propietario;}
            set{nombre=propietario;}
        }
        public void AgregarCliente(Cliente cte){
            clientes.Add(cte);
        }
        public List<Cliente> Clientes{
            get{return clientes;}
        }
       
    }
}