namespace csharp_practice.Sources.InterfacesPractice
{
    public class Triangle : ShapeMultiAngle
    {
        public override string Name { get; } = "Triangle";
        public override int Points { get; } = 3;

        public override void Draw()
        {
            Console.WriteLine($"Draw shape {this.Name}");
        }
    }
}
