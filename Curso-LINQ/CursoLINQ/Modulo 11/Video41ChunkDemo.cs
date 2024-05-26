using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_11
{
    public class Video41ChunkDemo
    {
        public void Ejemplo()
        {
            //**********************************************//
            //                                              //
            Console.WriteLine("**PARA VER LOS VALORES HAY QUE DEBUGGEAR**");

            int[] A = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //                                              //Vamos a dividir la coleccion en subColecciones de 3
            //                                              //    elementos cada subColeccion.
            IEnumerable<int[]> resultado = A.Chunk(3);

            // Nota: no existe sintaxis de query para este código.
        }
    }
}
