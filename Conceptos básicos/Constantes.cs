using System;
using System.Collections.Generic;
using System.Text;

namespace Conceptos_básicos
{
    public class Constantes
    {
        /// A veces necesitarás utilizar un mimo valor varias veces, para eso se declara una constante
        /// El valor de una constante no puede ser modificado por lo qué debes declararla con un valor inicial

        public void DeclarandoUnaConstante()
        {
            //Para declarar una constante agrega la palabra clave const antes de una variable

            const string holaMundo = "Hello world";
            const int entero = 92;
            const bool esVerda = false;

            //Intentar cambiar el valor de una constante después de declararla causara un error
            entero = 99; //error
        }
    }
}
