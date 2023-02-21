namespace InputCurrency;

public class Curr
{
    public static int Input()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Enter Currency: In GEL (LARI)");
        Console.ForegroundColor = ConsoleColor.White;

        int inputedCurr = 0;
        bool isValidInput = false;

        while (!isValidInput)
        {
            try
            {
                inputedCurr = int.Parse(Console.ReadLine());
                isValidInput = true;
            }
            catch (FormatException ex)
            {
                Console.WriteLine();
                Console.WriteLine("Please Enter Value In Numbers");
            }
        }

        return inputedCurr;
    }
}
