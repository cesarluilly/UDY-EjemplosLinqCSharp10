using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_11
{
    public class Video39SequenceEqualDemo
    {
        public void Ejemplo()
        {
            //**********************************************//
            //                                              //
            Console.WriteLine("**PARA VER LOS VALORES HAY QUE DEBUGGEAR**");

            string[] A = { "felipe", "fernando" };

            string[] B = { "felipe", "fernando" };

            string[] C = { "FEliPE", "FernandO" };

            string[] D = { "fernando", "felipe" };

            //                                              //Ejemplo 1
            bool AB = A.SequenceEqual(B);

            //                                              //Ejemplo 2
            bool AC = A.SequenceEqual(C);

            //                                              //Ejemplo 3 (Ignora mayusculas y minusculas)
            bool ACSinImportarMayusculas = 
                A.SequenceEqual(C, StringComparer.OrdinalIgnoreCase);

            //                                              //Ejemplo 4
            bool AD = A.SequenceEqual(D);

            // Nota: no existe sintaxis de query para este código.
        }
    }
}
