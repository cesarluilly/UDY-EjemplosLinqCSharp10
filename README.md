# UDY-EjemplosLinqCSharp10
## Apuntos cesar
* **Formas correctas de utiliza var**
    * Solo para cuando hay muchas invocaciones seguidas, esto es mas utilizado para cosas que no tienen mucho sentido y significado
        * Esto solo ayuda para eficientar el codigo
        * ![1716673046545](image/README/1716673046545.png)
    * Aun asi en la mayoria de los casos, hay que evitar el uso de var, ya que al inicio puede ser rapido escribirlo, pero si vuelves a leer el codigo ya te resulta complejo entenderle, pero para el mantenimiento no sirve en absoluto, el uso de var solo lo hacen personas egoistas que solo buscan su propio bien, y no el del proyecto
    * El unico lugar justificable para usar var, es cuando declaramos un objeto anonimo, pero eso es cuando el tipo de objeto no nos interesa mucho porque solo sirve de transicion para calcular otro dato.

* **Identificar el tipo de objeto que devuelve un metodo**
    * ![1716741582236](image/README/1716741582236.png)
        * En este caso se refiere a una coleccion de tuplas
        * ![1716741859302](image/README/1716741859302.png)

## Entender que es una expresion lambda, ya que al trabajar con LINQ utiliza mucho las expresiones Lambda

https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/operators/lambda-expressions
![1716684218255](image/README/1716684218255.png)
![1716684319704](image/README/1716684319704.png)
![1716684378116](image/README/1716684378116.png)

* Otros ejemplos y su diferencia
    * ![1716731900782](image/README/1716731900782.png)
    * ![1716731972195](image/README/1716731972195.png)



## Seccion 1: Introduccion

### Sintaxis(Linq de Metodo y Linq de Queries)

![1716613920618](image/README/1716613920618.png)

### Video 5: Ejecucion Diferida

* Evaluando de manera no Inmediata

![1716614059985](image/README/1716614059985.png)

* Evaluando de manera inmediata a traves de ToList

![1716614177982](image/README/1716614177982.png)

![1716640401172](image/README/1716640401172.png)

Por lo tanto LinQ, es eficiente en el tema de ejecucion diferida

## Seccion 2:

### Video 6 Funcion Where


### Video 7 Where con Objetos
* Ejemplo
    * ![1716643037111](image/README/1716643037111.png)
* Ambos dan el mismo resultado
    * ![1716643116232](image/README/1716643116232.png)

### Video 8 First y FirstOrDefault
* Ejemplo 1
    * ![1716644572114](image/README/1716644572114.png)
* Ejemplo 2
    * ![1716644600668](image/README/1716644600668.png)
* Otros ejemplos y sintaxis Metodo y Query
    * ![1716644647405](image/README/1716644647405.png)
### Video 9 Last y LastOrDefault
* Ejemplo 1
    * ![1716647889041](image/README/1716647889041.png)

### Video 10 ElementAt y ElementAtOrDefault
Aqui aplica lo mismo, para ElementAt en caso de que no lo encuentre va a mandar un error, 
por lo tanto ElementAtOrDefault en caso de que no encuentre el elemento, va a mandar el valor por default
* Ejemplo 1 
    * ![1716647836286](image/README/1716647836286.png)
### Video 11 Single y SingleOrDefault

* Esta instruccion permite verficar que la coleccion en base al criterio de busquedad, solo tenga un elemento.
    * Single: si tiene mas de un elemento va a mandar un error
    * SingleOrDefault: si tiene mas de un elemento, solo va a mandar null

* Ejemplo 1
    * ![1716649143959](image/README/1716649143959.png)
    * ![1716649170316](image/README/1716649170316.png)


### Video 12 Filtrando por tipo - OfType

Sirve para extraer de una lista que tiene diferentes tipos de objetos, solo un tipo de objeto de todos los que tiene la lista.

![1716673601864](image/README/1716673601864.png)

