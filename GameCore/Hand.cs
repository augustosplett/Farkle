namespace GameCore;

public class Hand{
    private List<Dice> _dices;

    public Hand(List<Dice> dices){
        _dices = dices;
    }

    public void RollHand(){
        foreach (var dice in _dices){
           dice.Roll();
        }
    }

    public override string ToString()
    {
        return string.Join(", ", _dices.Select(d => d.Face));
    }

}