namespace Basic2.Sources.DelegatesEvents;

public class DelegateEvents
{
    private Car car;

    public void Run()
    {
        car = new Car();
        car.RegisterTooFast(HandleOnTooFast);

        car.Start();

        for (int i = 0; i < 10; i++)
        {
            car.Accelerate();
        }
    }

    private void HandleOnTooFast(int speed)
    {
        Console.WriteLine($"Oh, I got it, calling stop! Current speed={speed}");
        car.Stop();
    }
}

public class Car
{
    public delegate void TooFast(int currentSpeed);

    private int _speed = 0;
    private TooFast _tooFast;

    public void Start()
    {
        _speed = 10;

        if (_speed > 80)
        {
            _tooFast(_speed);
        }
    }

    public void Stop()
    {
        _speed = 0;
    }

    public void Accelerate()
    {
        _speed += 10;
    }

    public void RegisterTooFast(TooFast tooFast)
    {
        _tooFast = tooFast;
    }
}