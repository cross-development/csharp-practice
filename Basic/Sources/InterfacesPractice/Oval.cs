namespace csharp_practice.Sources.InterfacesPractice
{
    public class Oval : ShapeWithoutAngle
    {
        public override string Name { get; } = "Oval";

        public override void Draw()
        {
            Console.WriteLine($"Draw shape {this.Name}");
        }
    }
}
