namespace DiceRollGame.Interface;

public static class ConsoleInterface
{
    public static void Write(string message)
    {
        Console.WriteLine(message);
    }

    public static int ReadNumber(string message = "")
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                return number;
            }
            if (message != "")
            {
                Console.WriteLine(message);
            }
        }
    }

    public static ConsoleKeyInfo ReadKey()
    {
        return Console.ReadKey();
    }
}