## Seccion 3: Ordenando Elementos

![1716675318892](image/README/1716675318892.png)

![1716675384875](image/README/1716675384875.png)

### Video 13 OrdeyBy y OrderByDescending
* Si queremos ordenar por 2 atributos, utilizamos OrderBy y despues ThenBy

### Video 14 ThenBy y ThenByDescending

Se esta ordenando por Edad Ascendente y Nombre Descendete
![1716675788827](image/README/1716675788827.png)
![1716675749072](image/README/1716675749072.png)

### Video 15 Reverse
Podemos revertir el orden de la proyeccion y lo hacemos con `Reverse`
En caso de que a un listado de objetos quieramos aplicarle el reverse, funciona mejor o es mas rapido
hacerlo a traves de un IEnumerable

![1716681852809](image/README/1716681852809.png)


## Seccion 4: Proyecciones

### Video 16 Select

La funcion select nos permite realizar una proyeccion de los datos, pero tambien
puedo hacer una transformacion mientras estoy en el proceso
![1716682335987](image/README/1716682335987.png)
![1716682406558](image/README/1716682406558.png)

### Video 17 SelectMany
Hasta ahora nos la hemos pasado trabajando con una coleccion, sin embargo con LINQ podemos trabajar
varias colecciones de manera simultanea.
Por ejemplo para aplanar las coleciones lo podemos hacer con SelectMany
* Datos iniciales
    * ![1716685445815](image/README/1716685445815.png)
* Ejemplo 1
    * ![1716685758953](image/README/1716685758953.png)
* Ejemplo 2
    * ![1716685860156](image/README/1716685860156.png)
    * ![1716685876064](image/README/1716685876064.png)
* Ejemplo 3
    * ![1716686067130](image/README/1716686067130.png)
    * ![1716686089076](image/README/1716686089076.png)
* Ejemplo 4
    * ![1716686273851](image/README/1716686273851.png)
## Seccion 5: Escalares
* En este modulo no vamos a utilizar mucho la sintaxis de Query ya que no hay mucha variacion con respecto a la sintaxis de metodo
### Video 18 Count y LongCount

* Codigo 
    * ![1716686864986](image/README/1716686864986.png)
* Corrida
    * ![1716686930936](image/README/1716686930936.png)

### Video 19 Suma, Maximo y Minimo
* Codigo
    * ![1716687168906](image/README/1716687168906.png)
* Corrida
    * ![1716687201708](image/README/1716687201708.png)

### Video 20 MaxBy y MinBy(Nuevo de C# 10)
* Mientras con .Max y .Min me trae solo la edad maxima o minima
* .MaxBy y .MinBy me trae el objeto que tiene la edad maxima o minima correspondiente
![1716687792009](image/README/1716687792009.png)

### Video 21 Promedios
* Codigo
    * ![1716687995375](image/README/1716687995375.png)
* Corrida
    * ![1716688024386](image/README/1716688024386.png)

### Video 22 Agregados
* Codigo
    * ![1716688510980](image/README/1716688510980.png)
* Corrida
    * ![1716688545339](image/README/1716688545339.png)

## Seccion 6: Cuantificadores (Instrucciones que solo devuelven true o false)
* Los cuantificadores nos permiten hacer preguntas como 
    * Son todas las personas de esta coleccion mayores de edad?
    * Existe algun numero negativo en esta coleccion?

**NOTA**. No existen sintaxis de query en cuantificadores, por lo tanto en este modulo no se vera la parte de sintaxis de query

### Video 23 All
* Los cuantificadores nos permiten hacer preguntas como 
    * Son todas las personas de esta coleccion mayores de edad?
    * Son todas las personas de esta coleccion solteros?
        * ![1716688843658](image/README/1716688843658.png)

### Video 24 Any

