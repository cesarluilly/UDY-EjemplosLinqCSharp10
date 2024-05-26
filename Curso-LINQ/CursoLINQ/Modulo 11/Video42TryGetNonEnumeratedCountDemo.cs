using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_11
{
    public class Video42TryGetNonEnumeratedCountDemo
    {
        public void Ejemplo()
        {
            //**********************************************//
            //                                              //
            Console.WriteLine("**PARA VER LOS VALORES HAY QUE DEBUGGEAR**");

            int[] A = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<Persona> personasA = new List<Persona>()
            {
                new Persona{Nombre = "Eduardo", EmpresaId = 1},
                new Persona{Nombre = "Nidia", EmpresaId = 1},
                new Persona{Nombre = "Esmerlin", EmpresaId = 3}
            };

            //                                              //Lista que implementa de IEnumerable<Persona>
            PersonasCollection personasCollectionImplementaIEnumerable = new PersonasCollection();
            personasCollectionImplementaIEnumerable.AddRange(personasA);

            //                                              //Lista que implementa de ICollection<Persona>
            PersonasCollectionImplementaICollection personasImplementaICollection = 
                new PersonasCollectionImplementaICollection();
            personasImplementaICollection.AddRange(personasA);



            Console.WriteLine("//**********************************************//");
            Console.WriteLine("**Ejemplo 1**");
            int conteo = 0;

            //                                              //Lo que hace es que va a intentar contar los elementos 
            //                                              //    de la coleccion "A" y si lo logra va a poner el 
            //                                              //    conteo en la variable "conteo" y en caso
            //                                              //    de poder realizar el conteo de una manera EFICIENTE
            //                                              //    VA A DEVOLVER TRUE
            //                                              //Este valor es true, porque podemos obtener el conteo
            //                                              //    del arreglo sin necesidad de recorrer el arreglo, 
            //                                              //    por tanto es una operacion rapido lo cual esta permitida, 
            bool pudoContarASinEnumerar = A.TryGetNonEnumeratedCount(out conteo);

            Console.WriteLine("//**********************************************//");
            Console.WriteLine("**Ejemplo 2 Usando Count()**");
            

            //                                              //Al invocar el metodo Count() internamente se invocara el 
            //                                              //    metodo GetEnumerator de la clase PersonasCollection, 
            //                                              //    y lo que hace es recorrer la coleccion para poder
            //                                              //    contar y lo cual esto es ineficiente.
            int intCountInvocandoMetodoCount = personasCollectionImplementaIEnumerable.Count();

            Console.WriteLine("//**********************************************//");
            Console.WriteLine("**Ejemplo 3 Usando TryGetNonEnumeratedCount**");
            //                                              //Sin embargo si creamos nuestras propias clases que no 
            //                                              //    implementen un conteo rapido, veremos que tendremos
            //                                              //    problema.
            //                                              //Por ejemplo aqui TryGetNonEnumeratedCount va a intentar
            //                                              //    contar de una manera eficiente, pero como el conteo
            //                                              //    no es eficiente ya que invoca internamente al metodo 
            //                                              //    GetEnumerator y lo que hace es iterar para poder conta.
            //                                              //    por lo tanto me va a devolver false
            //                                              //Nos da false ya que no podemos contar los elementos sin 
            //                                              //    aber realizado una enumeracion.
            //                                              //Cada ves que nos de false, el conteo va a ser 0
            int conteoPersonas2 = 0;
            bool pudoContarPersonasSinEnumerar = personasCollectionImplementaIEnumerable.TryGetNonEnumeratedCount(out conteoPersonas2);



            //                                              //Por lo tanto una solucion para que el conteo sea eficiente
            //                                              //    es implementar de ICollection que me obliga a
            //                                              //    implementar metodo como count().
            //                                              //Por lo tanto cuando invoque el metodo
            //                                              //    TryGetNonEnumeratedCount, internamete ahora invocara al
            //                                              //    metodo count, ya que no nos vemos obligados a enumerar
            //                                              //    para poder contar sus elementos.
            Console.WriteLine("//**********************************************//");
            Console.WriteLine("**Ejemplo 4 Usando TryGetNonEnumeratedCount**");
            int conteoPersonas3 = 0;
            bool pudoContarPersonasImplementaICollection = personasImplementaICollection
                .TryGetNonEnumeratedCount(out conteoPersonas3);
        }

        public class PersonasCollection : IEnumerable<Persona>
        {
            private readonly List<Persona> _personas = new List<Persona>();


            public void Add(Persona persona)
            {
                _personas.Add(persona);
            }

            public void AddRange(IEnumerable<Persona> personas)
            {
                _personas.AddRange(personas);
            }

            public void Clear()
            {
                throw new NotImplementedException();
            }

            public bool Contains(Persona item)
            {
                throw new NotImplementedException();
            }

            public void CopyTo(Persona[] array, int arrayIndex)
            {
                throw new NotImplementedException();
            }

            public IEnumerator<Persona> GetEnumerator(
                //                                          //Nos sirve para iterar una instancia de PersonasCollection.
                
                //                                          //NOTA. Si yo utilizo COUNT se va a invocar este metodo.
                )
            {
                return _personas.GetEnumerator();
            }

            public bool Remove(Persona item)
            {
                throw new NotImplementedException();
            }

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return ((IEnumerable<Persona>)_personas).GetEnumerator();
            }
        }

        public class PersonasCollectionImplementaICollection : ICollection<Persona>
        {
            private readonly List<Persona> _personas = new List<Persona>();

            public int Count => _personas.Count;

            public bool IsReadOnly => throw new NotImplementedException();

            public void Add(Persona persona)
            {
                _personas.Add(persona);
            }

            public void AddRange(IEnumerable<Persona> personas)
            {
                _personas.AddRange(personas);
            }

            public void Clear()
            {
                throw new NotImplementedException();
            }

            public bool Contains(Persona item)
            {
                throw new NotImplementedException();
            }

            public void CopyTo(Persona[] array, int arrayIndex)
            {
                throw new NotImplementedException();
            }

            public IEnumerator<Persona> GetEnumerator(
                //                                          //Nos sirve para iterar una instancia de PersonasCollection.

                //                                          //NOTA. Si yo utilizo COUNT se va a invocar este metodo.
                )
            {
                return _personas.GetEnumerator();
            }

            public bool Remove(Persona item)
            {
                throw new NotImplementedException();
            }

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return ((IEnumerable<Persona>)_personas).GetEnumerator();
            }
        }

    }

}
