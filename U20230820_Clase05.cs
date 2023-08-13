using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
          //DECLARACION DE VARIABLES

          //Declaracion de variables de tipo texto con captura desde consola

          string? universidad="";

          //Declaracion variable de tipo texto con asignacion desde el codigo

          string facultad="Ingenieria y Arquitectura";
          string profesion="Ingenieria en Desarrollo de Software";

          //Declaracion de variable entera captura desde consola

          int anioIngreso=0;

          //Declaracion de variable entera asignando valores
          int edadIngreso=23;
          int edadEgreso=27;

          //Declaracion de variable double  asignando valor desde consola

          double coutaUniversidad=0.0;

          //Declaracion de variable decimales asingando valores
          double gastosTrasporte=35.50;

          ///CAPTURA DE DATOS DESDE CONSOLA

          Console.WriteLine("\n*****************************************************");
          Console.WriteLine("\n-----Captura datos de tipo texto -----");
          Console.WriteLine("\nIngrese el nombre de la universidad donde estudia >> ");
          universidad=Convert.ToString(Console.ReadLine());
          Console.WriteLine("\n-----Fin de captura de tipo texto -----\n");

          Console.WriteLine("\n-----Capturando datos de tipo entero -----\n");
          Console.WriteLine("Ingrese el año que inicio la universidad >> ");
          anioIngreso=Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("\n-----Fin de captura de tipo entero -----\n");

          Console.WriteLine("\n-----Capturando datos de tipo decimal -----\n");
          Console.WriteLine("Ingrese la couta de la univerisidad >> ");
          coutaUniversidad=Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("\n-----Capturando datos de tipo decimal -----\n");
          Console.WriteLine("\n*****************************************************");

          //IMPRESION DE DATOS  EN CONSOLA
          Console.WriteLine("*****************************************************\n\n");
          Console.WriteLine("\n-----IMPRESION DE DATOS DE TIPO TEXTO -----");
          Console.WriteLine("\n La Universidad en la universidad >> " +universidad);
          Console.WriteLine("\nPertenece a la facultad de >> " + facultad);
          Console.WriteLine("\n Estudiando la carerra de  >> " + profesion);
          Console.WriteLine("\n*****************************************************\n");

          Console.WriteLine("*****************************************************\n\n");
          Console.WriteLine("\n-----IMPRESION DE DATOS DE TIPO ENTERO -----");
          Console.WriteLine("\n El año que ingreso a la  universidad fue >> " + anioIngreso);
          Console.WriteLine("\n La edad cuando inicio sus estudios es  >> " + edadIngreso +" años");
          Console.WriteLine("\n La edad cuando finalize sus estudios sera >> " + edadEgreso +" años");
          Console.WriteLine("\n*****************************************************\n");

          Console.WriteLine("*****************************************************\n\n");
          Console.WriteLine("\n-----IMPRESION DE DATOS DE DOUBLE -----");
          Console.WriteLine("\n La cuota de su universidad es  >> " +"$"+ coutaUniversidad);
          Console.WriteLine("\n La su gasto en trasporte es   >> " +"$"+ gastosTrasporte);
          Console.WriteLine("\n*****************************************************\n");

          Console.ReadKey();
      
          








      






          




           

        
        }
    }
}