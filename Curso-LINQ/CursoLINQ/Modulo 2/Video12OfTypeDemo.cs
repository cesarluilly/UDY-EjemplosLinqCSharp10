using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_2
{
    public class Video12OfTypeDemo
    {
        public void Ejemplo()
        {
            //**********************************************//
            //                                              //
            Console.WriteLine("**PARA VER LOS VALORES HAY QUE DEBUGGEAR**");

            //                                              //
            //                                              //Lista con diferentes tipos de objetos.
            List<object> listado = new List<object>() { "Felipe", 1, 2, "Claudia", true };

            //                                              //Solo traigo del tipo String
            Console.WriteLine("**Ejemplo 1**");
            IEnumerable<string> strings = listado.OfType<string>();

            //                                              //Solo traigo del tipo int
            Console.WriteLine("**Ejemplo 2**");
            IEnumerable<int> numeros = listado.OfType<int>();

            Console.WriteLine("**Ejemplo 3**");
            //                                              //sintaxis de queries
            IEnumerable<string> strings_2 = from s in listado.OfType<string>()
                            select s;

            //                                              //Ejemplo 2: herencia
            Console.WriteLine("**Ejemplo 4**");
            List<Animal> listadoAnimales = new List<Animal>()
                                    {
                                        new Perro(){Nombre = "Firulais"},
                                        new Gato(){Nombre = "Félix"}
                                    };

            IEnumerable<Perro> perros = listadoAnimales.OfType<Perro>();
        }

        public abstract class Animal
        {
            public abstract string? Nombre { get; set; }
        }

        public class Perro : Animal
        {
            public override string? Nombre { get; set; }
        }

        public class Gato : Animal
        {
            public override string? Nombre { get; set; }
        }
    }
}