* Podemos tambien verificar si existe al menos un elemento en la coleccion
    * Aqui hacemos la pregunta
    * Existe en la coleccion al menos una persona que sea menor de 18 años?
    * Existe en la coleccion al menos una persona que sea mayor de 20 ?
        * ![1716689085014](image/README/1716689085014.png)

### Video 25 Contains
* Contain es una manera de pregunta si un elemento especifico se encuentra dentro de la coleccion
    * ![1716689591522](image/README/1716689591522.png)

## Seccion 7: Paginacion
En este modulo no vamos a utilizar la sintaxis de query, ya que las instrucciones para sintaxis de query solo se encierra entre parentes el query y se le aplica la funcion, por lo tanto no hay mucha diferencia que con la sintaxis de metodo
### Video 26 Take y TakeLast
En ocasiones vamos a tenere colecciones muy grandes y vamos a querer entonces solo tomar los n elementos de esa coleccion, para eso podemos utiliza la funcion Take

* ![1716690084580](image/README/1716690084580.png)

### Video 27 Skip y SkipLast
Con Skip podemos saltarnos unos cuantos elementos de la ****coleccion
**NOTA: Skip funciona en base Zero** 
* ![1716690568655](image/README/1716690568655.png)

### Video 28 Ejemplo de Paginacion
**NOTA: Skip funciona en base Zero** 

Combinando Skip y Take podemos realizar paginaciones
* ![1716693182543](image/README/1716693182543.png)
* ![1716693372164](image/README/1716693372164.png)

### Video 29 TakeWhile y SkipWhile
Podriamos utilizar condiciones con Take y Skip.

* Por ejemplo si queremos tomas los primeros elementos de una coleccion mientras se cumpla con una condicion indicada, podemos utilizar `TakeWhile`
* Por ejemplo si queremos saltar los elementos de una coleccion mientras se cumple el predicado(condicion), y a partir de que el predicado es False tomar todos los elementos siguiente, podemos utilizar `TakeWhile`
    * ![1716727255741](image/README/1716727255741.png)

## Seccion 8: Agrupando

### Video 30 GroupBy Simple

A veses nos resulta util agrupar los elementos de una coleccion en base a una caracteristica especifica

* Datos iniciales
    * ![1716729181330](image/README/1716729181330.png)
* Ejemplo 1
    * ![1716729239977](image/README/1716729239977.png)
    * ![1716729282290](image/README/1716729282290.png)
* Ejemplo 2 (a Traves de Queries)
    * ![1716729403322](image/README/1716729403322.png)
    * ![1716729430779](image/README/1716729430779.png)

### Video 31 GroupBy Por Rango de Edad
Agrupamiento por Rango de edad, de rango de edad de 5 en 5

**Nota** Aqui el agrupamiento se esta haciendo por el resultado de una division
* Datos Iniciales
    * ![1716730191876](image/README/1716730191876.png)
* Ejemplo 1
    * ![1716730516692](image/README/1716730516692.png)
    * ![1716730691497](image/README/1716730691497.png)
* Ejemplo 2
    * ![1716730868868](image/README/1716730868868.png)
    * ![1716730827361](image/README/1716730827361.png)

## Seccion 9: Relacionando Distintas Colecciones

### Video 32 Join(Inner Join)
En ocaciones vamos a tener un Join que vamos a querer unir por una valor comun a traves de un Join, 
en el mundo de SQL Server es similar a un InnerJoin


* Expresiones lambda y su diferencia
    * ![1716731900782](image/README/1716731900782.png)
    * ![1716731972195](image/README/1716731972195.png)

* Datos iniciales
    * ![1716732619960](image/README/1716732619960.png)
* Ejemplo 1(Sintaxis de metodo)
    * ![1716732662707](image/README/1716732662707.png)
    * ![1716732710736](image/README/1716732710736.png)
* Ejemplo 2(Sintaxis de Query)
    * ![1716732806322](image/README/1716732806322.png)
    * ![1716732845766](image/README/1716732845766.png)


