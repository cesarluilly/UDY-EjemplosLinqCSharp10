# UDY-EjemplosLinqCSharp10
## Apuntos cesar
* Formas correctas de utiliza var
    * Solo para cuando hay muchas invocaciones seguidas, esto es mas utilizado para cosas que no tienen mucho sentido y significado
        * Esto solo ayuda para eficientar el codigo
        * ![1716673046545](image/README/1716673046545.png)
* Aun asi en la mayoria de los casos, hay que evitar el uso de var, ya que al inicio puede ser rapido escribirlo, pero si vuelves a leer el codigo ya te resulta complejo entenderle, pero para el mantenimiento no sirve en absoluto, el uso de var solo lo hacen personas egoistas que solo buscan su propio bien, y no el del proyecto

## Entender que es una expresion lambda, ya que al trabajar con LINQ utiliza mucho las expresiones lamda

https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/operators/lambda-expressions
![1716684218255](image/README/1716684218255.png)
![1716684319704](image/README/1716684319704.png)
![1716684378116](image/README/1716684378116.png)




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

### Video 26 Take y TakeLast

### Video 27 Skip y SkipLast

### Video 28 Ejemplo de Paginacion

### Video 29 TakeWhile y SkipWhile

## Seccion 8:

### Video 30

### Video 31

## Seccion 9: Relacionando Distintas Colecciones

### Video 32 Join(Inner Join)

### Video 33 GroupJoin(Left Join)

## Seccion 10: Conjuntos

### Video 34 Distinct y DistinctBy(Nuevo de C# 10)

### Video 35 Union y UnionBy (Nuevo de C# 10)

### Video 36 Except y ExceptBy (Nuevo de C# 10)

### Video 37 Intersect y IntersectBy (Nuevo de C# 10)

## Seccion 11: Miscelaneo

### Video 38 Concat

### Video 39 SequenceEqual

### Video 40 Zip

### Video 41 Chunk (Nuevo de C# 10)

### Video 42 TryGetNonEnumeratedCount (Nuevo de C# 10)

## Seccion 12: LINQ Y Bases de Datos - Entity Framework Core

### Video 43 Instalando los Paquetes de Entity Framework Core

### Video 44 Configurando Entity Framework Core

### Video 45 Usando LINQ con Entity Framework Core

### Video 46 LINQ y SQL Server

## Seccion 13:Gracias

### Video 47. Gracias
