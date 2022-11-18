namespace csharp_practice.Sources.InterfacesPractice
{
    public class Interfaces
    {
        public static void Run1()
        {
            string[] arr1 = { "a", "b", "c" };
            string[] arr2 = (string[])arr1.Clone();

            foreach (string str in arr2)
            {
                Console.WriteLine($"Str: {str}");
            }

            ICloneable[] clones = { new B(), arr1, arr2, new int[] { 1, 2, 3, 4, 5 } };

            foreach (ICloneable clone in clones)
            {
                clone.Clone();
            }

            // =====================================
            Shape[] arr3 = { new Oval(), new Triangle() };

            foreach (Shape shape in arr3)
            {
                PrintInfo(shape);
            }

            // =====================================
            IPoints[] arr4 = { new Triangle(), new Triangle() };

            foreach (IPoints shape in arr4)
            {
                Console.WriteLine($"Shape with {shape.Points} angles");
            }
        }

        public static void Run()
        {
            IPoints[] points = { new Triangle(), new Fiveangle(), new Triangle() };

            int totalPoints = ShapesService.GetPointsNumber(points);
            Console.WriteLine($"Total shapes points {totalPoints}");

            IPoints shapeWithMaxPoints = ShapesService.GetShapeWithMaxPoints(points);

            if (shapeWithMaxPoints is Shape)
            {
                Console.WriteLine(
                    $"Shape with max points - {((Shape)shapeWithMaxPoints).Name}, and has {shapeWithMaxPoints.Points} points"
                );
            }
            else
            {
                Console.WriteLine($"An object has been found. Points {shapeWithMaxPoints.Points}");
            }
        }

        static void PrintInfo(Shape shape)
        {
            Console.WriteLine($"Shape name {shape.Name}");
            shape.Draw();
            Console.WriteLine("\n");
        }
    }

    abstract class A
    {
        public int Prop1 { get; set; }

        public abstract void Test();
    }

    class B : A, ICloneable
    {
        public object Clone()
        {
            throw new NotImplementedException();
        }

        public override void Test()
        {
            throw new NotImplementedException();
        }
    }
}
