namespace DiceRollGame.Game;

public class Dice(Random random)
{
    private const int MinValue = 1;
    private const int MaxValue = 6;

    public int Roll()
    {
        return random.Next(MinValue, MaxValue + 1);
    }

}
