using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_11
{
    public class Video40ZipDemo
    {
        public void Ejemplo()
        {
            //**********************************************//
            //                                              //
            Console.WriteLine("**PARA VER LOS VALORES HAY QUE DEBUGGEAR**");

            int[] A = { 1, 2, 3 };
            int[] B = { 4, 5, 6 };

            //**********************************************//
            Console.WriteLine("//**********************************************//");
            Console.WriteLine("**Ejemplo 1**");
            //                                              //Zip devuelve una coleccion de tuplas
            IEnumerable<(int First, int Second)> combinados = A.Zip(B);

            foreach ((int First, int Second) combinacion in combinados)
            {
                Console.WriteLine($"({combinacion.First}, {combinacion.Second})");
            }

            Console.WriteLine("//**********************************************//");
            Console.WriteLine("**Ejemplo 2 (Realizo una operacion con la info de cada tupla)**");
            //                                              //Entre la informacion de cada tupla, yo puedo
            //                                              //    realizar una operacion.
            IEnumerable<int> resultado = A.Zip(B, (a, b) => a * b);





            
            // Nota: no existe sintaxis de query para este código.
        }
    }
}
