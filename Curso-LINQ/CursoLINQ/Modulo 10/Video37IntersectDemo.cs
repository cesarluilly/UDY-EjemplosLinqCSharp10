using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_10
{
    public class Video37IntersectDemo
    {
        public void Ejemplo()
        {
            //**********************************************//
            //                                              //
            Console.WriteLine("**PARA VER LOS VALORES HAY QUE DEBUGGEAR**");

            List<Persona> personasA = new List<Persona>() {
                            new Persona { Nombre = "Eduardo", EmpresaId = 1, },
                            new Persona { Nombre = "Nidia",  EmpresaId = 1 },
                            new Persona { Nombre = "Esmerlin", EmpresaId = 3 }
                            };

            List<Persona> personasB = new List<Persona>()
                                {
                                    new Persona{Nombre = "Fernando", Edad = 25},
                                    new Persona { Nombre = "Eduardo", EmpresaId = 1, },
                                };

            int[] A = { 1, 2, 3 };

            int[] B = { 1, 15 };

            Console.WriteLine("//**********************************************//");
            Console.WriteLine("**Ejemplo 1**");
            IEnumerable<int> numerosQueEstanEnAyB = A.Intersect(B);

            Console.WriteLine("//**********************************************//");
            Console.WriteLine("**Ejemplo 2**");
            IEnumerable<String> personasBNombres = personasB.Select(x => x.Nombre);

            IEnumerable<Persona> personasQueEstanEnAyB = personasA.IntersectBy(personasBNombres, x => x.Nombre);

        }
    }
}
