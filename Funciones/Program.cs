
// Funciones
int ReadNumber(string message = "Introduce un número: ")
{
    int number = 0;
    do
    {
        Console.Write(message);
        string? reader = Console.ReadLine();

        try
        {
            if (reader != null)
            {
                number = int.Parse(reader);
                break;
            }
            else
            {
                Console.WriteLine("No se admiten valores nulos");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    } while (true);

    return number;

} // ReadNumber

int Sumar(int a, int b)
{
    int resultado = a + b;
    return resultado;
} // Sumar


// Inicio del programa
int sumando1 = ReadNumber();
int sumando2 = ReadNumber("Introduce el sumando 2: ");

int suma = Sumar(sumando1, sumando2);
Console.WriteLine($"La suma de {sumando1} y {sumando2} es {suma}");