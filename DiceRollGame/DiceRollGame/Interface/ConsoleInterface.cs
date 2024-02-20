namespace DiceRollGame.Interface;

public static class ConsoleInterface
{
    public static void Write(string message)
    {
        Console.WriteLine(message);
    }

    public static int ReadNumber(string message = "")
    {
        int number;
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine(message);
        }
        return number;
    }

    public static ConsoleKeyInfo ReadKey()
    {
        return Console.ReadKey();
    }
}
