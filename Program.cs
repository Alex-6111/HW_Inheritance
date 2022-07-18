
namespace HW_Inheritance
{
    internal class Program
    {
        static void Main()
        {

            //Problem1();
            //Problem2();
            //Problem3();
            Problem4();

        }

        public static void Problem1()
        {
            var testHuman = new Human("Ivan", "Ivanov", 20);
            testHuman.TypeInformation();
            testHuman.OutInfo();

            Console.WriteLine();

            var testBuilder = new Builder("Petro", "Mostavchuk", 26, "Painter");
            testBuilder.TypeInformation();
            testBuilder.OutInfo();

            Console.WriteLine();

            var testSailor = new Sailor("Andriy", "Shevchenko", 55, "Captain");
            testSailor.TypeInformation();
            testSailor.OutInfo();

            Console.WriteLine();

            var testPilot = new Pilot("Boris", "Melnik", 40, "High");
            testPilot.TypeInformation();
            testPilot.OutInfo();
        }

        public static void Problem2()
        {
            var testPassport = new Passport("Ivanov", "Ivan", "Ivanovich", "Lviv", "1991.07.21");
            testPassport.TypeInformation();
            testPassport.OutInfo();

            Console.WriteLine();

            var testForeignPassport = new ForeignPassport("Lebiga", "Mykhailo", "Petrovich", "Chernivtsy", "1998.09.15", "Germany", 94131);
            testForeignPassport.TypeInformation();
            testForeignPassport.OutInfo();
        }

        public static void Problem3()
        {
            var testAnimal = new Animal();
            testAnimal.TypeInformation();
            testAnimal.OutInfo();

            Console.WriteLine();

            var testTiger = new Tiger();
            testTiger.TypeInformation();
            testTiger.OutInfo();

            Console.WriteLine();

            var testKangaroo = new Kangaroo();
            testKangaroo.TypeInformation();
            testKangaroo.OutInfo();
        }

        public static void Problem4()
        {
            List<Figure> shapes = new List<Figure>();

            shapes.Add(new Trapeze(10, 100, 5));
            shapes.Add(new Circle(5));
            shapes.Add(new Rectangle(5, 5));
            shapes.Add(new Trapeze(5, 5, 5));
            shapes.Add(new RectangularTriangle(5, 10));
            shapes.Add(new Rectangle(10, 5));
            shapes.Add(new RectangularTriangle(25, 15));
            shapes.Add(new Trapeze(10, 1, 25));
            shapes.Add(new Rectangle(10, 5));

            Console.WriteLine("Array currently contains:");

            int index = 0;
            foreach (var s in shapes)
            {
                Console.WriteLine("{0}) {1} with area = {2:f3}", index++, s.GetType().Name, s.CalculateArea());
            }

        }
    }
}