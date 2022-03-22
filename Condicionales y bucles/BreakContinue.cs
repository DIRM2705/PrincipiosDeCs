using System;
using System.Collections.Generic;
using System.Text;

namespace Condicionales_y_bucles
{
    class BreakContinue
    {
        /* Break y continue son dos de las instrucciones más importantes cuando hablamos de bucles.
         * Estas instrucciones nos permitirán detener las repeticiones o saltarnos casos específicos repectivamente.
         * Suelen ser muy usadas para evitar casos o ahorrarnos tiempo al ejecutar un programa
         */

        void Break()
        {
            /* El uso de la instrucción break es muy sencillo,
             * Cuando se quiere detener un bucle y pasar a las siguientes instrucciones se coloca break;
             * Suele estar acompañada de un if que determine bajo que condiciones deberás terminar el bucle
             */

            while(true)
            {
                Console.WriteLine("Escribe 1 para parar");
                if(Console.ReadLine() == "1")
                {
                    break; //Sí escribiste un 1 entonces detener el bucle
                }
            }

            Console.WriteLine("Se detuvo el bucle while");
        }

        void Continue()
        {
            /* La instrucción continue nos servirá para saltarnos una iteración del bucle
             * Al igual que break, la instrucción continue también suele estar acompañada de un if que determine bajo que condiciones
             * deberías saltarte una iteración
             */

            for(int i = 0; i < 10; i++)
            {
                if(i%2 == 0)
                {
                    continue; //Sí i es un número par saltarte esta iteración
                }

                Console.WriteLine(i);
            }

            //Salida del código:
            //1,3,5,7,9 
        }
    }
}
