using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_10
{
    public class Video34DistinctDemo
    {
        public void Ejemplo()
        {
            //**********************************************//
            //                                              //
            Console.WriteLine("**PARA VER LOS VALORES HAY QUE DEBUGGEAR**");

            List<Persona> personas = new List<Persona>() {
                            new Persona { Nombre = "Eduardo", EmpresaId = 1, },
                            new Persona { Nombre = "Nidia",  EmpresaId = 1 },
                            new Persona { Nombre = "Eduardo"},
                            new Persona { Nombre = "Esmerlin", EmpresaId = 3 }
                            };

            int[] numeros = { 1, 2, 3, 1, 1, 6 };
            //                                              //Sintaxis de metodo

            //                                              //Sacamos nueva coleccion de numeros sin repeticiones
            IEnumerable<int> numerosSinRepeticiones = numeros.Distinct();

            //                                              //DistincBy me trae el primer objeto que encuentra dado el
            //                                              //    nombre sin repeticiones,
            //                                              //Aunque sus otras propiedades sean diferentes, me trae solo
            //                                              //    el primero.
            IEnumerable<Persona> personasSinNombresRepetidos = personas.DistinctBy(x => x.Nombre);








            //                                              //Sintaxis de queries
            var numerosSinRepeticiones_2 = from n in numeros.Distinct()
                                           select n;

            var personasSinNombresRepetidos_2 = from p in personas.DistinctBy(x => x.Nombre)
                                                select p;
        }
    }
}
