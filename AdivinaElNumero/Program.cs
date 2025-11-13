
using System.Diagnostics;

#region Funciones

void Init()
{
    Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.Clear();

    string title = @"                                                
     /\      | (_)     (_)                      
    /  \   __| |___   ___ _ __   __ _           
   / /\ \ / _` | \ \ / / | '_ \ / _` |          
  / ____ \ (_| | |\ V /| | | | | (_| |          
 /_/   _\_\__,_|_| \_/ |_|_| |_|\__,_|          
      | |                                
   ___| |  _ __  _   _ _ __ ___   ___ _ __ ___  
  / _ \ | | '_ \| | | | '_ ` _ \ / _ \ '__/ _ \ 
 |  __/ | | | | | |_| | | | | | |  __/ | | (_) |
  \___|_| |_| |_|\__,_|_| |_| |_|\___|_|  \___/ 

Se ha generado un número aleatorio entre 1 y 100

  ¡¡¡Encuéntralo lo más rápidamente posible!!!
";
    Console.WriteLine(title);

} // Init

int Game()
{
    int secretNumber = new Random().Next(1, 101); // [1..100]
    int playerNumber = 0;
    int time = 0;

    Stopwatch stopwatch = Stopwatch.StartNew();

    while (playerNumber != secretNumber)
    {
        Console.Write("Escribe un número: ");
        string? reader = Console.ReadLine();

        if (int.TryParse(reader, out playerNumber))
        {
            if (playerNumber == secretNumber)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"¡Bravo! Lo has adivinado en {stopwatch.Elapsed.Seconds} segundos.");
                Console.ForegroundColor = ConsoleColor.Black;

                time = stopwatch.Elapsed.Seconds;
            }
            else
            {
                Console.WriteLine(playerNumber < secretNumber ? "Más alto" : "Más bajo");
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Entrada no válida. Escribe un número.");
            Console.ForegroundColor = ConsoleColor.Black;
        }

    } // while (playerNumber != secretNumber)

    return time;

} // Game

int GameLoop()
{
    int bestTime = int.MaxValue;
    do
    {
        int time = Game();
        if (time < bestTime)    
        {
            bestTime = time;
        }

        Console.Write("¿Quieres Jugar otra vez? (s/n): ");
        string? response;
        do
        {
            response = Console.ReadLine();
            if (response == "n")
            {
                break;
            }
            else if (response != "s")
            {
                Console.Write("¿Quieres Jugar otra vez? Introduce solo (s/n): ");
            }

        } while (response != "n" && response != "s");

        if (response == "n")
        {
            break;
        }

    } while (true);

    return bestTime;

} // GameLoop

void Main()
{
    Init();

    int mejorTiempo = GameLoop();
    Console.WriteLine($"Tu mejor tiempo ha sido {mejorTiempo} segundos.");

} // Main

#endregion

// ------------------------------------------------ //

// Programa
Main();


