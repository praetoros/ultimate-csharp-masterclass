using DiceRollGame.Interface;

namespace DiceRollGame.Game;

public class GuessingGame(int remainingGuesses, Dice dice)
{
    public GameResult Play()
    {
        int diceRollResult = dice.Roll();
        ConsoleInterface.Write($"Dice Rolled. Guess what number it shows in {remainingGuesses} tries:");
        while (remainingGuesses > 0)
        {
            ConsoleInterface.Write("Enter your guess:");
            int guess = ConsoleInterface.ReadNumber("Invalid input. Please enter a number between 1 and 6 inclusive.");
            if (guess == diceRollResult)
            {
                return GameResult.Victory;
            }
            if (remainingGuesses > 1)
            {
                ConsoleInterface.Write("Incorrect guess. Try again.");
            }
            --remainingGuesses;
        }

        return GameResult.Loss;
    }

    public static void PrintResult(GameResult result)
    {
        ConsoleInterface.Write(result switch
        {
            GameResult.Victory => "You won!",
            GameResult.Loss => "You lost!",
            _ => "Invalid result"
        });
    }
}
