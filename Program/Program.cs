using System.Security;

namespace Program
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newLocation)
        {
            if (newLocation == null)
                throw new ArgumentNullException("newLocation");

            Move(newLocation.X, newLocation.Y);
        }
    }
    public class Calculator
    {
        public int Add(params int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            var result = int.TryParse("abc", out number);
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Failed");
        }

        static void useParams()
        {
            var calculator = new Calculator();
            calculator.Add(1, 2);
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4 }));

        }

        static void usePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                Console.WriteLine("Point is at ({1}, {0})", point.x, point.y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({1}, {0})", point.x, point.y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured");
            }

        }
    }
}