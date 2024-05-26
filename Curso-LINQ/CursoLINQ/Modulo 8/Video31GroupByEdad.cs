using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_8
{
    public class Video31GroupByEdad
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

            //**********************************************//
            Console.WriteLine("//**********************************************(A traves de metodo)//");
            Console.WriteLine("**Ejemplo 1.- Agrupamiento por Rango de edad de 5 en 5**");
            //                                              //Si una persona tiene por ejemplo 19 años,
            //                                              //    entonces 19/5= 3.5 y como estamos con tipo int
            //                                              //    se remueve la parte decimal y queda en 3
            //                                              //Por lo tanto aqui el agrupamiento se esta haciendo por
            //                                              //    el resultado de la division
            IEnumerable<IGrouping<int, Persona>> agrupamientoPorRangoEdad = personas.GroupBy(p => p.Edad / 5);

            foreach (IGrouping<int, Persona> item in agrupamientoPorRangoEdad)
            {
                Console.WriteLine($"Value Item.Key: {item.Key} .. Grupo de las personas en el rango de edad " +
                    $"{item.Key * 5} - {item.Key * 5 + 5 - 1}");

                foreach (var persona in item)
                {
                    Console.WriteLine($"- {persona.Nombre} (edad: {persona.Edad})");
                }
            }

            //**********************************************//
            Console.WriteLine("//**********************************************(A traves de Query)//");
            Console.WriteLine("Ejemplo 2.- **Agrupamiento por Rango de edad de 5 en 5**");
            //                                              //Sintaxis de queries
            //                                              //Si una persona tiene por ejemplo 19 años,
            //                                              //    entonces 19/5= 3.5 y como estamos con tipo int
            //                                              //    se remueve la parte decimal y queda en 3
            //                                              //Por lo tanto aqui el agrupamiento se esta haciendo por
            //                                              //    el resultado de la division
            IEnumerable<IGrouping<int, Persona>> agrupamientoPorRangoEdad_2 = from p in personas
                                             group p by p.Edad / 5 into grupos
                                             select grupos;

            foreach (IGrouping<int, Persona> item in agrupamientoPorRangoEdad_2)
            {
                Console.WriteLine($"Value Item.Key: {item.Key} .. Grupo de las personas en el rango de edad " +
                    $"{item.Key * 5} - {item.Key * 5 + 5 - 1}");

                foreach (var persona in item)
                {
                    Console.WriteLine($"- {persona.Nombre} (edad: {persona.Edad})");
                }
            }

        }
    }
}
