using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_11
{
    public class Video38ConcatDemo
    {
        public void Ejemplo()
        {
            //**********************************************//
            //                                              //
            Console.WriteLine("**PARA VER LOS VALORES HAY QUE DEBUGGEAR**");

            int[] A = { 1, 2, 3 };

            int[] B = { 4, 5, 6 };

            int[] C = { 1, 2 };

            Console.WriteLine("//**********************************************//");
            Console.WriteLine("**Ejemplo 1**");
            IEnumerable<int> resultado = A.Concat(B);

            Console.WriteLine("//**********************************************//");
            Console.WriteLine("**Ejemplo 2**");
            IEnumerable<int> resultado2 = A.Concat(C);

            // Nota: no existe sintaxis de query para este código.
        }
    }
}
