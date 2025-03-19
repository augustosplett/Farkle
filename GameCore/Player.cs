namespace GameCore;

public class Player
{
    public string Name { get; init; }
    public Hand Hand { get; init; }
    public int AmountInWallet { get; private set; }
    public Player(string name)
    {
        Name = name;
        Hand hand = new Hand(
            new List<Dice> { 
                new Dice(), 
                new Dice(),
                new Dice(),  
                new Dice(), 
                new Dice(), 
                new Dice() 
            }
        );
        Hand = hand;
        AmountInWallet = 50;
    }
}