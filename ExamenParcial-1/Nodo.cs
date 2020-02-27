using System;
using System.Collections.Generic;

namespace ExamenParcial_1{
    class Nodo{
        //Variables.
        private string direccionIp;
        private string tipo;
        private int puertos;
        private int saltos;
        private string sistemaOperativo;
        private List<Vulnerabilidad> listaVulnerabilidades;
        
        
        //Constructores.
        //Constructor vacio.
        public Nodo(){
            direccionIp="";
            tipo="";
            puertos=0;
            saltos=0;
            sistemaOperativo="";
            listaVulnerabilidades=new List<Vulnerabilidad>();
        }
        //Constructor con datos.
        public Nodo(string direccionIp, string tipo, int puertos, int saltos, string sistemaOperativo){
            this.direccionIp=direccionIp;
            this.tipo=tipo;
            this.puertos=puertos;
            this.saltos=saltos;
            this.sistemaOperativo=sistemaOperativo;
            listaVulnerabilidades=new List<Vulnerabilidad>();
        }

        //Metodos Set y Get
        public string DireccionIp
        {
            get { return direccionIp; }
            set { direccionIp = value; }
        }
        public string Tipo {
            get {return tipo;}
            set {tipo=value; }
        }
        public int Puertos {
            get { return puertos; }
            set { puertos= value; }
        }
        public int Saltos {
            get { return saltos; }
            set { saltos= value; }
        }
        public string SistemaOperativo {
            get { return sistemaOperativo; }
            set { sistemaOperativo= value; }
        }

        //Metodo que nos permite agregar una vulnerabilidad a la lista creada.
        public void AgregaVulnerabilidad(Vulnerabilidad vuln){
            listaVulnerabilidades.Add(vuln);
        }
        //Metodo que nos permite consultar la lista de vulnerabilidades.
        public List<Vulnerabilidad> ListaVulnerabilidades
        {
            get { return listaVulnerabilidades;}
        }
        //Metodo que nos permite eliminar vulnerabilidades de la lista con un numero dado.
        public void eliminarVulnerabilidad(int numeroVulnerabilidad){
            listaVulnerabilidades.RemoveAt(numeroVulnerabilidad);
        }    
        //Método que nos permite obtener la cantidad de vulnerabilidades que existen en el nodo.
        public int obtenerTotalVulnerabilidades(){
            int cantidadVulnerabilidades;
            cantidadVulnerabilidades=listaVulnerabilidades.Count;
            return cantidadVulnerabilidades;
        }
        

    }
}