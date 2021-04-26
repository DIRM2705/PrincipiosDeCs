using System;
using System.Collections.Generic;
using System.Text;

namespace ConceptosBásicos
{
    public class EntradaYSalida
    {
        public void MostrandoTexto()
        {
            ///Mostrar texto en la consola de C# es muy sencillo
            Console.Write(""); /*Este comando te permitirá escribir en la última linea activa de la consola*/

            Console.WriteLine(""); /*Este comando te permite añadir un salto de linea (Como el enter) antes de empezar a escribir */

            //Ejemplo 1

            Console.Write("Hello "); //No olvides el espacio de lo contrario se juntaran ambas palabras
            Console.Write("World");

            //Salida del ejemplo 1: Hello World

            //Ejemplo 2

            Console.Write("Hello");
            Console.WriteLine("World");

            /*Salida del ejemplo 2: Hello 
                                    World*/

            ///Puedes escribir más cosas que solo texto. Cómo números o valores booleanos (verdadero-falso). Además de variables.

            //Ej 1
            var miSalida = "Hello world";
            Console.WriteLine(miSalida);
            //Salida: "Hello world"

            //Ej 2
            int x = 10, y = 5;
            Console.WriteLine(x + y);
            //Salida: 15

            ///Puedes incluso crear una cadena de texto con formato
            ///
            Console.WriteLine("{0} + {1} = {2}", x, y, x + y); 
            /*{0} hace referencia a la primer variable (argumento) después de la coma. En este caso a la x
             *{1} hace referencia a la segunda variable (argumento) después de la primer coma. En este caso la y
             *{2} hace referencia al tercer argumento. En este caso x + y*/

            //Salida: 10 + 5 = 15
        }

        public void ObteniendoEntradaDelUsuario()
        {
            ///Hay dos formas de leer una entrada de texto del usuario
            
            /*1.*/ Console.Read(); /*Este comando leera todo lo que escribas en la consola y no te permite agregar más lineas de entrada*/
            /*2*/ Console.ReadLine(); /*Este comando leera todo lo que escribas en la linea activa de la consola y te permite agregar más lineas de entrada*/

            /*El más recomandado para usar es Console.ReadLine(), por lo que me enfocaré en este. Sin embargo puedes encontrar información sobre 
            Console.Read() en https://docs.microsoft.com/en-us/dotnet/api/system.console.read?view=net-5.0 */

            ///Para obtener la entrada necesitamos una variable donde guardarla
            
            float entrada;

            entrada = Console.ReadLine(); //Pero esto va a generar un error. Porque Console.ReadLine() da un string como resultado.

            ///La solución es la siguiente

            entrada = Convert.ToSingle(Console.ReadLine()); /*Deberás usar alguno de los metodos Convert.ToXXX.
                                                            En este caso nececito un decimal de 4 bytes por lo que usaré Convert.ToSingle(),
                                                            pero puedes colocar el tipo de variable que tu necesites*/
        }
    }
}
