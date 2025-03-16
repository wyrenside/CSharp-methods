//namespace minimumelement
//{
//    //internal class Program
//    //{
//    //    //static void Main(string[] args)
//    //    //{
//    //    //    int[] Array = {21,38,23,17,19,44,64};

//    //    //    int minElement = minnimum.Min(Array);

//    //    //    Console.WriteLine("Smallest number of the given array is: " + minElement);
//    //    //}
//    //}
//}
namespace areaoffigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double circleArea = areaofgivenfigures.Area(9);
            Console.WriteLine("Area of circle is: " + circleArea);

            double rectangleArea = areaofgivenfigures.Area(4, 5);
            Console.WriteLine("Area of rectangle is: " + rectangleArea);

            double parallelepipedArea = areaofgivenfigures.Area(5, 12, 13);
            Console.WriteLine("Area of parallelepiped is: " + parallelepipedArea);

            double triangleCircleArea = areaofgivenfigures.Area(3.5, 2.5, 4.5, 5.5);
            Console.WriteLine("Area of triangle is: " + triangleCircleArea);
        }
    }
}
