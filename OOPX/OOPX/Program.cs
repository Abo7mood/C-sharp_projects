using OOPX;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace OOPX
{
   //all interface is a public 
    
    interface IPrint
    {
        
        void print();
        string Name
        {
            get;
            set;
        }
        
        
    }
   
    class Employee :IPrint
    {

        int id;
        string name;
        double salary;
        public Employee(int id,string name,double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public void print()
        {
            Console.WriteLine("ID : {0} \t Name : {1} \t Salary : {2} ",id ,name,salary);
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }



    }
    class Student : IPrint
    {
        int id;
        string name;
        double gpa;
        public Student(int id,string name,double gpa)
        {
            this.id = id;
            this.name = name;
            this.gpa = gpa;
        }
        public void print()
        {
            Console.WriteLine("ID : {0} \t Name : {1} \t Gpa : {2} ", id, name, gpa);
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
    
    class Program { 
    
     
      
        static void Main(string[] args)
        {
            IPrint std, Emp;
            std = new Student(1,"Nasser",4.6);
            Emp = new Employee(5,"Ahmed",55.6);
            
            std.print();
            Emp.print();
        }
    }
}








//1-
//Console.Write("Enter You'r Name:  ");
//string Name = Console.ReadLine();
//Console.Write("Enter You'r GPA:  ");
//double GPA = Convert.ToDouble(Console.ReadLine());
//Console.Write("Enter You'r Age:  ");
//int Age = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter You'r Email Without Outlook.sa:  ");
//string Email = Console.ReadLine();
//Email = Email + "@outlook.sa";
//Console.WriteLine("----------INFO ABOUT STUDENTS----------");
//Console.WriteLine("Name:{0,2}\n GPA:{1}\n Age:{2,2}\n Email:{3,2}", Name, GPA, Age, Email );
//Console.ReadLine();




//2-
//int x = Convert.ToInt16(Console.ReadLine());
//int y = Convert.ToInt16(Console.ReadLine());

//if (x > y)
//{
//    Console.WriteLine("X is Max");
//    Console.ReadLine();
//}
//else
//{
//    Console.WriteLine("Y is Max");
//    Console.ReadLine();
//}




//3-
//class Students
//{
//    public int ID;
//    public string Name;
//    public double GPA;
//    public void print()
//    {
//        Console.WriteLine("ID: {0} \n Name {1}\n GPA: {2} ", ID, Name, GPA);
//    }



//    Students s1 = new Students();
//    Students s2 = new Students();
//    s1.ID = 1;
//            s1.Name = "Nasser";
//                s1.GPA = 3.5;
//            s1.print();
//            Console.ReadLine();
//            s2.ID = 2;
//            s2.Name = "Nada";
//            s2.GPA = 3.2;
//            s2.print();
//            Console.ReadLine();







//4-
//static void odd()
//{
//    for (int i=0;i<100; i++)
//    {

//        if (i % 1==0 )
//            Console.WriteLine(i+"\t");
//        Console.ReadLine();
//    }
//}

//static int Max(int x,int y)
//{
//    if (x > y)
//        return x;
//    else 
//            return y;

//}

//5-
//static void funA(ref int x,int y,out int z)
//{
//    z = 18;
//    y = 12;
//    x = 6;
//}

//static void Main(string[] args)
//{
//    int a = 10, b = 20, c = 30;
//    Console.WriteLine("Before Passing");
//    Console.WriteLine("a={0},b={1},c={2}", a, b, c);
//    Console.WriteLine("After Passing");
//    funA(ref a, b, out c);
//    Console.WriteLine("a={0}<b={1},c={2}", a, b, c);
//    Console.ReadLine();



//}


//6-
//static void fun(int x,int y)
//{
//    Console.WriteLine("1");
//    Console.ReadLine();
//}
//static void fun(int x,int y,int z)
//{
//    Console.WriteLine("2");
//    Console.ReadLine();
//}
//static void fun(double x, int y, int z)
//{
//    Console.WriteLine("3");
//    Console.ReadLine();
//}
//static void Main(string[] args)
//{
//    fun(10, 12);
//    fun(5, 3, 4);
//    fun(46.6, 2, 3);
//}


//7-
//A a = new A();
//a.sum(5);
//double c = 13.2, d = 7.5, e = 12.5;
//int x = 5, b = 9;
//int s1 = a.sum(x, b);
//Console.Write(a.sum(c,d));
//double s2 = a.sum(e, b);
//    double s3 = a.sum(e, 22.1, x);



//class A
//{
//    public int sum(int x)
//    {
//        return (x);
//    }
//public int sum(int x,int b)
//    {
//        return 6;
//    }
//public double sum(double a,double b)
//    {
//        return 5;
//    }
//    public double sum(double s,int b)
//    {
//        return 3.5;
//    }
//public double sum(double a,double c,int x)
//    {
//        return 6.7;
//    }
/*  public void set(string c,string m,string co,int r)
    {
        company = c;
        model = m;
        color = co;
        ram = r;


    }
 //Mobile m1 = new Mobile("LG","G3","Black",3);
            //Mobile m2 = new Mobile("HTC", "MB", "White", 2);
            ////m1.set("LG", "G3", "Black", 3);
            ////m2.set("HTC", "MB", "White", 2);
            //m1.print();
            //m2.print();
                              //class Book
    //{
    //    int id;
    //    string name;
    //    string author;
    //    int NMP;

    //    public Book(int id, string n)
    //    {
    //        this.id = id;
    //        name = n;

    //    }
    //    public Book(string n, string a)
    //    {
    //        name = n;
    //        author = a;

    //    }
    //    public Book(int id, string n, string a, int NMP)
    //    {
    //        this.id = id;
    //        name = n;
    //        this.NMP = NMP;
    //        author = a;

    //    }
    //    public Book()
    //    {

    //    }

    //    public void print()
    //    {
    //        Console.WriteLine("ID:{0}\n Name:{1}\n Author :{2}\n NOP:{3}", id, name, author, NMP);
    //        Console.ReadLine();
    //    }*/
//8-
//public string motherboard;
//int ram;
//string cpu;
//public Computer(string motherboard)
//{
//    this.motherboard = motherboard;

//}
//public Computer()
//{



//}
//public int getram
//{
//    get { return ram; }
//    set { ram = value; }
//}public string setcpu
//{
//    set { cpu = value; }
//}
//public string getcpu
//{
//    get { return cpu; }
//}







//Computer c1 = new Computer("HP");
//Computer c2 = new Computer("Dell");
//c1.getram = 8;
//c1.setcpu = "i7";
//c2.getram = 4;
//c2.setcpu = "i5";
//if (c1.getram > c2.getram)
//{
//    Console.WriteLine(" Motherboard:{0}\n Ram:{1}\n CPU:{2}",c1.motherboard,c1.getram,c1.getcpu);
//    Console.ReadLine();

//}
//else
//{
//    Console.WriteLine(" Motherboard:{0}\n Ram:{1}\n CPU:{2}", c2.motherboard, c2.getram, c2.getcpu);
//    Console.ReadLine();

//}



//        string name;
//        string location;
//        int age;
//        public int setage
//        {
//            set
//            {
//                if (value > 0)
//                    age = value;

//                else if (value == 0)
//                    age = 18;
//                else

//                    age = value * -1;

//            }

//        }
//        public string getname
//        {
//            get { return name; }



//        }
//        public Students(string n, string l, int a)
//        {
//            name = n;
//            location = l;
//            setage = a;
//        }
//        public int getage
//        {
//            get { return age; }
//        }

//}
/*Students s1 = new Students("Nasser", "Riyadh", -17);
Students s2 = new Students("Ahmed", "Aman", 16);
        if (s1.getage > s2.getage)
            Console.WriteLine(s1.getname+" is Older than " + s2.getname);
        else
            Console.WriteLine(s2.getname + " is Older than " + s1.getname);
        Console.ReadLine();*/
//class A
//{


//    public static string name;
//    public void print()
//    {

//        name = "Khaled";
//        Console.WriteLine(name);
//    }
//    public static string myname
//    {
//        get { return name; }
//        set { name = value; }
//    }

//}
//A.myname = "Ahmed";
//            A a = new A();
//a.print();

//10-class A
//{
//    public readonly string name = "66a6";
//    public A()
//    {
//        name = "hryd";
//    }
//    public A(string n)
//    {
//        name = n;
//    }
//    A a1 = new A();
//    Console.WriteLine(a1.name);
//}

//int x = 2;
//int y = 3;
//Console.WriteLine(Math.E*3);
//int[] arr = new int[100];
//            for (int i = 0; i<arr.Length; i++)
//            {

//                if (i % 2 == 0)
//                    arr[i] = 3;
//                else
//                {
//                    arr[i] = 7;
//                }
//                foreach (int var in arr)
//                {
//                    Console.Write(var + "\t");

//                }
//            }
//int[] arr = new int[5];
//            for (int i = 0; i<arr.Length; i++)
//            {
//                arr[i] = Convert.ToInt32(Console.ReadLine());

//            }
//            int max = arr[0];
//int min = arr[0];
//            for (int i = 0; i<arr.Length; i++)
//            {
//                if (arr[i] > max)
//                {
//                    max = arr[i];
//              }
//                if (arr[i] < min)
//                    min = arr[i];
//            }
//            Console.WriteLine("Max={0} Min={1}",max,min);
//            Console.ReadLine();
//14-
//int[,] arr = new int[4, 2];
//            for (int i=0;i<arr.GetLength(0); ++i)
//                for (int j = 0; j<arr.GetLength(1); j++)
//                {
//                    Console.WriteLine("Enter value in Arr[{0}],[{1}]",i,j);
//                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
//                }

//            int count = 0;
//            for (int i = 0; i<arr.GetLength(0); ++i)
//                for (int j = 0; j<arr.GetLength(1); j++)
//                    if (arr[i, j] % 2 == 0)
//                        ++count;
//            for (int i = 0; i<arr.GetLength(0); ++i)
//            {



//                for (int j = 0; j<arr.GetLength(1); j++)
//                    Console.Write(arr[i, j]+"\t");
//                Console.WriteLine();
//}
//            Console.WriteLine("Number of even is:{0}",count);
//double[] s1 = new double[3] { 19, 26, 43 };
//double[] s2 = new double[3] { 19, 25, 46 };
//marks m1 = new marks(s1, 1, "Ahmed");
//marks m2 = new marks(s2, 1, "Nasser");

//double s3 = 0;
//double s4 = 0;
//            for(int i = 0; i< 3; i++)
//            {
//                s3 += m1.mark[i];
//                s4 += m2.mark[i];
//            }
//            if (s3>s4)
//            {
//                Console.WriteLine("Name: {0} \n ID: {1} \n Sum Of Marks{2}",m1.name,m2.id,s3);
//            }
//            else
//            {
//                Console.WriteLine("Name: {0} \n ID: {1} \n Sum Of Marks{2}", m2.name, m1.id, s4);
//class marks
//{
//    public double[] mark;
//    public int id;
//    public string name;
//    public marks(double[] m, int i, string n)
//    {
//        mark = new double[3];
//        mark = m;
//        id = i;
//        name = n;
//    }
//}
//            }
//16-
//class Employee
//{
//    public string name;
//    int yearofbrath;
//    int empId;



//    public Employee(string n, int y, int e)
//    {
//        name = n;
//        yearofbrath = y;
//        empId = e;


//    }
//    public int Breath
//    {
//        get { return yearofbrath; }
//        set { yearofbrath = value; }

//    }
//    public int ID
//    {

//        get { return empId; }
//        set { empId = value; }
//    }

//}
//Employee[] emp = new Employee[5];
//            for(int i=0; i<emp.Length; i++)
//            {

//                Console.WriteLine("Enter Name :");
//                string n = Console.ReadLine();
//Console.WriteLine("Enter Year Brith :");
//                int y = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter ID :");
//                int id = Convert.ToInt32(Console.ReadLine());
//emp[i] = new Employee(n, y, id);

//            }
//            emp[2].name = "Ahmed";

//            emp[2].ID = 999;
//            for(int i = 0; i<emp.Length; i++)
//            {
//                Console.WriteLine(emp[i].name);
//            }
//            for(int i = 0; i<emp.Length; i++)
//            {
//                if (emp[i].Breath > 1985)
//                    Console.WriteLine(emp[i].ID);
//            }
//-19
//  protected string name;
//int age;
//string email;
//public virtual void print()
//{
//    Console.WriteLine("Name : {0}\n Age : {1}\n Email : {2}", name, age, email);
//}
//public person(string name, int age, string email)
//{
//    this.name = name;
//    this.age = age;
//    this.email = email;
// class programmer : person
//{
//    string launguage;
//    public programmer(string n, int a, string e, string l) : base(n, a, e)
//    {
//        launguage = l;


//    }
//    public override void print()
//    {
//        base.print();
//        Console.WriteLine("language: {0}", launguage);
//    }

//            programmer p1 = new programmer("A", 9, "rys", "yeey");
//p1.print();

//            person p2 = new programmer("Ary", 79, "ryyrys", "yeeyryry");
//p2.print();
//20-
//abstract class j
//{
//    public string name;
//    public int age;
//    public float number = 2f;
//    public abstract void p();
//    public abstract string myname { get; }



//}

//class person : j
//{

//    public override void p()
//    {
//        Console.WriteLine("Name : {0}\n Age: {1}\n Number : {2} ", name, age, number);
//    }
//    public override string myname
//    {
//        get
//        {
//            return name;

//        }


//    }





//}
//person p1 = new person();
//21-
//class marks
//{
//    public double first;
//    public double second;
//    public double third;
//    public double final;

//    public double calc()
//    {
//        double sum = first + second + third + final;
//        return sum;

//    }
//    public marks(double f, double s, double t, double final)
//    {
//        first = f;
//        second = s;
//        third = t;
//        this.final = final;
//    }

//}



//class student
//{

//    string name;
//    int id;
//    marks mark;
//    string Major;

//    public student(string name, int id, double f, double s, double t, double final, string major)
//    {
//        this.name = name;
//        this.id = id;
//        mark = new marks(f, s, t, final);
//        this.Major = major;
//    }
//    public void print()
//    {
//        Console.WriteLine("Name : {0}\n ID : {1}\n Major : {2}", name, id, Major);
//        Console.WriteLine("First Mark : {0}\n Second Mark : {1}\n Third Mark {2}\n Final Mark : {3}", mark.first, mark.second, mark.third, mark.final);
//        Console.WriteLine("Your Total Mark is : {0}", mark.calc());
//    }
//}
//22-
//class shape
//{
//    public int width;
//    public void area()
//    {

//    }
//}
//class Circle : shape
//{

//}
//Circle c = new Circle();
//shape c1 = new shape();
//shape c2 = new Circle();
//class A
//{
//    public virtual void print()
//    {
//        Console.WriteLine("From A");
//    }
//}
//class B : A
//{
//    public override void print()
//    {
//        Console.WriteLine("From B");
//    }
//}
//class C : A
//{
//    public override void print()
//    {
//        Console.WriteLine("From C");
//    }
//}
//static void fun(A abc)
//{
//    abc.print();
//}
//A abc = new A();
//fun(abc);
//B b = new B();
//fun(b);
//C c = new C();
//fun(c);
//    class A
//    {
//        public int h;
//        public virtual void f()
//        {
//            Console.WriteLine("A");
//        }

//    }
//    class B : A
//    {
//        public override void f()
//        {
//            Console.WriteLine("B");
//        }
//    }
//    class C : A
//    {
//        public override void f()
//        {
//            Console.WriteLine("C");
//        }
//    }
//    class Program
//    {
//        public static void fun(A abc)
//        {
//            abc.f();
//        }



//        static void Main(string[] args)
//        {

//            A abc = new A();
//            abc.f();
//            B b = new B();
//            fun(b);

//            C c = new C();
//            fun(c);


//        }
//    }
//}
//class A
//{
//    public double sum(params double[] a)
//    {
//        double sum = 0;
//        for (int i = 0; i < a.Length; i++)
//        {
//            sum = sum + a[i];
//        }
//        return sum;
//    }
//    public double sum(double x, double z, double y)
//    {
//        return x + y + z;
//    }
//    public double sum(double x, double u, double z, double y)
//    {
//        return x + y + z + u;
//    }
//A a = new A();
//Console.WriteLine(a.sum(10, 20, 30, 40, 50));

//static void swap<t>(ref t x, ref t y)
//{
//    t z = x;
//    x = y;
//    y = z;

//}
//int a = 5;
//int b = 7;
//swap<int>(ref a, ref b);
//            Console.WriteLine("A = {0}\nB = {1}",a,b);
//            string c = "N";
//string d = "K";
//swap<string>(ref c, ref d);
//            Console.WriteLine("N = {0} K = {1}", c, d);
//            bool f = false, e = true;
//swap<bool>(ref e, ref f);
//            Console.WriteLine("True ={0}\n False ={1}", e,f);
//class A
//{
//    public virtual void fun()
//    {

//    }

//}
//class B : A
//{
//    public sealed override void fun()
//    {

//    }
//}
//class C : B
//{

//}








