using System;
using System.Collections.Generic;

namespace ExamenParcial_1{
    class Red{
        private string empresa;
        private string propietario;
        private string domicilio;
        private List<Nodo> listaNodos;
        private int totalNodos;
        private int totalVulnerabilidades;
        private int mayorSalto;
        private int menorSalto;
        

        //Constructores.
        //Constructor vacio.
        public Red(){
            empresa="";
            propietario="";
            domicilio="";
            mayorSalto=0;
            menorSalto=0;
            listaNodos=new List<Nodo>();
            totalNodos=0;
            totalVulnerabilidades=0;
        }
        //Constructor con datos.
        public Red(string empresa,string propietario, string domicilio){
            this.empresa=empresa;
            this.propietario=propietario;
            this.domicilio=domicilio;
            listaNodos=new List<Nodo>();
            totalNodos=0;
            totalVulnerabilidades=0;
        }

        public string Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }
        public string Propietario
        {
            get { return propietario; }
            set { propietario = value; }
        }
        public string Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }
        public int TotalNodos
        {
            get { return totalNodos; }
            set { totalNodos = value; }
        }
        public int MayorSalto
        {
            get { return mayorSalto; }
        }
        public int MenorSalto
        {
            get { return menorSalto; }
        }
        public int TotalVulnerabilidades
        {
            get { return totalVulnerabilidades; }
            set { totalVulnerabilidades = value; }
        }
        public List<Nodo> ListaNodos{
            get {return listaNodos; }
        }
        //Método que nos permite agregar un nuevo nodo a la lista de la red.
        public void agregarNodo(Nodo nodo){
            listaNodos.Add(nodo);
        }
        //Método que nos permite eliminar un nodo dado de la lista.
        public void eliminarNodo(int nodo){
            listaNodos.RemoveAt(nodo);
        }
        //Método que nos permite obtener el total de nodos en la red.
        public int obtenerTotalNodos(){
            return totalNodos=listaNodos.Count;
        }
        //Método que nos permite conocer cuantas vulnerabilidades tiene un  sistema.
        public void obtenerTotalVulnerabilidades(Nodo nodo){
            foreach(Vulnerabilidad vln in nodo.ListaVulnerabilidades){
                totalVulnerabilidades+=1;
            }
        }
        //Método que nos permite obtener el numero del mayor salto en la red.
        public void obtenerNumeroMayorSalto(){
            foreach(Nodo nodoTemporal in listaNodos){
                if(nodoTemporal.Saltos>mayorSalto){
                    mayorSalto=nodoTemporal.Saltos;
                }else{
                    //Es mayor el actual.
                }
            }
        }
        //Método que nos permite obtener el numero del menor salto en la red.
        public void obtenerNumeroMenorSalto(){
            //Para asignar un valor de la lista a menor.
            foreach(Nodo nodoTemporal in listaNodos){
                menorSalto=nodoTemporal.Saltos;
            }
            foreach (Nodo nodoTemporal in listaNodos)
            {
                if (nodoTemporal.Saltos<menorSalto)
                {
                    menorSalto=nodoTemporal.Saltos;
                }else
                {
                    //El menor es el actual.
                }
            }
        }


    }
}