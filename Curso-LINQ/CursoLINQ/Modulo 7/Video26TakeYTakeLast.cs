using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_7
{
    public class Video26TakeYTakeLast
    {
        public void Ejemplo()
        {
            //**********************************************//
            //                                              //
            Console.WriteLine("**PARA VER LOS VALORES HAY QUE DEBUGGEAR**");

            IEnumerable<int> numeros = Enumerable.Range(1, 100);

            List<int> primeros10Numeros = numeros.Take(10).ToList();

            List<int> ultimos10Numeros = numeros.TakeLast(10).ToList();

            //                                              //Sintaxis de queries
            IEnumerable<int> primeros10Numeros_2 = (from n in numeros
                                       select n).Take(10);
        }
    }
}
