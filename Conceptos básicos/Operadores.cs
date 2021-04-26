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
    }
}
