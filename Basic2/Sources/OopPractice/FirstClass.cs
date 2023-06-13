namespace Basic2.Sources.OopPractice;

public class FirstClass
{
    public void Run()
    {
        Character c = new Character();
        c.Hit(10);

        Console.WriteLine(c.Health);
    }
}

internal class Character
{
    // private int _health = 100;
    //
    // public int Health
    // {
    //     get => _health;
    //     private set => _health = value;
    // }
    //
    // === OR ===
    //
    // public int Health
    // {
    //     get { return _health; }
    //     private set { _health = value; }
    // }

    public int Health { get; private set; } = 100;

    // After compilation
    //
    // private int _health = 100;
    //
    // public int GetHealth()
    // {
    //     return _health;
    // }
    //
    // private void SetHealth(int value)
    // {
    //     _health = value;
    // }

    public void Hit(int damage)
    {
        if (damage > Health)
        {
            damage = Health;
        }

        Health -= damage;
    }
}