### Video 33 GroupJoin(Left Join)
Ademas de hacer una operacion de relacion utilizando Join, podemos hacer una relacion que ademas de hacer el Join tambien pueda hacer una agrupacion.

Left Join siempre va a traer los registros de la primera tabla y su relacion con la segunda tabla

A continuacion vamos a hacer 
* Una relacion entre Empresa y Persona por el Id correspondiente
* Voy a agrupar a todas las personas que pertenecen a una empresa especifica.
    * Por ejemplo voy a agrupar a Eduardo y Nidia en un mismo grupo ya que pertenecen a la empresa con Id 1

GroupJoin va a poder permitir agrupar y hacer un join al mismo tiempo.

* Datos Iniciales
    * ![1716733940989](image/README/1716733940989.png)
* Ejemplo 1 (Sintaxis de Metodo)
    * ![1716734028943](image/README/1716734028943.png)
    * ![1716734125199](image/README/1716734125199.png)
* Ejemplo 2 (Sintaxis de Query)
    * ![1716734183660](image/README/1716734183660.png)
    * ![1716734293151](image/README/1716734293151.png)

## Seccion 10: Conjuntos

### Video 34 Distinct y DistinctBy(Nuevo de C# 10)

* Datos Iniciales
    * ![1716735607929](image/README/1716735607929.png)
* Ejemplo 1(Sintaxis metodo)
    * ![1716735399559](image/README/1716735399559.png)
* Ejemplo 2(Sintaxis Query)
    * ![1716735513790](image/README/1716735513790.png)



### Video 35 Union y UnionBy (Nuevo de C# 10)
Con Union podemos unir 2 colecciones y eliminar los duplicados

* Datos Iniciales
    *    ![1716735963750](image/README/1716735963750.png)
* Ejemplo 1 (Union de 2 listas de tipo int)
    * ![1716736179859](image/README/1716736179859.png)
* Ejemplo 1 (Union de 2 listas de objetos, la union es en base al nombre) **Nota** En caso de haber duplicados, tomara el primer elemento de la primera lista
    * ![1716736264499](image/README/1716736264499.png)

### Video 36 Except y ExceptBy (Nuevo de C# 10)
* Con Except podemos hacer una comparacion de colecciones donde tengamos todos los elementos de la primera coleccion que no se encuentren en la segunda coleccion

* Visualmente Basandonos en el siguiente grafico
    * ![1716736432955](image/README/1716736432955.png)
* Vamos a tener todo lo que esta en A, pero que no este en B, esto es lo que el Except me da como resultado

Empezemos con el codigo y pruebas

* Datos Iniciales
    * ![1716736736307](image/README/1716736736307.png)
* Ejemplo 1 
    * ![1716736972054](image/README/1716736972054.png)
