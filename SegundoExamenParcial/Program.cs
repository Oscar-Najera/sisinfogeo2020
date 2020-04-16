using System;
using System.IO; // Libreria para StreamREader y StreamWriter
using CsvHelper; // Libreria para trabajar con archivos cvs
using System.Collections.Generic;
using System.Globalization;
using System.Linq; 

namespace SegundoExamenParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------- Segundo Examen Parcial -----------");
            List<Empleado> datos = new List<Empleado>();
            List<Empleado> jubilados=new List<Empleado>();
            Console.WriteLine();
            datos=Leer("datos.csv");
            Console.WriteLine("||| ------------------------- |||");
            Console.WriteLine("||| Datos de los trabajadores |||");
            Console.WriteLine("||| ------------------------- |||");
             //Leer desde un archivo externo (datos.csv) los datos de prueba y en una lista (List<Empleado>)
            datos.ForEach(r=>Console.WriteLine(r.ToString()));


            // Agregar a la lista desde el código los datos adicionales

            datos.Add(new Empleado{Rfc="VECJ880326XXX",Nombre="Venustiano Carranza",Area ="Recursos Humanos",Salario=554692.52});
            datos.Add(new Empleado{Rfc="ARML526326TOG",Nombre="Armin Lopez",Area ="Contabilidad",Salario=50000.50});
            jubilados.Add(new Empleado{Rfc="ARML526326TOG",Nombre="Armin Lopez",Area ="Contabilidad",Salario=50000.50});
            datos.Add(new Empleado{Rfc="PASI878966WLE",Nombre="Pedro Santoyo",Area ="Informatica",Salario=19922.99});
            jubilados.Add(new Empleado{Rfc="PASI878966WLE",Nombre="Pedro Santoyo",Area ="Informatica",Salario=19922.99});
            datos.Add(new Empleado{Rfc="EZIS881254TRW",Nombre="Elizabeth Isabel",Area ="Mercadotecnia",Salario=2052.78});
            datos.Add(new Empleado{Rfc="ALTIR478826WER",Nombre="Arely Torres",Area ="Administracion",Salario=4532.56});
            jubilados.Add(new Empleado{Rfc="ALTIR478826WER",Nombre="Arely Torres",Area ="Administracion",Salario=4532.56});

            //Grabar todos los datos en un archivo externo (nomina.csv)

            Grabar(datos,"nomina.csv");

            Imprimir(datos);
            
            ImprimirNombre(datos);

            ImprimirSalario(datos);

            ImprimirSalarioMayor3500(datos);
            
            ImprimirRFC77(datos);

            ImprimirJubilados(jubilados);
            
            ImprimirPorArea(datos);

        }

        //Leer desde un archivo externo (datos.csv) los datos de prueba y en una lista (List<Empleado>)
        public static List<Empleado> Leer(string file){
            using (var reader= new StreamReader(file))
            using (var cvs= new CsvReader(reader,CultureInfo.InvariantCulture))
            {
                cvs.Configuration.HasHeaderRecord=false;
                cvs.Read();
                var registros= cvs.GetRecords<Empleado>().ToList();
                return registros;

            }
        }

        public static void Grabar(List<Empleado> registros, string archivo){
            using (var writer = new StreamWriter(archivo))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture)){
                csv.WriteRecords(registros);
            }
        }
        //Método que nos permite imprimir la lista en el orden original.
        public static void Imprimir(List<Empleado> registros){
            Console.WriteLine();
            Console.WriteLine("----------- Lista en orden original -----------");
            registros.ForEach(registros=>Console.WriteLine(registros.ToString()));
            Console.WriteLine();
        }

        //Método que nos permite imprimir la lista por orden alfabetico de nombre.
        public static void ImprimirNombre(List<Empleado> nomina){
            Console.WriteLine("----------- Lista ordenada por nombre -----------");
            var n1=(from emp in nomina orderby emp.Nombre select emp).ToList();
            n1.ForEach(emp=>Console.WriteLine(emp.ToString()));
            Console.WriteLine();
        }
        //Metodo que nos permite imprimir la lista por salario.
        public static void ImprimirSalario(List<Empleado> nomina){
            Console.WriteLine("----------- Lista ordenada por salario -----------");
            var n1=(from emp in nomina orderby emp.Salario select emp).ToList();
            n1.ForEach(emp=>Console.WriteLine(emp.ToString()));
            Console.WriteLine();
        }

        //Método que nos permite imprimir la lista de las personas con salario > 3000.
        public static void ImprimirSalarioMayor3500(List<Empleado> nomina){
            Console.WriteLine("----------- Lista ordenada de aquellas personas que ganan más de 3000 ----------");
            var n1=(from emp in nomina orderby emp.Salario where emp.Salario>3500 select emp).ToList();
            n1.ForEach(emp=>Console.WriteLine(emp.ToString()));
            Console.WriteLine();
        }

        //Método que nos permite imprimir la lista de las personas que contienen 77 en su RFC
        public static void ImprimirRFC77(List<Empleado> nomina){
            Console.WriteLine("----------- Personas con 77 en su RFC -----------");
            var n1=(from emp in nomina orderby emp.Rfc where emp.Rfc.Contains("77") select emp).ToList();
            n1.ForEach(emp=> Console.WriteLine(emp.ToString()));
            Console.WriteLine();
        }




        //Método que nos permite imprimir la lista de las personas agrupadas por área
        public static void ImprimirPorArea(List<Empleado> nomina){
            Console.WriteLine("----------- Lista ordenada por área de trabajo -----------");
            var n1=(from emp in nomina group emp by emp.Area);
            foreach (var area in n1){
                Console.WriteLine("***"+area.Key+"***");
                foreach(var emp in area){
                    Console.WriteLine(emp.ToString());
                }
            } 
        }
        //Método que nos permite comparar los datos entre la lista de jubilados y la nomina
        public static void ImprimirJubilados(List<Empleado> jubilados){
            Console.WriteLine();
            Console.WriteLine("----------- Lista de jubilados en nomina -----------");
            var n1 =(from emp in jubilados select emp).ToList();
            n1.ForEach(emp=>Console.WriteLine(emp.ToString()));
            Console.WriteLine();
        }

    }
    
}
