using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_7
{
    public class Video27SkipYSkipLast
    {
        public void Ejemplo()
        {
            //**********************************************//
            //                                              //
            Console.WriteLine("**PARA VER LOS VALORES HAY QUE DEBUGGEAR**");

            var numeros = Enumerable.Range(1, 100);

            //                                              //Del 1 al 10
            var primeros10Numeros = numeros.Take(10).ToList();

            //                                              //Del numero 11 al 20
            var segundoLoteDe10 = numeros.Skip(10).Take(10).ToList();

            //                                              //Del 91 al 100
            var ultimos10Numeros = numeros.TakeLast(10).ToList();

            //                                              //Del 81 al 90
            var penultimoLote = numeros.SkipLast(10).TakeLast(10).ToList();
        }
    }
}
