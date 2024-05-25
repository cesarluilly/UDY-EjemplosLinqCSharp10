using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_2
{
    public class Video9LastDemo
    {
        public void Ejemplo()
        {
            //**********************************************//
            //                                              //
            Console.WriteLine("**PARA VER LOS VALORES HAY QUE DEBUGGEAR**");
            var personas = new List<Persona>() {
            new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
            new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
            new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
            new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
            new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
            };

            //**********************************************//
            Console.WriteLine("**Ejemplo 1: **");

            //                                              //Funciona de forma similar que first o firstOrDefault, 
            //                                              //    solo que aqui se refiere al ultimo elemento.
            //                                              //En cuanto a last, en caso de no encontrar un valor va a
            //                                              //    tronar.
            Persona ultimaPersona = personas.Last();
            Persona ultimaPersona2 = personas.LastOrDefault();
            Persona ultimaPersonaSoltera = personas.Last(p => p.Soltero);

            // Sintaxis de queries
            Persona ultimaPersonaSoltera_2 = (from p in personas
                                          where p.Soltero
                                          select p).Last();
        }
    }
}
