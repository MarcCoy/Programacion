#region Library
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

bool ReadBool(string message = "(s/n): ")
{
    bool result = false;
    do
    {
        Console.Write(message);
        string? reader = Console.ReadLine();

        try
        {
            if (reader != null)
            {
                if (reader.ToLower() == "s")
                {
                    result = true;
                    break;
                }
                else if (reader.ToLower() == "n")
                {
                    result = false;
                    break;
                }
            }
            
            Console.WriteLine("Introduce (s/n)");
            
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    } while (true);

    return result;

} // ReadNumber
#endregion


// Inicialización, reserva de memoria
void PracticaArray1()
{
    // Declaración de Array de enteros
    int[] test;

    // Reserva de memoria para 5 elementos de tipo int
    // e inicialización de valores estática
    test = new int[] { 20, 30, 50, 60, 0 };

    // Inicialización de valores del array de forma dinámica
    // test[0] = 20; test[1] = 30; etc...

    try
    {
        Console.WriteLine(test[5]);
    }
    catch (Exception ex) 
    {
        Console.WriteLine(ex.Message);
    }

} // PracticaArray1


void PracticaArray2()
{
    int[] test = new int[50];

    Random random = new Random();

    for (int i = 0; i < test.Length; i++)
    {
        test[i] = random.Next(1, 666);
        Console.WriteLine($"El índice {i} tiene el valor {test[i]}");
    }

} // PracticaArray2


void PracticaArray3()
{
    string[] week = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };
    bool[] worKDay = new bool[week.Length];
    int [] hours = new int[week.Length];

    for (int i = 0; i < week.Length; i++)
    {
        worKDay[i] = ReadBool($"¿El {week[i]} es un día laborable? (s/n)");
        if (worKDay[i])
        {
            hours[i] = ReadNumber($"¿Cuantas horas se trabaja el {week[i]}?");
        }
        else
        {
            hours[i] = 0;
        }
    }
    Console.WriteLine();

    for (int i = 0; i < week.Length; i++)
    {
        string laborable = worKDay[i] ? "Si" : "No";

        Console.WriteLine($"Día: {week[i]} - Laborable: {laborable} - Horas: {hours[i]}");
    }

} // PracticaArray3

// PROGRAMA
// Array 1
// PracticaArray1();

// Array 2
// PracticaArray2();

PracticaArray3();