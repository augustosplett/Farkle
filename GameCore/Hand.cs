namespace GameCore;

public class Hand{
    public List<Dice> Dices { get; set; }

    public Hand(List<Dice> dices){
        Dices = dices;
    }

    public void RollHand(){
        foreach (var dice in Dices){
           dice.Roll();
        }
    }

    public override string ToString()
    {
        return string.Join(", ", Dices.Select(d => d.Face));
    }

}