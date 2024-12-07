using System;
using System.Collections.Generic;

namespace TestSoloLearn
{
    //class User
    //{
    //    public string name, location;
    //    // Default Constructor
    //    public User()
    //    {
    //        name = "Suresh Dasari";
    //        location = "Hyderabad";
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // The constructor will be called automatically once the instance of the class created
    //        User user = new User();
    //        Console.WriteLine(user.name);
    //        Console.WriteLine(user.location);
    //        Console.WriteLine("\nPress Enter Key to Exit..");
    //        Console.ReadLine();
    //    }
    //}
    //    class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            string[] finalists = { "James Van", "John Smith", "Leyla Brown", "Tom Homerton", "Bob Douglas" };

    //            int winner = Convert.ToInt32(Console.ReadLine());

    //            //this should show the winner and "Game Over"
    //            FinalRound finalRound = new FinalRound(finalists, winner);
    //        }
    //    }

    //    class FinalRound
    //    {
    //        public FinalRound(string[] finalists, int winner)
    //        {
    //            //complete the constructor
    //            Console.WriteLine("Winner is " + finalists);
    //        }

    //         ~FinalRound()
    //        {
    //            Console.WriteLine("Game Over");
    //        }

    //}

    //    class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            int count = Convert.ToInt32(Console.ReadLine());

    //            int[] numbers = new int[count];

    //            for (int i = 0; i < count; i++)
    //            {
    //                numbers[i] = Convert.ToInt32(Console.ReadLine());
    //            }

    //            Array.Sort(numbers);
    //            foreach (int item in numbers)
    //            {
    //                Console.WriteLine(item);
    //            }
    //        }
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        MusicGenres genres = new MusicGenres();

    //        int count = 0;
    //        while (count < 5)
    //        {
    //            genres[count] = Console.ReadLine();
    //            count++;
    //        }

    //        for (int i = 0; i < 5; i++)
    //        {
    //            Console.WriteLine("Following: " + genres[i]);
    //        }
    //    }
    //}
    //class MusicGenres
    //{
    //    private string[] genres = new string[5];

    //    //declare an indexer

    //    public string this[int index]
    //    {
    //        get
    //        {
    //            return genres[index];
    //        }
    //        set
    //        {
    //            genres[index] = value;
    //        }
    //    }
    //    //public string this[int index]
    //    //{
    //    //    get
    //    //    {
    //    //        return names[index];
    //    //    }
    //    //    set
    //    //    {
    //    //        names[index] = value;
    //    //    }

    //    }

    //class Program
    //{

    //    static void Main(string[] args)
    //    {
    //        Score tm1 = new Score(2, 3);
    //        Score tm2 = new Score(4, 2);

    //        Score finalScores = tm1 + tm2;


    //        Console.WriteLine("Round 1: " + finalScores.round1Score);
    //        Console.WriteLine("Round 2: " + finalScores.round2Score);
    //    }
    //}
    //class Score
    //{
    //    public int round1Score { get; set; }
    //    public int round2Score { get; set; }
    //    public Score(int r1, int r2)
    //    {
    //        round1Score = r1;
    //        round2Score = r2;
    //        int total= round1Score + round2Score;

    //    }

    //    //your code goes here
    //    public static Score operator +(Score r1, Score r2)
    //    {
    //        int res1 = r1.round1Score + r2.round1Score;
    //        int res2 = r1.round2Score + r2.round2Score;
    //        Score res = new Score(res1, res2);
    //        return res;
    //    }

    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string name1 = Console.ReadLine();
    //        int points1 = Convert.ToInt32(Console.ReadLine());
    //        string name2 = Console.ReadLine();
    //        int points2 = Convert.ToInt32(Console.ReadLine());

    //        DancerPoints dancer1 = new DancerPoints(name1, points1);
    //        DancerPoints dancer2 = new DancerPoints(name2, points2);

    //        DancerPoints total = dancer1 + dancer2;
    //        Console.WriteLine(total.name);
    //        Console.WriteLine(total.points);
    //    }
    //}

    //class DancerPoints
    //{
    //    public string name;
    //    public int points;
    //    public DancerPoints(string name, int points)
    //    {
    //        this.name = name;
    //        this.points = points;
    //    }

    //    //overload the + operator
    //   public static DancerPoints operator+(DancerPoints dancer1, DancerPoints dancer2)
    //    {

    //        string name = dancer1.name +" & "+ dancer2.name;
    //        int points = dancer1.points + dancer2.points;
    //        DancerPoints dancer = new DancerPoints(name, points);
    //        return dancer;


    //    }
    //}

