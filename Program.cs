//Declarar variable de los diferentes tipos
//asignarles valor e imprimir el valor.

using System.Data;

string name = "Awdry";
int age = 19;
double height = 1.64;
decimal weight = 9.8m;
bool impretty = true;

Console.WriteLine($"nombre: {name}");
Console.WriteLine($"edad: {age}");
Console.WriteLine($"altura: {height}");
Console.WriteLine($"Peso: {weight}");
Console.WriteLine($"¿Soy bonita? {impretty}");

//Declara una constante en C# e imprimir el valor.

const double pi = 3.14;
Console.WriteLine($"El valor de pi es: {pi}");
//pi = 3.14159; 

//Declara un entero,
//incrementarlo, decrementarlo,
//hacer operaciones con el.

int number = 23;
number++;
Console.WriteLine($"Numero Incrementando: {number}");
number--;
Console.WriteLine($"Numero Decrementando {number}");
int sum = number + 20;
int difference = number - 5;
int product = number * 2;
int quotient = number / 3;
Console.WriteLine($"Suma= {sum}");
Console.WriteLine($"Resta= {difference}");
Console.WriteLine($"Multiplicacion= {product}");
Console.WriteLine($"Division= {quotient}");