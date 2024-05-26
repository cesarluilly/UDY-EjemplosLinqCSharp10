using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_7
{
    public class Video29TakeWhileSkipWhile
    {
        public void Ejemplo()
        {
            //**********************************************//
            //                                              //
            Console.WriteLine("**PARA VER LOS VALORES HAY QUE DEBUGGEAR**");

            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 3, 2, 1 };

            Console.WriteLine("**Ejemplo TakeWhile**");
            //                                              //Yo quiero tomar los elementos de esta coleccion mientras
            //                                              //    dicho elemento sea menor que 5 pero a partir
            //                                              //    ya no quiero tomar mas elementos y esto lo hace la 
            //                                              //   funcion TakeWhile(es decir, yo voy a tomar los primeros
            //                                              //   elementos que cumplan con ese predicado, y a a partir
            //                                              //   de ese momento donde el predicado sea falto) y partir
            //                                              //    de ahi quiero ignorar el resto de la colxion
            // Tomar los elementos mientras el predicado sea true.
            // A partir de que el predicado sea falso, dejar de tomar elementos.
            List<int> resultadoTakeWhile = numeros.TakeWhile(x => x < 5).ToList();




            Console.WriteLine("**Ejemplo SkipWhile**");
            //                                              //Yo quiero saltarme cada elemento de esta coleccion mientras
            //                                              //    dicho elemento sea menor que 5, y a partir del primer
            //                                              //    elemento que no cumpla la condicion, a partir de ahi
            //                                              //    tomo todos los elementos hacia adelante.
            // Saltarse los elementos mientras el predicado sea true.
            // A partir de que el predicado sea falso, tomar todo lo que sigue.
            List<int> resultadoSkipWhile = numeros.SkipWhile(x => x < 5).ToList();
        }
    }
}
