using Lab5CSharp.Task1;
using Lab5CSharp.Task3;
class Program
{

    public static void Task1AndTask2() 
    {
        List<Transport> transports = new List<Transport>()
        {
            new Car(4, 200, 5),
            new Train(10, 100, 100),
            new ExpressTrain(100, 10, 200, 100)
        };
        transports.ForEach(x => x.Show());
        
        ExpressTrain express = new ExpressTrain(100, 10, 200, 100);
        ExpressTrain anotherExpress = null;
        anotherExpress = (ExpressTrain)express.Clone();
        Console.WriteLine("Express foreach");
        foreach (var item in anotherExpress)
        {
            Console.WriteLine(item);
        }
    }

    public static void Task3()
    {
        List<IFigure> figures = new List<IFigure>();
        Console.WriteLine("How many figures do you want to create?");
        int count = int.Parse(Console.ReadLine());
        while (count > 0)
        {
            Console.WriteLine("What kind of figure do you want to create? (1 - Circle, 2 - Rectangle, 3 - Triangle)");
            int figureType = int.Parse(Console.ReadLine());
            switch (figureType)
            {
                case 1:
                    Console.WriteLine("Enter radius");
                    double radius = double.Parse(Console.ReadLine());
                    figures.Add(new Circle(radius));
                    break;
                case 2:
                    Console.WriteLine("Enter width");
                    double width = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter height");
                    double height = double.Parse(Console.ReadLine());
                    figures.Add(new Rectangle(width, height));
                    break;
                case 3:
                    Console.WriteLine("Enter side A");
                    double sideA = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter side B");
                    double sideB = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter side C");
                    double sideC = double.Parse(Console.ReadLine());
                    figures.Add(new Triangle(sideA, sideB, sideC));
                    break;
                default:
                    Console.WriteLine("Wrong figure type");
                    break;
            }
            count--;
        }
        foreach (var figure in figures)
        {
            figure.Print();
        }

    }
   
        
    static void Main(string[] args)
    {
        Task1AndTask2();
        GC.Collect();
        GC.WaitForPendingFinalizers();
        Task3();
    }
    
}
