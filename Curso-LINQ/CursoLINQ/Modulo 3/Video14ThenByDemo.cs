using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_3
{
    public class Video14ThenByDemo
    {
        public void Ejemplo()
        {
            //**********************************************//
            //                                              //
            Console.WriteLine("**PARA VER LOS VALORES HAY QUE DEBUGGEAR**");

            List<Persona> personas = new List<Persona>() {
new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
new Persona { Nombre = "Alejandro", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
new Persona { Nombre = "Valentina", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
};
            //                                              //Para hacer un ordenamiento por 2 atributos distintos, 
            //                                              //    primero hay que utilizar OrderBy y despues 
            //                                              //    ThenBy

            Console.WriteLine("**Ejemplo 1**");
            //                                              //Sintaxis de metodo
            //                                              //Ordenando por Edad y Nombre
            IEnumerable<Persona> personasOrdenadasPorEdad = personas.OrderBy(x => x.Edad).ThenByDescending(x => x.Nombre);

            foreach (var persona in personasOrdenadasPorEdad)
            {
                Console.WriteLine($"{persona.Nombre} tiene {persona.Edad} años de edad");
            }

            //                                              //Sintaxis de queries

            IEnumerable<Persona> personasOrdenadasPorEdad_2 = from p in personas
                                             orderby p.Edad, p.Nombre descending
                                             select p;
        }
    }
}
