﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_8
{
    public class Video30GroupByDemo
    {
        public void Ejemplo()
        {
            //**********************************************//
            //                                              //
            Console.WriteLine("**PARA VER LOS VALORES HAY QUE DEBUGGEAR**");

            List<Persona> personas = new List<Persona>() {
                new Persona { Nombre = "Eduardo",Edad = 19, Soltero = true },
                new Persona { Nombre = "Nidia", Edad = 25, Soltero = true },
                new Persona { Nombre = "Alejandro", Edad = 30, Soltero = true },
                new Persona { Nombre = "Valentina", Edad = 17, Soltero = false },
                new Persona { Nombre = "Roberto", Edad = 18, Soltero = true },
                new Persona { Nombre = "Eugenia", Edad = 27, Soltero = false },
                new Persona { Nombre = "Esmerlin", Edad = 45, Soltero = false }
                };

            
            Console.WriteLine("**//**********************************************//**");
            Console.WriteLine("**Ejemplo 1. Agrupar personas por si son solteras o no**");
            //                                              //Agrupar personas por si son solteras o no
            IEnumerable<IGrouping<bool, Persona>> agrupamientoPorSolteria = 
                personas.GroupBy(p => p.Soltero);

            foreach (IGrouping<bool, Persona> item in agrupamientoPorSolteria)
            {
                //                                          //Calculo el Count a traves del Key que genera el agrupamiento
                Console.WriteLine($"Grupo de las personas donde Soltero = {item.Key} (Total: {item.Count()})");

                //                                          //Itero los elementos de un agrupamiento actual
                foreach (var persona in item)
                {
                    Console.WriteLine($"- {persona.Nombre}");
                }
            }

            Console.WriteLine("**//**********************************************//**");
            Console.WriteLine("**Ejemplo 2. Agrupar personas por si son solteras o no**");
            //                                              //Sintaxis de queries
            var agrupamientoPorSolteria_2 = from p in personas
                                           group p by p.Soltero into grupos
                                           select grupos;

            foreach (var item in agrupamientoPorSolteria_2)
            {
                //                                          //Calculo el Count a traves del Key que genera el agrupamiento
                Console.WriteLine($"Grupo de las personas donde Soltero = {item.Key} (Total: {item.Count()})");

                //                                          //Itero los elementos de un agrupamiento actual
                foreach (var persona in item)
                {
                    Console.WriteLine($"- {persona.Nombre}");
                }
            }

        }
    }
}