    //class Program 
    //{
    //    static void Main(string[] args)
    //    {
    //        string brandName = Console.ReadLine();
    //        string modelName = Console.ReadLine();

    //        Car car = new Car();
    //        car.Brand = brandName;
    //        car.Model = modelName;

    //        car.ShowBrand();
    //        car.ShowModel();
    //    }
    //}
    //class Vehicle
    //{
    //    public string Brand { get; set; }

    //    public void ShowBrand()
    //    {
    //        Console.WriteLine("Brand: " + Brand);
    //    }
    //}

    ////complete the Car class
    //class Car : Vehicle
    //{
    //    public string Model { get; set; }

    //    public void ShowModel()
    //    {
    //        Console.WriteLine("Model: " + Model);

    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string accNumber = Console.ReadLine();
    //        double balance = Convert.ToDouble(Console.ReadLine());

    //        User user = new User(accNumber, balance);

    //        user.ShowDetails();

    //    }
    //}

    //class Account
    //{
    //    protected double Balance { get; set; }
    //}

    //class User : Account
    //{
    //    public string AccNumber { get; set; }

    //    //complete the constructor
    //    public User(string accNumber, double balance)
    //    {
    //        this.AccNumber = accNumber;
    //        Balance = balance ;
    //    }

    //    public void ShowDetails()
    //    {
    //        Console.WriteLine("Account N: " + AccNumber);
    //        Console.WriteLine("Balance: " + Balance);
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        WayStatus status = new WayStatus();
    //    }
    //}
    //class Flight
    //{
    //    public Flight()
    //    {
    //        Console.WriteLine("Registration");
    //    }
    //    ~Flight()
    //    {
    //        Console.WriteLine("Closed");
    //    }
    //}
    ///*derive this class from Flight class,
    //define constructor and destructor for it*/
    //class WayStatus : Flight
    //{
    //    public WayStatus(){
    //        Console.WriteLine("On the way");

    //    }
    // ~WayStatus(){
    //    Console.WriteLine("Landed");

    //}


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Unit unit1 = new Unit();
    //        Unit musketeer = new Musketeer();
    //        Unit magician = new Magician();

    //        unit1.Attack();
    //        musketeer.Attack();
    //        magician.Attack();
    //    }
    //}

    //class Unit
    //{
    //    public virtual void Attack()
    //    {
    //        Console.WriteLine("Using sword!");
    //    }
    //}

    ///*derive the class from Unit class
    //and override Attack() method*/
    //class Musketeer : Unit
    //{
    //    public override void Attack()
    //    {
    //        Console.WriteLine("Using musket!");
    //    }
    //}
    ///*derive the class from Unit class
    //and override Attack() method*/
    //class Magician : Unit
    //{
    //    public override void Attack()
    //    {
    //        Console.WriteLine("Using magic!");
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Figure rectangle = new Rectangle(5, 6);
    //        Figure triangle = new Triangle(4, 8, 3);

    //        Console.WriteLine(rectangle.Perimeter());
    //        Console.WriteLine(triangle.Perimeter());
    //    }
    //}
    //abstract class Figure
    //{
    //    public abstract string Perimeter();

    //}
    //class Rectangle : Figure
    //{
    //    public int width;
    //    public int height;
    //    public Rectangle(int width, int height)
    //    {
    //        this.width = width;
    //        this.height = height;
    //    }
    //    public override string Perimeter()
    //    {
    //        int per = 2 * width + 2 * height;
    //        return per.ToString();

    //    }
    //}
    //class Triangle : Figure
    //{
    //    public int side1;
    //    public int side2;
    //    public int side3;
    //    public Triangle(int s1, int s2, int s3)
    //    {
    //        this.side1 = s1;
    //        this.side2 = s2;
    //        this.side3 = s3;
    //    }

    //    public override string Perimeter()
    //    {
    //        int per = side1 + side2 + side3;
    //        return per.ToString();

    //    }

    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string color = Console.ReadLine();
    //        string equipment = Console.ReadLine();

    //        Car car = new Car(color, equipment);

    //        car.GetColor();
    //        car.GetEquipment();
    //    }
    //}

    //public interface IColor
    //{
    //    void GetColor();
    //}

    //public interface IEquipment
    //{
    //    void GetEquipment();
    //}

    ////implement IColor & IEquipment interfaces
    //public class Car
    //{
    //    public string color;
    //    public string equipment;

    //    public Car(string color, string equipment)
    //    {
    //        this.color = color;
    //        this.equipment = equipment;
    //    }

    //    //reimplement this method
    //    public void GetColor()
    //    {
    //        Console.WriteLine("Color: " + color);
    //    }
    //    //reimplement this method
    //    public void GetEquipment()
    //    {
    //        Console.WriteLine("Equipment :" + equipment);

