using System;

namespace ExamenParcial_1
{
    class Vulnerabilidad{
        //Variables
        private string clave;
        private string vendedor;
        private string descripcion;
        private string tipo;
        private string fecha;
        private int antiguedad;

        //Constructores
        public Vulnerabilidad(){
            clave="";
            vendedor="";
            descripcion="";
            tipo="";
            fecha="";
            antiguedad=0;
        }
        //Constructor con todos los datos dados.
        public Vulnerabilidad(string clave, string vendedor, string descripcion, string tipo, string fecha){
            this.clave=clave;
            this.vendedor=vendedor;
            this.descripcion=descripcion;
            this.tipo=tipo;
            this.fecha=fecha;
            calcularAntiguedad();    
        }

        //Metodos set y get:
        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }
        public string Vendedor
        {
            get { return vendedor; }
            set { vendedor = value; }
        }
         public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
         public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
         public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public int Antiguedad{
            get{ return antiguedad; }
        }

        //Método que nos permite calcular la antiguedad de la vulnerabilidad.
        private int calcularAntiguedad(){
            DateTime fechaVulnerabilidad= DateTime.ParseExact(fecha,"dd/MM/yyyy",null);
            DateTime fechaActual= DateTime.Now;
            int añoInicio, añoFin;
            añoInicio=fechaVulnerabilidad.Year;
            añoFin=fechaActual.Year;
            antiguedad=añoFin-añoInicio;
            return antiguedad;
        }


    }
}