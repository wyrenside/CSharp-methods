using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace minimumelement
//{
//    //class minnimum
//    //{
//    //    //public static int Min(int[] numbers)
//    //    //{
//    //    //    int min = numbers[0];

//    //    //    for (int i = 1; i < numbers.Length; i++)
//    //    //    {
//    //    //        if (numbers[i] < min)
//    //    //        {
//    //    //            min = numbers[i];
//    //    //        }
//    //    //    }
//    //    //    return min;
//    //    //}
//    //}

//}
namespace areaoffigures
{
    class areaofgivenfigures
    {
        public static double Area(double r)
        {
            double p = 3;
            return p * r * r;
        }
        public static double Area(int a, int b)
        {
            return a * b;
        }
        public static double Area(int a, int b, int c)
        {
            return 2 * (a * b + a * c + b * c);
        }
        public static double Area(double a, double b, double c, double r)
        {
            double p = (a + b + c) / 2;
            return p * r;
        }
    }
}