    //    }
    //}

    //class Car
    //{
    //    string name;
    //    public Car(string nm)
    //    {
    //        name = nm;
    //        Motor m = new Motor();
    //    }
    //    public class Motor
    //    {
    //        // some code
    //    }
    //} SICK !

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Draw pencil = new Draw();
    //        Draw brush = new Brush();
    //        Draw spray = new Spray();

    //        pencil.StartDraw();
    //        brush.StartDraw();
    //        spray.StartDraw();

    //    }
    //}

    /*
    Draw => "Using pencil"
    Brush => "Using brush"
    Spray => "Using spray"
    */

    //public interface IDraw
    //{
    //    void StartDraw();
    //}

    //class Draw : IDraw
    //{
    //    public virtual void StartDraw()
    //    {
    //        Console.WriteLine("Using pencil");
    //    }
    //}

    //class Brush : Draw
    //{
    //    public override void StartDraw()
    //    {
    //        Console.WriteLine("Using brush");
    //    }

    //}

    ////inherit this class from the class Draw
    //class Spray : Draw
    //{
    //    public override void StartDraw()
    //    {
    //        Console.WriteLine("Using spray");
    //    }

    //}


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int length = Convert.ToInt32(Console.ReadLine());
    //        int width = Convert.ToInt32(Console.ReadLine());
    //        int height = Convert.ToInt32(Console.ReadLine());

    //        Cuboid cuboid = new Cuboid(length, width, height);

    //        Console.WriteLine("Volume: " + cuboid.Volume());
    //        Console.WriteLine("Perimeter: " + cuboid.Perimeter());
    //    }
    //}
    //struct Cuboid
    //{
    //    public int length;
    //    public int width;
    //    public int height;

    //    //create a constructor
    //    public Cuboid(int length,int width, int height)
    //    {
    //        this.length = length;
    //        this.width = width;
    //        this.height = height;


    //    }

    //    //complete this method
    //    public int Volume()
    //    {

    //        int volume = length * width * height;
    //        return volume;
    //    }
    //    //complete this method
    //    public int Perimeter()
    //    {
    //        Cuboid cuboid = new Cuboid();
    //        int perimeter = 4*(length + width + height);
    //        return perimeter;
    //    }
    //}


    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        Player player1 = new Player(Difficulty.Easy);
    //        Player player2 = new Player(Difficulty.Medium);
    //        Player player3 = new Player(Difficulty.Hard);


    //    }
    //}

    ///*
    //Easy => "You have 3 minutes 45 seconds"
    //Medium = > "You have 3 minutes 20 seconds"
    //Hard => "You have 3 minutes"
    //*/

    //class Player
    //{
    //    public Player(Difficulty x)
    //    {
    //        switch (x)
    //        {
    //            case Difficulty.Easy:
    //                Console.WriteLine("You have 3 minutes 45 seconds");
    //                break;
    //            case Difficulty.Medium:
    //                Console.WriteLine("You have 3 minutes 20 seconds");

    //                break;
    //            case Difficulty.Hard:
    //                Console.WriteLine("You have 3 minutes");

    //                break;
    //            default:
    //                break;
    //        }

    //    }
    //}
    //enum Difficulty
    //{
    //    Easy,
    //    Medium,
    //    Hard
    //};
    //class Program
    //{


    //    static void Main(string[] args)
    //    {
    //        try
    //        {
    //            int[] arr = new int[] { 4, 5, 8 };
    //            Console.Write(arr[2]);
    //            Console.Write(arr[6]);
    //        }
    //        catch (Exception e)
    //        {
    //            Console.WriteLine(e.Message);
    //        }
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string[] tours = { "England", "Spain", "Italy", "Portugal", "France" };
    //        int choice = Convert.ToInt32(Console.ReadLine());

    //        //your code goes here
    //        try
    //        {
    //            Console.WriteLine(tours[choice]);
    //        }
    //        catch
    //        {
    //            Console.WriteLine("Wrong number");
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Goodbye");
    //        }
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        try
    //        {
    //            int drinks = Convert.ToInt32(Console.ReadLine());
    //            int shelves = Convert.ToInt32(Console.ReadLine());

    //            int total = drinks / shelves;

    //            Console.WriteLine(total);
    //            //your code goes here

    //        }
    //        /*
    //         * 1. DivideByZeroException => "At least 1 shelf"
    //         * 2. FormatException => "Please insert an integer"
    //        */
    //        catch (DivideByZeroException)
    //        {
    //            Console.WriteLine("At least 1 shelf");
    //        }
    //        catch (FormatException)
    //        {
    //            Console.WriteLine("Please insert an integer");
    //        }
    //    }
    //}

