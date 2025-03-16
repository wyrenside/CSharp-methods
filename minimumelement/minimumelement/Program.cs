namespace minimumelement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Array = {21,38,23,17,19,44,64};

            int minElement = minnimum.Min(Array);

            Console.WriteLine("Smallest number of the given array is: " + minElement);
        }
    }
}
