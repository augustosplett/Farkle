using GameCore;

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

hand.RollHand();

Console.WriteLine(hand);
