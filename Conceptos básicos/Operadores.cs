using System;
using System.Collections.Generic;
using System.Text;

namespace Conceptos_básicos
{
    //Un operador es un simbolo que te efectua operaciones lógicas o matemáticas
    public class Operadores
    {
        void OperadoresAritmeticos()
        {
            //C# soporta los siguientes operadores aritméticos

            // Operador       Simbolo  Forma
            //  Adición          +      x + y
            // Sustracción       -      x - y
            // Multiplicación    *      x * y
            //División           /      x / y
            // Módulo            %      x % y

            //La división divide el primer valor entre el segundo. Si ambos valores son enteros, se descarta todo el residuo para regresar otro valor entero
            //Ej.
            int x = 10 / 4;

            //Resultado : 2

            //Advertencia: La división entre 0 no esta definida, de efectuarse creasheará el programa

            //El operador módulo es informalmente conocido como residuo porque devuelve el residuo de cualquier división entre enteros
            //Ej.
            x = 27 % 4;
            //Resultado 3

            //Jerarquía de operaciones
            //En C# la jerarquía de operaciones afecta a la operación que efectues. 
            /*El orden es:
             () parentesís
            * / multíplicación y división
            + - suma y resta*/

            //Por lo que
            x = 25 + 9 * 2;
            //Resultado 43

            x = (25 + 9) * 2;
            //Resultado 68
        }

        void OperadoresDeAsignación()
        {
            float x = 5; //El signo igual en esta linea es un operador de asignación. Asigna el 5 a la variable x

            /*Los operadores de asignación compuestos modifican el valor de una variable tomando en cuenta su valor inicial
            Se hacen a partir del signo igual y un operador aritmético*/

            //Ejemplos

            x += 2; //Eso es lo mismo que x = x + 2

            x *= 5;  //Eso es lo mismo que x = x * 5

            x /= 7; //Eso es lo mismo que x = x / 7
        }

        void OperadoresDeIncrementoYDecremento()
        {
            float x = 0;
            //Este operador incrementa o decrementa en uno el valor de la variable
            //Hay dos formas de usarlo. Cómo prefijo o sufijo.

            //En la forma prefijo primero se cambia el valor de la variable y después se toma el valor

            //Ejemplo
            float y = ++x; //y = 1, x = 1


            //En la forma sufijo primero se toma el valor de la variable y después se cambia el valor

            float z = x--; //z = 0, x = -1
        }
    }
}
