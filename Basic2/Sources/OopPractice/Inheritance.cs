namespace Basic2.Sources.OopPractice;

public class Inheritance
{
    public void Run()
    {
        var terminalX = new ModelXTerminal("123");
        terminalX.Connect();

        var terminalY = new ModelYTerminal("321");
        terminalY.Connect();

        Console.ReadLine();
    }
}

internal class BankTerminal
{
    protected string id;

    public BankTerminal(string id)
    {
        this.id = id;
    }

    public virtual void Connect()
    {
        Console.WriteLine("General connecting protocol");
    }
}

internal class ModelXTerminal : BankTerminal
{
    public ModelXTerminal(string id) : base(id)
    {
    }

    public override void Connect()
    {
        base.Connect();

        Console.WriteLine("Additional actions for Model X");
    }
}

internal class ModelYTerminal : BankTerminal
{
    public ModelYTerminal(string id) : base(id)
    {
    }

    public override void Connect()
    {
        Console.WriteLine("Additional actions for Model Y");
    }
}