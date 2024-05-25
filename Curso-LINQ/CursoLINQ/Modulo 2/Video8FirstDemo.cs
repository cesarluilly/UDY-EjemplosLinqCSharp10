using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_2
{
    //==================================================================================================================
    public class Video8FirstDemo
    {
        //--------------------------------------------------------------------------------------------------------------
        public void Ejemplo()
        {
            Console.WriteLine("**PARA VER LOS VALORES HAY QUE DEBUGGEAR**");

            var personas = new List<Persona>() {
                new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
                new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
                new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
                new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
                new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
            };

            //**********************************************//
            Console.WriteLine("**Ejemplo 1: Probando cuando el arreglo tiene valores**");

            //                                              //First: En caso de que el arreglo este vacio, va a mandar
            //                                              //    un error .
            Persona primeraPersona = personas.First();

            //                                              //FirstOrDefault: En caso de que el arreglo este vacio, me
            //                                              //    va el valor por defecto del elemento que estemos
            //                                              //    iterando y sobre todo de lo que estemos proyectando.
            //                                              //Por ejemplo para enteros su valor por defecto es 0.
            //                                              //Por ejemplo para strings su valor por defecto es null.
            Persona primeraPersona2 = personas.FirstOrDefault();

            //**********************************************//
            Console.WriteLine("**Ejemplo 2: Probando cuando el arreglo esta vacio **");

            var paises = new List<string>();
            try
            {
                //                                          //Va a mandar un error ya que el arreglo esta vacio.
                var primerPais = paises.First();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ha ocurrido un error");
            }

            //                                              //Va a mandar el valor por defecto, en este caso sera null.
            var primerPais2 = paises.FirstOrDefault();

            //**********************************************//
            Console.WriteLine("**Ejemplo 3: Probando con el valor por default de un entero**");
            var numeros = new List<int>();
            var primerNumero = numeros.FirstOrDefault();

            //**********************************************//
            Console.WriteLine("**Ejemplo 4: Sintaxis Metodo y Sintaxis Query**");
            var primeraPersonaNoSoltera = personas.FirstOrDefault(p => !p.Soltero);

            // Sintaxis de queries
            var primeraPersonaNoSoltera_2 = (from p in personas
                                             where !p.Soltero
                                             select p).FirstOrDefault();
        }
    }
}
