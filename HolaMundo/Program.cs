// See https://aka.ms/new-console-template for more information

/*
bool active = false;
Console.WriteLine("La variable active es igual a " + active);
active = true;
Console.WriteLine("La variable active es igual a " + active);
*/
/*
string msg;
Console.Write("Escribe algo: ");
msg = Console.ReadLine();
Console.WriteLine("Estupendo " + msg);
*/
/*
Console.Write("¿Cuanto mides? ");
string? readEstatura = Console.ReadLine();
float estatura = Convert.ToSingle(readEstatura);
Console.WriteLine("Mides " + estatura);
*/
/*
Console.Write("¿Cuantos años tienes? ");
string readEstatura = Console.ReadLine();
int edad = Convert.ToInt32(readEstatura);
int Currentyeard = DateTime.Now.Year;
int edaden50 = 2050 - Currentyeard;
Console.WriteLine("En 2050 tendre " + (edaden50 + edad) + " años");
*/
/*
Console.Write("¿Cuanto mides? ");
string readEstatura = Console.ReadLine();
string readEstaturaCorregido = readEstatura.Replace(".", ",");
float estatura = Convert.ToSingle(readEstaturaCorregido);
Console.WriteLine("Mides " + estatura);
*/

/*
// igual
bool resultado = (10 == 5);
// mayor menor
resultado = 10 > 5;
// distinto
resultado = 10 != 5;

Console.WriteLine("Operador AND");
bool test = false && false;
Console.WriteLine($"false && false = {test}");
test = false && true;
Console.WriteLine($"false && true = {test}");
test = true && false;
Console.WriteLine($"true && false = {test}");
test = true && true;
Console.WriteLine($"true && true = {test}");

Console.WriteLine("Operador OR");
test = false || false;
Console.WriteLine($"false || false = {test}");
test = false || true;
Console.WriteLine($"false || true = {test}");
test = true || false;
Console.WriteLine($"true || false = {test}");
test = true || true;
Console.WriteLine($"true || true = {test}");

Console.WriteLine("Operador NOT");
test = !false;
Console.WriteLine($"!false = {test}");
test = !true;
Console.WriteLine($"!true = {test}");
*/

/*
 
 comentario

 */
/*

Console.Write("¿Cuantos años tienes? ");
string reader = Console.ReadLine();
int edad = Convert.ToInt16(reader);
Console.Write("¿Eres estudiante? (s/n)");
reader = Console.ReadLine();

bool datosCorrectos = true;
bool estudiante = true;

switch (reader)
{
    case "s":
    case "S":
    case "si":
    case "Si":
    case "SI":
        estudiante = true;
        break;
    case "n":
    case "N":
    case "no":
    case "No":
    case "NO":
        estudiante = false;
        break;
    default:
        Console.WriteLine("Debes de introducir (s/n)");
        datosCorrectos = false;
        break;
}


if (datosCorrectos)
{
    if (edad < 18)
        Console.WriteLine("Puedes tener carnet jóven por ser menor de edad");
    else if (estudiante)
        Console.WriteLine("Puedes tener carnet jóven por ser estudiante");
    else
        Console.WriteLine("No puedes tener carnet jóven, debes de ser menor de edad o estudiante");
}

*/

/*
int contador = 0;
while (contador < 5)
{
    Console.WriteLine(contador);
    contador++;
}
*/

int numero = 0;
bool esNumero = false;
do
{
    Console.WriteLine("Introduce un número");
    string reader = Console.ReadLine();
    esNumero = int.TryParse(reader, out numero);

    if (!esNumero)
        Console.WriteLine($"{reader} no es un valor válido");

} while (!esNumero);

Console.WriteLine($"Has salido del bucle. El número es {numero}");


//Console.ReadLine();

