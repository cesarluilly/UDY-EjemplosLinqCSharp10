using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_10
{
    public class Video35UnionDemo
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

            int[] numerosA = { 1, 2, 3, 1, 1, 6 };

            int[] numerosB = { 1, 2, 15 };

            //                                              //Con union podemos unir 2 coleciones y eliminar los 
            //                                              //    duplicados

            Console.WriteLine("**Ejemplo 1**");
            IEnumerable<int> unionDeNumeros = numerosA.Union(numerosB);

            Console.WriteLine("**Ejemplo 2 (Nuevo de C# 10)**");
            //                                              //En este caso se van a unir 2 colecciones de objetos, 
            //                                              //    pero si hay duplicados en base al "Nombre", 
            //                                              //    se va a tomar el primero de la primer lista
            IEnumerable<Persona> unionDePersonas = personasA.UnionBy(personasB, x => x.Nombre);

        }
    }
}
