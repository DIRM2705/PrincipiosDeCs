using System;
using System.Collections.Generic;
using System.Text;

namespace Condicionales_y_bucles
{
    public class BucleWhile
    {
        bool x = true;
        //El bucle while ejecuta una acción mientras que cierta condición sea verdadera

        void whileDo()
        {
            //primero se comprueba si la condición es verdadera
            while (x)
            {
                //Si la expresión es verdadera se ejecuta lo qu se encuentre entre corchetes
                //depués se vuelve a comprobar si la expresión es verdadera si lo es se vuelve a ejecutar
            }
        }

        //El bucle Do-while ejecuta una acción y la repetira si una condición es verdadera

        void DoWhile()
        {
            do
            {
                //Se ejecuta esta acción
            }
            while (x); //Se realiza una comprobación, si la condición es verdadera se vuelve a ejecutar la acción anterior
        }

    }
}
