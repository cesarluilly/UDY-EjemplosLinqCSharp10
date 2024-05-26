using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_5
{
    public class Video22Agregado
    {
        public void Ejemplo()
        {
            //**********************************************//
            //                                              //
            Console.WriteLine("**PARA VER LOS VALORES HAY QUE DEBUGGEAR**");

            IEnumerable<int> numeros = Enumerable.Range(1, 5);

            //                                              //Con la operacion de agregado podemos realizar una operacion
            //                                              //    entre cada uno de los elementos de la coleccion.

            //                                              //Los parametros "a" y "b" representan 2 elementos de
            //                                              //    la coleccion
            int resultado = numeros.Aggregate((a, b) => a * b); // 1*2*3*4*5

            Console.WriteLine("Resultado es " + resultado);

            //                                              //Tambien yo puedo utilizar una semilla o un seed,
            //                                              //    osea que le puedo agregar un valor inicial al calculo
            //                                              //Por ejemplo vamos a decirle que yo quiero iniciar con un 10
            //                                              //    por lo tanto sera 10*1*2*3*4*5
            int resultadoConValorInicial = numeros.Aggregate(10, (a, b) => a * b);

            Console.WriteLine("El resultado con el valor semilla es: " + resultadoConValorInicial);
        }
    }
}
