namespace GameCore;

public class Dice{
    public int Face { get; set; }
    public int Roll()
    {
        Face = new Random().Next(1, 7);
        return Face;
    }
}