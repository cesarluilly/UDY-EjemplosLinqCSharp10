using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_2
{
    public class Video11SingleDemo
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
            Console.WriteLine("**Ejemplo 1**");
            //                                              //Solo hay un elemento, por lo tanto no va a dar ningun error.
            Persona personasMayorDe60 = personas.Single(p => p.Edad > 60);

            // Sintaxis de queries
            Persona personaMayorDe60_2 = (from p in personas
                                      where p.Edad > 60
                                      select p).Single();

            //**********************************************//
            Console.WriteLine("**Ejemplo 2: Con Single**");
            Persona personaMayorA100 = null;
            bool boolHuboError1 = false;
            try
            {
                personaMayorA100 = personas.Single(p => p.Edad > 100);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hubo un error, arreglo vacío");
                boolHuboError1 = true;
            }

            //**********************************************//
            Console.WriteLine("**Ejemplo 3: Con SingleOrDefault**");
            Persona personaMayor5 = null;
            bool boolHuboError2 = false;
            try
            {
                personaMayor5 = personas.SingleOrDefault(p => p.Edad > 5);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hubo otro error, arreglo con mas de un elemento");
                boolHuboError2 = true;
            }

            //**********************************************//
            Console.WriteLine("**Ejemplo 4: Con SingleOrDefault**");
            Persona personaMayor60 = null;
            bool boolHuboError3 = false;
            try
            {
                personaMayor60 = personas.SingleOrDefault(p => p.Edad > 60);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hubo otro error");
                boolHuboError3 = true;
            }

            //**********************************************//
            Console.WriteLine("**Ejemplo 5: Con SingleOrDefault**");
            Persona personaMayor100 = null;
            bool boolHuboError4 = false;
            try
            {
                personaMayor100 = personas.SingleOrDefault(p => p.Edad > 100);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hubo otro error");
                boolHuboError3 = true;
            }

        }
    }
}
