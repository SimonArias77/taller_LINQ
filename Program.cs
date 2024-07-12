// TALLER PRÁCTICO LINQ

// EJERCICIOS SOBRE LISTAS DE NÚMEROS
List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// ● Filtrar y mostrar solo los números pares de la lista numbers.
var pares = numbers.Where(number => number % 2 == 0).ToList();
foreach (var par in pares)
{
    Console.WriteLine(par);
}

// ● Usando LINQ, calcular la suma de todos los números impares en la lista numbers.
var impares = numbers.Where(number => number % 2 != 0).ToList();
var sumaImpares = impares.Sum();
Console.WriteLine($"Suma de impares: {sumaImpares}");

// ● Ordenar de manera descendente los números mayores que 5 en la lista numbers.
var mayoresCinco = numbers.Where(number => number > 5).OrderByDescending(number => number).ToList();
foreach (var mayor in mayoresCinco)
{
    Console.WriteLine(mayor);
}
// ● Contar cuántos números son menores o iguales a 3 en la lista numbers.
var menorOigualAtres = numbers.Where(number => number <= 3).ToList();
var suma = menorOigualAtres.Sum();
Console.WriteLine($"la suma de los números menores o iguales a 3, nos arroja como resultado: {suma} ");

// ● Seleccionar cada número en la lista numbers y multiplicarlo por 2.
var multiplicados = numbers.Select(number => number * 2).ToList();
foreach (var multiplicado in multiplicados)
{
    Console.WriteLine(multiplicado);
}

// EJERCICIOS SOBRE LISTAS DE STRINGS
List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David", "Eve" };

// ● Ordenar los nombres en la lista names alfabéticamente.
var ordenar = names.OrderBy(name => name).ToList();
foreach (var name in ordenar)
{
    Console.WriteLine(name);
}
// ● Seleccionar los nombres en la lista names que empiezan con la letra 'A'.
var aLetras = names.Where(name => name.StartsWith("A")).ToList();
foreach (var name in aLetras)
{
    Console.WriteLine(name);
}

// ● Contar cuántos nombres en la lista names tienen más de 5 caracteres.
var conMasDeCincoCaracteres = names.Count(name => name.Length > 5);
Console.WriteLine($"Hay {conMasDeCincoCaracteres} nombres con más de 5 caracteres.");


// ● Concatenar todos los nombres de la lista names en una sola cadena separada por
// espacios.
var concatenar = string.Join(" ", names);
Console.WriteLine(concatenar);

// ● Encontrar y mostrar el nombre más largo en la lista names
var masLargo = names.OrderByDescending(name => name.Length).FirstOrDefault();
Console.WriteLine($"El nombre más largo es: {masLargo}");

List<string> words = new List<string> { "apple", "banana", "cherry", "date", "elderberry" };

// ● Verificar si todas las palabras en la lista words tienen más de 3 caracteres.
var masDe3caracteres = words.Count(word => word.Length > 3);
Console.WriteLine($"Hay {masDe3caracteres} palabras con más de 3 caracteres.");

// ● Encontrar y mostrar la primera palabra en la lista words que empieza con la letra 'b'.
var primera = words.Where(word => word.StartsWith("b")).FirstOrDefault();
Console.WriteLine($"la primera palabra de la lista que empieza con la letra b es {primera}");

// ● Contar cuántas palabras en la lista words contienen la letra 'e'.
var conLetraE = words.Count(word => word.Contains("e"));
Console.WriteLine($"las palabras que contienen la letra 'e' son: {conLetraE}");

// ● Seleccionar todas las palabras en la lista words y convertirlas a mayúsculas.
var mayusculas = words.Select(word => word.ToUpper()).ToList();
foreach (var word in mayusculas)
{
    Console.WriteLine(word);
}

// ● Verificar si alguna palabra en la lista words termina con la letra 'y'.
var terminaConY = words.Where(word => word.EndsWith("y"));
if (terminaConY.Any())
{
    Console.WriteLine("Hay alguna palabra que termina con la letra 'y'.");
}

// SEGUNDA TANDA DE EJERCICIOS CON LISTAS DE NÚMEROS

List<int> data = new List<int> { 2, 5, 1, 6, 3, 8, 4, 7, 9 };
List<int> moreData = new List<int> { 10, 12, 15, 11, 14, 13 };


// *Combinar y ordenar las listas data y moreData de forma ascendente.

var dataOrdenada = data.OrderBy(num => num).ToList();
var moreDataOrdenada = moreData.OrderBy(num => num).ToList();
var combinacionOrdenada = dataOrdenada.Concat(moreDataOrdenada).ToList();

foreach (var num in combinacionOrdenada)
{
    Console.WriteLine(num);
}

// *Calcular la suma de todos los números pares en la lista data.

var pares1 = data.Where(num => num % 2 == 0).ToList();
var sumaPares = pares1.Sum();
Console.WriteLine(sumaPares);

// *Encontrar el número más grande en la lista data.

var numGrande = data.Max(num => num);
Console.WriteLine(numGrande);

// *Unir las listas data y moreData, eliminando los elementos duplicados.

var combinacionDataYmoreData = data.Concat(moreData).Distinct().ToList();
foreach (var num in combinacionDataYmoreData)
{
    Console.WriteLine(num);
}

// *Calcular el promedio de la lista moreData y seleccionar los números en data que son
// mayores que ese promedio.

var promMoreData = moreData.Average();
Console.WriteLine($"El promedio de la lista moreData es: {promMoreData}");
var numerosMayoresProm = data.Any(num => num > promMoreData);
Console.WriteLine($"los numeros en data mayores que el promedio son: {numerosMayoresProm}");


// *Contar cuántos números en la lista moreData son números primos(te recomiendo crear
// una función independiente que valide si el número es primo o no lo es, luego esa funciona
// pasala al método LINQ adecuado)


bool EsPrimo(int num)
{
    if (num <= 1)
        return false;

    for (int i = 2; i * i <= num; i++) // iteramos desde 2 hasta la raíz cuadrada del numero
    {
        if ( num % i == 0)
        return false; // si es divisible por i, no es primo
    }
    return true; // si no se ha encontrado ningún divisor, es primo
}

var NumerosPrimos = moreData.Where(num => EsPrimo(num)).ToList();
Console.WriteLine("numeros primos:");
foreach (var num in NumerosPrimos)
{
    Console.WriteLine(num);
}