    //    class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            string text = Console.ReadLine();
    //            int intNum = Convert.ToInt32(Console.ReadLine());
    //            double doubNum = Convert.ToDouble(Console.ReadLine());


    //            Printer.Print(text,intNum);
    //            Printer.Print(intNum,text);
    //            Printer.Print(doubNum,doubNum);
    //        }
    //    }
    //    class Printer
    //    {
    //public static void Print<T,X>( T a ,X b)
    //        {
    //            Console.WriteLine("Showing " + a+"+"+b);
    //        }
    //        public static void Print2<T>(T a)
    //        {
    //            Console.WriteLine("Showing " + a + "+" + b);
    //        }
    //    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        Elems<string> elems1 = new Elems<string>();
    //        elems1.Add("John", "Tamara", "David");
    //        elems1.Show();

    //        Console.WriteLine();

    //        Elems<int> elems2 = new Elems<int>();
    //        elems2.Add(5, 14, 13);
    //        elems2.Show();

    //    }
    //}
    ////make this class generic
    //class Elems<T>
    //{
    //    public T[] elements = new T[3];

    //    public T[] Add(T elem1,  T elem2,  T elem3)
    //    {
    //        elements[0] = elem1;
    //        elements[1] = elem2;
    //        elements[2] = elem3;

    //        return elements;
    //    }

    //    public void Show()
    //    {
    //        foreach (T item in elements)
    //        {
    //            Console.Write(item + " ");
    //        }
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int numOfPlayers = Convert.ToInt32(Console.ReadLine());


    //        List<int> scores = new List<int>();
    //        int count = 0;
    //        while (count < numOfPlayers)
    //        {
    //            int score = Convert.ToInt32(Console.ReadLine());
    //            scores.Add(score);
    //            count++;
    //        }

    //        scores.Sort();
    //        for (int i = 0; i < scores.Count; i++)
    //        {
    //            Console.Write(" " + scores[i]);
    //        }

    //        //sort the list and output elements

    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Queue<int> q = new Queue<int>();

    //        while (q.Count < 3)
    //        {
    //            int num = Convert.ToInt32(Console.ReadLine());

    //            q.Enqueue(num);

    //        }

    //        Console.Write("Queue: ");
    //        foreach (int i in q)
    //            Console.Write(i + " ");

    //        Console.WriteLine();

    //        Console.Write("Sorted: ");

    //       int[] array= q.ToArray();
    //        Array.Sort(array);
    //        foreach (int i in array)
    //            Console.Write(i + " ");

    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        HashSet<string> candidates = new HashSet<string>();

    //        candidates.Add("John");
    //        candidates.Add("Amelie");
    //        candidates.Add("Tom");
    //        candidates.Add("Richard");
    //        candidates.Add("Barbara");
    //        candidates.Add("Susan");
    //        candidates.Add("Charles");
    //        candidates.Add("Daniel");
    //        candidates.Add("Tamara");
    //        candidates.Add("Donald");

    //        HashSet<string> hiring = new HashSet<string>();

    //        while (hiring.Count < 3)
    //        {
    //            string hire = Console.ReadLine();
    //            hiring.Add(hire);

    //        }
    //        if (hiring.IsSubsetOf(candidates))
    //            Console.WriteLine("Starting hiring process");
    //        else
    //            Console.WriteLine("Something is wrong");
    //        //your code goes here

    //    }
    //}

    //class Program
    //{
    //    public static Dictionary<string, float> coffee;

    //    static void Main(string[] args)
    //    {
    //    coffee = new Dictionary<string, float>();
    //        float discount = Convert.ToInt32(Console.ReadLine());

    //        coffee.Add("Americano", 50f);
    //        coffee.Add("Latte", 70f);
    //        coffee.Add("Flat White", 60f);
    //        coffee.Add("Espresso", 60f);
    //        coffee.Add("Cappuccino", 80f);
    //        coffee.Add("Mocha", 90f);


    //        foreach (var item in coffee)
    //        {
    //            float percentage = item.Value*(discount / 100);
    //            float Discount = item.Value - percentage;
    //            float lastPrice = MathF.Ceiling(Discount);
    //            Console.WriteLine(percentage + "percentage");
    //            Console.WriteLine(Discount + "Discount");

    //            Console.WriteLine(item.Key + ": "+ lastPrice);
    //        }



    //    }
        
    //}
  class A
    {
       public int x;
    }

    class MyClass
    {
        static uint x = 4200000000;

        static void Main(string[] args)
        {
            Console.WriteLine(x);
        }
    }
}



