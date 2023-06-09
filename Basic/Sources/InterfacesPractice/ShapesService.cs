namespace csharp_practice.Sources.InterfacesPractice
{
    public static class ShapesService
    {
        public static int GetPointsNumber(IPoints[] shapes)
        {
            int result = 0;

            foreach (IPoints shape in shapes)
            {
                result += shape.Points;
            }

            return result;
        }

        public static IPoints GetShapeWithMaxPoints(IPoints[] shapes)
        {
            int maxPoints = shapes[0].Points;

            IPoints result = shapes[0];

            foreach (IPoints shape in shapes)
            {
                if (shape.Points > maxPoints)
                {
                    result = shape;
                    maxPoints = shape.Points;
                }
            }

            return result;
        }
    }
}
