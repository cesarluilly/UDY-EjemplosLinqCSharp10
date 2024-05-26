using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_7
{
    public class Video28Paginacion
    {
        public void Ejemplo()
        {
            //**********************************************//
            //                                              //
            Console.WriteLine("**PARA VER LOS VALORES HAY QUE DEBUGGEAR**");

            IEnumerable<int> numeros = Enumerable.Range(1, 100);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Página {i}");

                IEnumerable<int> paginado = numeros.Paginar(i, 10);
                foreach (var item in paginado)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }

    public static class IEnumerableExtensions
    {
        //                                                  //Metodo de extension que me va a permitir la logica de 
        //                                                  //    paginacion a cualquier IEnumerable de cualquier tipo
        //                                                  //    (Generico)
        public static IEnumerable<T> Paginar<T>(this IEnumerable<T> coleccion, int pagina, int tamañoLote)
        {
            return coleccion.Skip((pagina - 1) * tamañoLote).Take(tamañoLote);
        }
    }
}
