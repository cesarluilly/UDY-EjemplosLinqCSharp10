using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_3
{
    public class Video15ReverseDemo
    {
        public void Ejemplo()
        {
            //**********************************************//
            //                                              //
            Console.WriteLine("**PARA VER LOS VALORES HAY QUE DEBUGGEAR**");

            List<Persona> personasOriginal = new List<Persona>() {
                            new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
                            new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
                            new Persona { Nombre = "Alejandro", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
                            new Persona { Nombre = "Valentina", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
                            new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
                            };


            //**********************************************//
            Console.WriteLine("**Ejemplo 1**");
            IEnumerable<int> numeros = Enumerable.Range(1, 5).Reverse();

            //                                              //Sintaxis de queries
            IEnumerable<int> numeros_2 = from n in Enumerable.Range(1, 20).Reverse()
                            select n;

            //**********************************************//
            Console.WriteLine("**Ejemplo 2**");
            List<Persona> personasRevertidoCopia = personasOriginal.ToList();
            //                                              //Este reverse sirve para revertir el ordenamiento de personas
            //                                              //    pero no crea un nuevo objeto.
            personasRevertidoCopia.Reverse();

            //**********************************************//
            Console.WriteLine("**Ejemplo 3**");
            List <Persona> personasInvertido = personasOriginal.AsEnumerable().Reverse().ToList();
        }
    }
}
