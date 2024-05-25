using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_3
{
    public class Video13OrderByDemo
    {
        public void Ejemplo()
        {
            //**********************************************//
            //                                              //
            Console.WriteLine("**PARA VER LOS VALORES HAY QUE DEBUGGEAR**");

            List<Persona> personas = new List<Persona>() {
    new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
    new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
    new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
    new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
    new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
};

            //**********************************************//
            Console.WriteLine("");
            Console.WriteLine("**Ejemplo 1**");
            IEnumerable<Persona> personasOrdenadasPorEdad = personas.OrderByDescending(x => x.Edad);
            foreach (Persona persona in personasOrdenadasPorEdad)
            {
                Console.WriteLine($"{persona.Nombre} tiene {persona.Edad} años de edad");
            }


            //**********************************************//
            Console.WriteLine("");
            Console.WriteLine("**Ejemplo 2**");
            int[] numeros = { 1, 5, 12, 2, 3, 111, 6 };
            foreach (int numero in numeros.OrderBy(x => x))
            {
                Console.WriteLine(numero);
            }

            //                                              //Sintaxis de queries
            IEnumerable<int> numeros_2 = from n in numeros
                                         //                 //Por defecto el OrderBy es ascendente
                            orderby n
                            select n;

            IEnumerable<Persona> personasOrdenadasPorEdad_2 = from p in personas
                                             orderby p.Edad descending
                                             select p;
        }
    }
}
