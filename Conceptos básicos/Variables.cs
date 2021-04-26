using System;

namespace ConceptosBásicos
{
    public class Variables
    {
        void TiposDeVariables()
        {
            ///Hay varios tipos de variables en C#

            sbyte a = -127; //Cualquier número entero de 8 bits (sbyte = signed byte)
            byte b = 255; //número entero positivo de 8 bits 
            short c = 32767; //Cualquier número entero de 16 bits
            ushort d = 65535;//número entero positibo de 16 bits; (ushort = unsigned short)
            int e = 2147483647; //Cualquier número entero de 32 bits
            uint f = 4294967295; //número entero positivo de 32 bits (uint = unsigned int)
            long g = -9223372036854775808; //Cualquier número entero de 64 bits
            ulong h = 18446744073709551615; //número entero positibo de 64 bits (ulong = unsigned long)

            double i = 2.5; //Cualquier número decimal de 8 bytes (±5.0 * 10^−324 a ±1.7 * 10^308)
            float j = 9.125f; /*Cualquier número decimal de 4 bytes (±1.5 * 10^−45 a ±3.4 * 10^38)
                          Se coloca una f después del número para indicar que es float */
            decimal k = 1.2m; /*Cualquier número decimal de 16 bytes (±1.0 * 10^-28 a ±7.9228 * 10^28).
                          Se coloca una m despues del número para indicar que es decimal*/


            char l = '\n'; //Un carácter. Su valor debe colocarse entre comillas simples
            string m = ""; //Una cadena de caracteres. Su valor debe colocarse entre comillas dobles

            bool n = true; //un valor verdadero-falso

            var o = "hola";/* El tipo "var" es una variable que puede contener cualquier tipo de información, sin embargo debes darles un valor al declararlas
                        a diferencia del resto de variables*/

        }

        void NombrandoMiVariable()
        {
            /* Las variables pueden tener letras, números y guiones bajos en su nombre. Sin embargo no puede empezar con un número.
             * Los nombres de c# son case sensitive, esto quiere decir que "int variable;" no es la misma variable que "int Variable;"
             * Se recomienda que escojas un nombre descriptivo, de esta forma sabras lo que hay en la variable
             */

            string Nombre = "Paul"; /*Este es un nombre descriptivo para una variable, sin embargo se recomienda iniciar las variables con minuscula (o un guion
                                bajo si el argumento de una función tiene el mismo nombre que una variable)*/

            string abc = "McCartney"; /*Este es un nombre poco descriptivo, de esta manera te costará más trabajo saber que hay en esa variable,
                                   lo mejor aquí es: string apellido = "McCartney"*/

            int edad = 70; /*Dado que la edad siempre es positiva y no mayor a 255 usar byte podría ahorrarte 75% del espacio que usarias con int o uint,
                         aunque int es mucho más usado para evitar confundir los datos*/

            bool isAlive = true; /*Este es un nombre descriptivo, sin embargo esta en un idioma diferente al resto de las variables, algo no muy recomendado.
                            Para mantener un orden lo mejor es que todas tus variables esten en un mismo idioma*/

            string nombreCompleto = Nombre + abc; /*En C# se utiliza CamelCase para unir dos palabras en un nombre, es decir cuando quieres poner un nombre con
                                               más de una palabra, deberás separarlas poniendo en mayúscula la primer letra de cada palabra
                                               exceptuando la primera*/
        }

        void DeclarandoUnaVariable()
        {

            /*Para declarar una variable primero se coloca un tipo de variable, luego el nombre que le darás seguido por el signo igual,
             finalmente puedes colocar el valor que le darás (exceptuando el tipo var). 
            No olvides que en C# todas las instrucciones se cierran con un punto y coma*/

            var datos; //<- eso dará un error
            string información;//<- eso es correcto 
            int paletas = 90; //<- eso es correcto
            float 2dineros = 2.3f; //<- eso dará un error

            //Puedes declarar varias variables juntas si son del mismo tipo (excluyendo el tipo var)

            int x, y;
            decimal a = 99.7m, b = 0.03m, c = 3.002m;
        }
    }
}