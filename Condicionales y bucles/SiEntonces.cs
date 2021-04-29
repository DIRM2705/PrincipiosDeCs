using System;
using System.Collections.Generic;
using System.Text;

namespace Condicionales_y_bucles
{
    public class SiEntonces
    {
        int aux = 2 +2;
        void ifElse()
        {
            //El comando Si-Entonces es la forma que C# tiene para comprobar soluciones
            //La forma de este comando es:

            if (aux == 4) //if con la condición a evaluar entre parentesís
            {//abre corchete, es muy importante ya que entre este corechete y el que lo cierre se coloca lo que se ejecuta si la condición es cierta
                Console.WriteLine(true); //Código a ejecutar si la condición es cierta
            }
            else//else, después de cerrar el corchete anterior
            {//abre corechete, nuevamente es muy importante.
                Console.WriteLine(false);// Código a ejecutar si la condición es falsa
            }
        }

        void ifElseIf()
        {
            //El comando Si-Sino si te permite verificar entre diferentes condiciones
            if(/*Aquí va la primer condición*/)
            {

            }
            else if(/*Aquí va la segunda concición*/)
            {

            }
            else if(/*Aquí va la tercera condición*/)
            {

            }
            else
            {
                 //Si ninguna de las condiciones se cumple se ejecuta este código
            }

        }
    }
}
