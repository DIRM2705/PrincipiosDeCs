using System;
using System.Collections.Generic;
using System.Text;

namespace Condicionales_y_bucles
{
    public class Switch
    {
        //la estructura switch te permite saltar directamente a una lista de opciones

        void EstructuraSwitch()
        {
            //cada opción de la estructura switch se llama case y la variable se compara entre cada una de ellas

            int x = 0;

            switch (x) //entre parentesís se coloca la variable que debes comparar
            {
                case 0: //Recuerda colocar dos puntos después de la opción para indicar donde comienzan las acciones de ese caso
                    Console.WriteLine("is 0");
                    break; //Este break es muy importante, ya que le indica al programa dónde terminan las acciones para cada caso
                case 1:
                    Console.WriteLine("is 1");
                    break;
                case 2:
                    Console.WriteLine("is 2");
                    break;
                case 3:
                    Console.WriteLine("is 3");
                    break;
                default: //default es lo que se ejecutara si el valor de la variable no se encuentra en la lista de opciones
                    Console.WriteLine("Undefined number");
                    break;
            }
        }
    }
}
