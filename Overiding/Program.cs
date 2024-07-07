namespace Overiding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AreaOfShapes areaSqaure = new AreaOfShapes();
            double a = 10.00;
            double b = 10.00;
            double area = 0.0;
            area = areaSqaure.Sqaure(a, b);

            Console.WriteLine("Area of a sqaure: {0}", area);
            Console.ReadLine();
        }
    }
}
