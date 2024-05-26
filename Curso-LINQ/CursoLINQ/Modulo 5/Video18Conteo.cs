using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_5
{
    public class Video18Conteo
    {
        public void Ejemplo()
        {
            //**********************************************//
            //                                              //
            Console.WriteLine("**PARA VER LOS VALORES HAY QUE DEBUGGEAR**");

            var personas = new List<Persona>() {
                new Persona { Nombre = "Eduardo", Soltero = true },
                new Persona { Nombre = "Nidia", Soltero = true },
                new Persona { Nombre = "Alejandro", Soltero = true },
                new Persona { Nombre = "Valentina", Soltero = false }
                };

            Console.WriteLine($"(Count): {personas.Count()}");

            Console.WriteLine($"Count(p => p.Soltero) : {personas.Count(p => p.Soltero)}");

            Console.WriteLine($"Int max : {int.MaxValue.ToString("N")}");

            Console.WriteLine($"(LongCount) : {personas.LongCount()}");

            Console.WriteLine($"LongCount es bueno cuando tengo una cantidad masiva de dos mil millones, " +
                $"en este caso esta lista no sobrepasa esa cantidad y por eso es valido usar Count");
            

            //                                              //Sintaxis de queries
            //                                              //(no muy útil en estos casos ya que no es mucha la
            //                                              //    variacion que cuando utilizo sintaxis de metodo)
            var conteoSolteros = (from p in personas
                                  where p.Soltero
                                  select p).Count();
        }
    }
}
