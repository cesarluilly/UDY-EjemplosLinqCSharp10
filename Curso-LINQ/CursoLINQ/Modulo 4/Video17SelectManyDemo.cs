using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_4
{
    public class Video17SelectManyDemo
    {
        public void Ejemplo()
        {
            //**********************************************//
            //                                              //
            Console.WriteLine("**PARA VER LOS VALORES HAY QUE DEBUGGEAR**");

            var personas = new List<Persona>() {
                new Persona { Nombre = "Eduardo", Telefonos = { "123-456", "789-852" } },
                new Persona { Nombre = "Nidia", Telefonos = { "998-478", "568-222" } },
                new Persona { Nombre = "Alejandro", Telefonos = { "712-132" } },
                new Persona { Nombre = "Valentina" }
                };

            //**********************************************//
            Console.WriteLine("**Ejemplo 1: Crear una coleccion de todos los telefonos de cada registro**");
            //                                              //Lo siguiente me devuelve una coleccion aplanada
            List<string> telefonos = personas.SelectMany(x => x.Telefonos).ToList();

            //                                              //Agregamos este solo como ejemplo practico de select.
            List<List<String>> telefonosConSelect = personas.Select(x => x.Telefonos).ToList();

            //**********************************************//
            Console.WriteLine("**Ejemplo 2: Entendiendo SelectMany con dos colecciones diferentes**");

            //                                              //Yo puedo relacionar 2 colecciones utilizando selectMany,
            //                                              //En este ejemplo voy a relacionar a cada persona un numero
            int[] numeros = { 1, 2, 3 };

            //                                              //Lo que estamos haciendo aqui, es combinar la lista de
            //                                              //    "personas" con la lista de "numeros" y de esa 
            //                                              //    combinacion yo quiero que crees una expresion lambda
            //                                              //    que va a recibir los parametros
            //                                              //    "(personaParametro, numeroParametro)" para poder crear
            //                                              //    un objeto anonimo a traves de New que va a tener
            //                                              //    sus propiedades
            //                                              //Viendolo desde otro modo, es como hacer un join para 
            //                                              //    sacar una combinacion entre ambas listas
            //                                              //    por lo tanto la
            //                                              //    totalRegistros = lista1.count * lista2.count
            var personasYNumeros = personas.SelectMany(p => numeros, (personaParametro, numeroParametro) => new
            {
                PropiedadPersonaObjAnonimo = personaParametro,
                PropiedadNumeroObjAnonimo = numeroParametro
            });

            foreach (var item in personasYNumeros)
            {
                Console.WriteLine($"{item.PropiedadPersonaObjAnonimo.Nombre} - {item.PropiedadNumeroObjAnonimo}");
            }

            Console.WriteLine("**Ejemplo 3: personas y telefonos**");
            //                                              //Aqui estamos combinando la lista personas con 
            //                                              //    su propia lista de propiedad. Esto para aplanar los
            //                                              //    datos.
            var personasYTelefonos = personas.SelectMany(p => p.Telefonos, (personaParametro, telefonoParametro) => new
            {
                PropiedadPersonaObjAnonimo = personaParametro,
                PropiedadTelefonoObjAnonimo = telefonoParametro
            });

            foreach (var item in personasYTelefonos)
            {
                Console.WriteLine($"{item.PropiedadPersonaObjAnonimo.Nombre} - {item.PropiedadTelefonoObjAnonimo}");
            }











            Console.WriteLine("**Ejemplo 4: Sintaxis de Query**");
            //                                              //Sintaxis de queries
            //                                              //Aqui lo que yo quiero es aplanar la lista de telefonos
            //                                              //    que se encuentran en este listado de personas
            //                                              //    y me devuelve un arreglo de strings que representa
            //                                              //    cada uno de los telefonos.
            var telefonos_2 = from p in personas
                              from telefono in p.Telefonos
                              select telefono;

            //                                              //Aqui lo que se hace es que por cada persona se combina
            //                                              //    con sus telefonos y por lo tanto se esta aplanando 
            //                                              //    los datos.
            var personasYNumeros_2 = from p in personas
                                     from n in numeros
                                     select new
                                     {
                                         Persona = p,
                                         Numero = n
                                     };

        }
    }
}
