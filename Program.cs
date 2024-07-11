// TALLER PRÁCTICO LINQ

// EJERCICIOS SOBRE LISTAS DE NÚMEROS
List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

// ● Filtrar y mostrar solo los números pares de la lista numbers.
var pares = numbers.Where(number => number % 2 == 0).ToList();
foreach (var par in pares)
{
    Console.WriteLine(par);
}

// ● Usando LINQ, calcular la suma de todos los números impares en la lista numbers.
var impares = numbers.Where(number => number % 2!= 0).ToList();
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
List<string> names = new List<string> {"Alice", "Bob", "Charlie", "David", "Eve" };

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

List<string> words = new List<string> {"apple", "banana", "cherry", "date", "elderberry"};

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