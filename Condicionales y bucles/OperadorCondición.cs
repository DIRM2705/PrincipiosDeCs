using System;
using System.Collections.Generic;
using System.Text;

namespace Condicionales_y_bucles
{
    class OperadorCondición
    {
        /* El operador de condición te permite hacer pequeñas decisiones sencillas en una sola linea de código
         * Es útil cuando quieres que el valor de una variable dependa de factores externos
         * 
         * Su sintáxis será Condición ? valor1 : valor2
         * Notar que el signo de interrogación y los dos puntos son muy importantes
         */

        void OpCondición()
        {
            int edad;
            DateTime Cumpleaños = new DateTime(DateTime.Today.Year,3,2);

            edad = DateTime.Today > Cumpleaños ? 16 : 15; //Sí ya pasó la fecha de cumpleaños la edad será 16, sí no será 15

            //Para ilustrarlo mejor podemos ver esto como un if

            edad =
                DateTime.Today > Cumpleaños ? //if(DateTime.Today > Cumpleaños)
                    16 //edad = 16
                    : //else
                    15; // edad = 15
        }
    }
}
