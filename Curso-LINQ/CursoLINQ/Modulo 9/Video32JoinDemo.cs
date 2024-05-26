using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_9
{
    public class Video32JoinDemo
    {
        public void Ejemplo()
        {
            //**********************************************//
            //                                              //
            Console.WriteLine("**PARA VER LOS VALORES HAY QUE DEBUGGEAR**");

            List<Persona> personas = new List<Persona>() {
                            new Persona { Nombre = "Eduardo", EmpresaId = 1, },
                            new Persona { Nombre = "Nidia",  EmpresaId = 1 },
                            new Persona { Nombre = "Alejandro", EmpresaId = 3 },
                            new Persona { Nombre = "Valentina",  EmpresaId = 2 },
                            new Persona { Nombre = "Roberto",  EmpresaId = 3 },
                            new Persona { Nombre = "Eugenia"},
                            new Persona { Nombre = "Esmerlin", EmpresaId = 3 }
                            };

            List<Empresa> empresas = new List<Empresa>()
            {
                new Empresa{Id = 1, Nombre = "Electrodomésticos Felipe"},
                new Empresa{Id = 2, Nombre = "Bicicletas Valentina"},
                new Empresa{Id = 3, Nombre = "Gimnasio Esmerlin"}
            };

            //**********************************************//
            Console.WriteLine("//**********************************************//(Sintaxis de metodo)");
            Console.WriteLine("**Ejemplo 1.- Relacion de Personas y empresas**");
            //                                              //Vamos a relacionar Personas con la empresa
            //                                              //Primer parametro es la lista con la cual yo quiero hacer
            //                                              //    el join, despues especificamos los campos con los
            //                                              //    que voy a hacer la relacion, despues especificamos
            //                                              //    lo que yo quiero retornar a traves de una expresion 
            //                                              //    lambda un objeto anonimo.
            //                                              //p => p.EmpresaId ---> "Expresion Lambda simple" que toma 
            //                                              //    un parametro de entrada y devuelve un valor primitivo
            //                                              //    p.EmpresaId
            //                                              //(persona, empresa) => new
            //                                              //        {
            //                                              //          Persona = persona,
            //                                              //          Empresa = empresa
            //                                              //        }  ----> Expresión Lambda con Proyección a
            //                                              //                      Objeto Anónimo

            var personasYEmpresas = personas.Join(empresas, p => p.EmpresaId, e => e.Id, 
                (personaParametro, empresaParametro) => new
            {
                Persona = personaParametro,
                Empresa = empresaParametro
            });

            foreach (var item in personasYEmpresas)
            {
                Console.WriteLine($"{item.Persona.Nombre} trabaja en {item.Empresa.Nombre}");
            }

            //**********************************************//
            Console.WriteLine("//**********************************************//(Sintaxis de Query)");
            Console.WriteLine("**Ejemplo 2.- Relacion de Personas y empresas**");
            var personasYEmpresas_2 = from persona in personas
                                      join empresa in empresas on persona.EmpresaId equals empresa.Id
                                      select new
                                      {
                                          Persona = persona,
                                          Empresa = empresa
                                      };

            foreach (var item in personasYEmpresas_2)
            {
                Console.WriteLine($"{item.Persona.Nombre} trabaja en {item.Empresa.Nombre}");
            }

        }
    }
}
