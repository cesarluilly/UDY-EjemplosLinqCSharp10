using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_5
{
    public class Video20MaxByMinBy
    {
        public void Ejemplo()
        {
            //**********************************************//
            //                                              //
            Console.WriteLine("**PARA VER LOS VALORES HAY QUE DEBUGGEAR**");

            List<Persona> personas = new List<Persona>() {
                                new Persona { Nombre = "Eduardo", Edad = 19, },
                                new Persona { Nombre = "Nidia", Edad = 25 },
                                new Persona { Nombre = "Alejandro", Edad = 30 },
                                new Persona { Nombre = "Valentina", Edad = 22 }
                                };

            var numeros = Enumerable.Range(1, 5);

            Console.WriteLine($"numeros.Sum() --> La suma de los numeros es {numeros.Sum()}");
            Console.WriteLine($"personas.Sum(p => p.Edad) --> La suma de los numeros es {personas.Sum(p => p.Edad)}");

            Console.WriteLine($"personas.Max(x => x.Edad) --> La edad máxima de las personas es {personas.Max(x => x.Edad)}");
            Console.WriteLine($"personas.Min(x => x.Edad) --> La edad mínima de las personas es {personas.Min(x => x.Edad)}");

            //                                              //MaxBy y MinBy es nuevo en C# 10
            //                                              //Mientras con .Max y .Min me trae solo la edad maxima o minima
            //                                              //.MaxBy y .MinBy me trae el objeto que tiene
            //                                              //    la edad Maxima o Minima correspondiente
            var personaDeMayorEdad = personas.MaxBy(x => x.Edad);
            var personaDeMenorEdad = personas.MinBy(x => x.Edad);
        }
    }
}
