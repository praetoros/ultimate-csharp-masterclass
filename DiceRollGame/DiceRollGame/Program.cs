using DiceRollGame.Game;
using DiceRollGame.Interface;

Random random = new();
Dice dice = new(random);
GuessingGame game = new(3, dice);
GameResult result = game.Play();
GuessingGame.PrintResult(result);

ConsoleInterface.ReadKey();
