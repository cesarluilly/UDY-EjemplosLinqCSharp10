using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_6
{
    public class Video25ContainsDemo
    {
        public void Ejemplo()
        {
            //**********************************************//
            //                                              //
            Console.WriteLine("**PARA VER LOS VALORES HAY QUE DEBUGGEAR**");

            IEnumerable<int> numeros = Enumerable.Range(1, 5);

            bool estaElNumero3 = numeros.Contains(3);

            bool estaElNumero20 = numeros.Contains(20);

        }
    }
}
