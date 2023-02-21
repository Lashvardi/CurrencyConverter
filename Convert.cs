using InputCurrency;
namespace convert;
using System;
public class Convertation

{
    public static void Converter()
    {
        int selectedOption = 1;
        int inputedCurr = Curr.Input();

        string Currency = "";
        while (true)
        {
            Console.Clear();
            Console.WriteLine("━━━━━━━━━━━━━━━━━");
            Console.WriteLine("│Choose Currency│");
            Console.WriteLine("━━━━━━━━━━━━━━━━━");


            Console.ForegroundColor = selectedOption == 1 ? ConsoleColor.Green : ConsoleColor.Gray;
            Console.WriteLine("$");

            Console.ForegroundColor = selectedOption == 2 ? ConsoleColor.Green : ConsoleColor.Gray;
            Console.WriteLine("€");

            Console.ForegroundColor = selectedOption == 3 ? ConsoleColor.Green : ConsoleColor.Gray;
            Console.WriteLine("₽");

            Console.ForegroundColor = ConsoleColor.Gray;
            ConsoleKeyInfo pressedKey = Console.ReadKey();
            Press(pressedKey, ref selectedOption);

            if (pressedKey.Key == ConsoleKey.Enter)
            {
                switch (selectedOption)
                {
                    case 1:
                        Currency = "$";
                        double ConvertedUSD = Math.Round(inputedCurr / 2.64, 2, MidpointRounding.AwayFromZero);
                        Console.WriteLine($"{inputedCurr} ₾ In {Currency} Will Be {ConvertedUSD}");
                        break;
                    case 2:
                        Currency = "€";
                        double convertedEuro = Math.Round(inputedCurr / 2.82, 2, MidpointRounding.AwayFromZero);
                        Console.WriteLine($"{inputedCurr} ₾ In {Currency} Will Be {convertedEuro}");
                        break;
                    case 3:
                        Currency = "₽";
                        double ConvertedRub = Math.Round(inputedCurr * 28.27, 2, MidpointRounding.AwayFromZero);
                        Console.WriteLine($"{inputedCurr} ₾ In {Currency} Will Be {ConvertedRub}");
                        break;
                }
                Console.WriteLine();
                Console.ReadKey();
            }

        }

        void Press(ConsoleKeyInfo pressedKey, ref int selectedOption)
        {
            if (pressedKey.Key == ConsoleKey.UpArrow)
                selectedOption--;
            else if (pressedKey.Key == ConsoleKey.DownArrow)
                selectedOption++;
            selectedOption = selectedOption < 1 ? 3 : selectedOption > 3 ? 1 : selectedOption;
        }

    }
}