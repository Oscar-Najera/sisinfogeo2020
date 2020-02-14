namespace ej1{
using System;

    class empleado{

        //Miembros de la clase.
        private string nombre;

        private int edad;

        //Constructor(es)
        public empleado(){

        }

        public empleado(string nombre, int edad){
            this.nombre=nombre;
            this.edad=edad;
        }

        //Propiedades de la clase (Utiles para enviar y recibir valores).
        public string Nombre{
            get { return nombre ; }
            set { nombre= value ; }
        }
        
        public int Edad {
            get {return edad;}
            set {edad=value;}
        }

        //Metodo de clase
        public string Vacaciones(DateTime ini, int dias){
            DateTime fin;
            fin=ini.AddDays(dias);
            return fin.ToString("dd/MM/yy");

        }

        // Sobrecargamos el metodo toString heredado de la clase Base(Object)
        public override string ToString(){
            return $"Nombre: {nombre}, Edad: {edad}";
        }

    }
}

