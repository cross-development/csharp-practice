namespace csharp_practice.Sources.InterfacesPractice
{
    public class Fiveangle : ShapeMultiAngle, IPoints
    {
        public override int Points { get; } = 5;
        public override string Name { get; } = "Fiveangle";

        public override void Draw()
        {
            Console.WriteLine($"Draw shape {this.Name}");
        }
    }
}
