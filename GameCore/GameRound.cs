namespace GameCore;
public class GameRound
{
    public Player player1 { get; set; }
    public Player player2 { get; set; }
    public GameRound(Player player1, Player player2)
    {
        this.player1 = player1;
        this.player2 = player2;
    }

    public void PlayRound()
    {
        player1.Hand.RollHand();
        player2.Hand.RollHand();
        Console.WriteLine($"{player1.Name} rolled: {player1.Hand}");
        System.Console.WriteLine($"Player 1 has scored: {ScoreCalculator.CalculateScore(player1.Hand)}");
        Console.WriteLine($"{player2.Name} rolled: {player2.Hand}");
        System.Console.WriteLine($"Player 2 has scored: {ScoreCalculator.CalculateScore(player2.Hand)}");
        // Console.WriteLine($"{player1.Name} has {player1.Hand.HandValue}");
        // Console.WriteLine($"{player2.Name} has {player2.Hand.HandValue}");
        // if (player1.Hand.HandValue > player2.Hand.HandValue)
        // {
        //     Console.WriteLine($"{player1.Name} wins!");
        //     player1.AmountInWallet += 10;
        //     player2.AmountInWallet -= 10;
        // }
        // else if (player1.Hand.HandValue < player2.Hand.HandValue)
        // {
        //     Console.WriteLine($"{player2.Name} wins!");
        //     player2.AmountInWallet += 10;
        //     player1.AmountInWallet -= 10;
        // }
        // else
        // {
        //     Console.WriteLine("It's a tie!");
        // }
        // Console.WriteLine($"{player1.Name} has {player1.AmountInWallet} in their wallet");
        // Console.WriteLine($"{player2.Name} has {player2.AmountInWallet} in their wallet");
    }

    
    
}