* Ejemplo 2 (Uso de ExceptBy nuevo en C# 10, esta comparacion en este caso de hace a traves del nombre)
    * ![1716737218245](image/README/1716737218245.png)

### Video 37 Intersect y IntersectBy (Nuevo de C# 10)
Podemos utilizar Intersect o IntersectBy para buscar los elementos comunes entre 2 colecciones

* Datos Iniciales
    * ![1716737743193](image/README/1716737743193.png)
* Ejemplo 1
    * ![1716737830747](image/README/1716737830747.png)
* Ejemplo 2 (IntersectBy nuevo en C# 10) Aqui me va a traer los objetos comunes a traves del nombre
    * ![1716737988555](image/README/1716737988555.png)

## Seccion 11: Miscelaneo

### Video 38 Concat
La operacion de concatenacion nos permite juntar 2 colecciones, a diferencia de join este los junta sin eliminar duplicados

* Datos Iniciales
    * ![1716738317341](image/README/1716738317341.png)
* Ejemplo 1
    * ![1716738429151](image/README/1716738429151.png)
* Ejemplo 2 (Aqui se ve que solo une sin elimina duplicados)
    * ![1716738551654](image/README/1716738551654.png)
* **NOTA** No existe sintaxis de Query

### Video 39 SequenceEqual

A veses necesitamos verificar si 2 colecciones tienen exactamente los mismos elementos

* Ejemplos
    * ![1716740761459](image/README/1716740761459.png)


### Video 40 Zip
Con ZIP podemos realizar una operacion sobre los elementos respectivos de dos colecciones segun el orden.

Es decir de una lista que tiene 3 elementos voy a combinar segun el Indice
* Lista 1
    * 0 - A
    * 1 - B
    * 2 - C
* Lista 2
    * 0 - a
    * 1 - b
    * 2 - c
* Combinacion
    * 0 - A a
    * 1 - B b
    * 2 - C c

* Identificar el tipo de objeto que devuelve un metodo
    * ![1716741582236](image/README/1716741582236.png)
        * En este caso se refiere a una coleccion de tuplas
        * ![1716741859302](image/README/1716741859302.png)

* Datos Iniciales
    * ![1716742478370](image/README/1716742478370.png)
* Ejemplo 1
    * ![1716742521985](image/README/1716742521985.png)
    * ![1716742680953](image/README/1716742680953.png)
* Ejemplo 2 Realizando operacion con la informacion de cada tupla
    * ![1716742637201](image/README/1716742637201.png)

### Video 41 Chunk (Nuevo de C# 10)

Podemos divir una coleccion en distintas partes utilizando "Chunk"



* Datos Iniciales
    * ![1716743082493](image/README/1716743082493.png)
* Ejemplo 1
    * ![1716743137645](image/README/1716743137645.png)
    * ![1716743038052](image/README/1716743038052.png)

### Video 42 TryGetNonEnumeratedCount (Nuevo de C# 10)

* Puntos importantes
    * Cuando contamos los elementos de una coleccion, esperamos que esta operacion sea sumamente rapida, despues de todo simplemente queremos un numero el cual nos indica la cantidad de elementos de la coleccion

    * Sin embargo, si nuestra coleccion implementa las interfaces adecuadas, esta operacion de conteo va a consistir en recorrer la coleccion para contar la cantidad de elementos, ESTO PUEDE SER INEFICIENTE EN DETERMINADOS ESCENARIOS, `SI QUEREMOS EVITAR ESA INEFICIENCIA, PODEMOS UTILIZAR UNA NUEVA FUNCION DE C# 10 LLAMADA **TryGetNonEnumeratedCount**`

    * Por lo tanto `TryGetNonEnumeratedCount` nos permite verificar si el conteo que se realizo es eficiente.

    * **El motivo por el cual da false** es porque no podemos realizar el conteo sin haber realizado una enumeracion.
        * Cada ves que nos de false, el valor de conteo va a ser Zero ya que no se pudo contar nada
    * **Esto es muy importante en escenarios de alto rendimiento en donde tu de verdad, de verdad necesitas el mayor rendimiento posible**

Procedemos a correr
* Datos iniciales
    * ![1716746269106](image/README/1716746269106.png)
* Ejemplo 1
    * ![1716746337694](image/README/1716746337694.png)
* Ejemplo 2 Utilizando Count() para ver su funcionamiento
    * ![1716746388718](image/README/1716746388718.png)
* Ejemplo 3 La clase implementa de IEnumerable
    * ![1716746470091](image/README/1716746470091.png)
* Ejemplo 4 La clase implementa de ICollection
    * ![1716746586932](image/README/1716746586932.png)

## Seccion 12: LINQ Y Bases de Datos - Entity Framework Core

**NOTA** `LINQ nos permite conectarnos con diferentes proveedores de bases de datos utilizando el mismo codigo`

### Video 43 Instalando los Paquetes de Entity Framework Core

### Video 44 Configurando Entity Framework Core

### Video 45 Usando LINQ con Entity Framework Core

### Video 46 LINQ y SQL Server

## Seccion 13:Gracias

### Video 47. Gracias
