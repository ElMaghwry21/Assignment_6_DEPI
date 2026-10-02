namespace Assignment_6_DEPI
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- 1. First Project: Point3D Tests ---
            Console.WriteLine("--- First Project: Point3D ---");
            Point3D P = new Point3D(10, 10, 10);
            Console.WriteLine(P.ToString()); // Output: Point Coordinates: (10, 10, 10)

            // قراءة نقطتين من المستخدم
            Console.WriteLine("Enter coordinates for P1 (X Y Z):");
            string[] input1 = Console.ReadLine().Split(' ');
            Point3D P1 = new Point3D(int.Parse(input1[0]), int.Parse(input1[1]), int.Parse(input1[2]));

            Console.WriteLine("Enter coordinates for P2 (X Y Z):");
            string[] input2 = Console.ReadLine().Split(' ');
            Point3D P2 = new Point3D(int.Parse(input2[0]), int.Parse(input2[1]), int.Parse(input2[2]));

            // تجربة المقارنة والـ Cloning
            Point3D clonedPoint = (Point3D)P1.Clone();
            Console.WriteLine($"Cloned Point: {clonedPoint}");

            // --- 2. Second Project: Maths Tests ---
            Console.WriteLine("\n--- Second Project: Maths ---");
            // استدعاء الدوال مباشرة بدون إنشاء كائن (Static Methods)
            Console.WriteLine($"Add: {Maths.Add(10, 5)}");
            Console.WriteLine($"Subtract: {Maths.Subtract(10, 5)}");
            Console.WriteLine($"Multiply: {Maths.Multiply(10, 5)}");
            Console.WriteLine($"Divide: {Maths.Divide(10, 5)}");

            // --- 3. Third Project: Duration Tests ---
            Console.WriteLine("\n--- Third Project: Duration ---");
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString()); // Hours: 1, Minutes :10, Seconds :15

            Duration D2 = new Duration(3600);
            Console.WriteLine(D2.ToString()); // Hours: 1, Minutes :0, Seconds :0

            Duration D3 = new Duration(666);
            Console.WriteLine(D3.ToString()); // Minutes :11, Seconds :6

            Console.ReadKey();
        }
    }
}