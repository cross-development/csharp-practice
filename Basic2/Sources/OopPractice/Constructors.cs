namespace Basic2.Sources.OopPractice;

public class Constructors
{
    public void Run()
    {
        var character = new CharacterOne("Elf");
        Console.WriteLine(character.Race);
        Console.WriteLine(character.Armor);
    }
}

internal struct Point
{
    public readonly Point2D Point2D;

    // But we can do it inside the constructor
    public Point()
    {
        this.Point2D = new Point2D(1, 2);
    }

    // Error - we can not initialize readonly field in any mathods
    // public void Do()
    // {
    //     Point2D = new Point2D();
    // }
}

internal class Point2D
{
    private readonly int x;
    private readonly int y;

    public Point2D(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

internal class CharacterOne
{
    /*
     * const - compiler during compilation will replace all const vars with the value of the const var
     * readonly - compiler during compilation will access to the readonly var directly without replacing
     */

    // private const int speed = 10;
    // private readonly int speed = 10;
    private readonly int speed;
    public int Health { get; set; } = 100;
    public string Race { get; private set; }
    public int Armor { get; private set; }

    public CharacterOne(string race)
    {
        Race = race;
        Armor = 30;
    }

    public CharacterOne(string race, int armor)
    {
        Race = race;
        Armor = armor;
    }

    public CharacterOne(string race, int armor, int speed)
    {
        Race = race;
        Armor = armor;
        this.speed = speed;
    }
}