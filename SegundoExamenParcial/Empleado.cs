using System;

namespace SegundoExamenParcial
{
    public class Empleado
    {
        //Crear un objeto de clase Empleado.cs con los campos de datos a leer (rfc,nombre,area,salario)
        public string Rfc{get;set;}
        public string Nombre{get;set;}
        public string Area{get;set;}
        public double Salario{get;set;}

        public override string ToString()=> $"{Rfc}, {Nombre}, {Area}, {Salario}";
      
    }
}
