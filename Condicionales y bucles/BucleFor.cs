using System;
using System.Collections.Generic;
using System.Text;

namespace Condicionales_y_bucles
{
    class BucleFor
    {
        /*
         * Un bucle for repetirá un conjunto de acciones mientras una variable inicial cumpla con determinada condición
         * 
         * La sintáxis será
         * 
         * for(variable inicial; condición; incremento de la variable incial después de cada iteración)
         * {
         *      Instrucciones();
         * } 
         */

        void Bucle_For()
        {
            //Para i con valor inicial de 0 mientras que i sea menor que 10, realizar el bloque de operaciones, luego sumar 1 a i
            for (int i = 0; i < 10; i++) //Recuerda el ; después del valor inicial y la condición
            { //i solo es el nombre de una variable que podrás usar dentro de este bucle
                Console.WriteLine(i);
            }
        }
    }
}
