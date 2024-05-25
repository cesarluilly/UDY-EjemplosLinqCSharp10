using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_6
{
    public class ContainsDemo
    {
        public void Ejemplo()
        {
            //**********************************************//
            Console.WriteLine("**PARA VER LOS VALORES HAY QUE DEBUGGEAR**");

            var numeros = Enumerable.Range(1, 5);

            var estaElNumero3 = numeros.Contains(3);

            var estaElNumero20 = numeros.Contains(20);

        }
    }
}
