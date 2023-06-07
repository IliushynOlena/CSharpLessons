using System.Xml.Linq;

namespace _04_IntroToOOP
{
    //private (default)
    //protected
    //protected internal
    //internal 
    //public
    class MyClass
    {
       private int number;
       private string name;
       private const float PI = 3.14f;
       //private readonly int id = 10;
       private readonly int id;

        public MyClass()
        {
            id = 10;

        }
        //void setId(int id)
        //{
        //    this.id = id; //error
        //}
        public void Print()
        {
            Console.WriteLine($"Id : {id} . Name : {name}");  
        }
        public override string ToString()
        {
            return $"Id : {id} . Name : {name}";  
        }

    }
    interface ITest//Interface
    {

    }
    class DerivedClass : MyClass, ITest//public
    {

    }
    struct Date
    {
        //private int MyProperty;
        public Date()
        {

        }
        public Date(int a)
        {
            //MyProperty = a;
        }
    }
    partial class Point
    {
        public static int count;
        static Point()
        {
            count = 0;
        }
        public Point()
        {
            //number : 0
            //boolean : false
            //ref : null
            count++;
        }
        public Point(int x, int y)
        {
            //SetX(x);
            XCoord = x;
            YCoord = y;
            count++;
            //SetY(y);
        }
        public Point(int value) : this(value, value) { }
        public void SetX(int x)
        {
            if (x >= 0)
                this.xCoord = x;
            else
                this.xCoord = 0;
        }
        public void SetY(int y)
        {
            if (y >= 0)
                this.yCoord = y;
            else
                this.yCoord = 0;
        }

        //full property
        private int xCoord;
        public int XCoord
        {
            get
            {
                return xCoord;
            }
            set
            {
                if (value >= 0)
                    this.xCoord = value;
                else
                    this.xCoord = 0;
            }
        }
        private int yCoord;
        public int YCoord
        {
            get
            {
                return yCoord;
            }
            set
            {
                if (value >= 0)
                    this.yCoord = value;
                else
                    this.yCoord = 0;
            }
        }
        //full property
        //private string name;
        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}

        //auto propyrty
        public string Name { get; set; }
        public string Material { get; private set; }
        public string Color { get; private set; } = "Green";
        //public int ZCoord { get; set; }

        //full 
        //private int z;

        //public int ZCoord
        //{
        //    get { return z; }
        //    set { z = value; }
        //}
      
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Date d = new Date();//value Date()
            //Console.WriteLine(d.MyProperty);
            //Console.SetCursorPosition(1, 1);
            //Console.BackgroundColor = ConsoleColor.Green;   
            //Console.ForegroundColor = ConsoleColor.Yellow;   

            Point point = new Point(5,5);
            point.Print();
            Console.WriteLine(point);

            point.SetX(55);

            point.XCoord = 100;//set

            int x = point.XCoord;//get
            Console.WriteLine(x);
            Console.WriteLine(point);

            point.Name = "2D_Point";//set
            Console.WriteLine(point.Name);//get
            Point point2 = new Point(9);
            Console.WriteLine(point2);

            Console.WriteLine(Point.count);
            /*
            MyClass myClass = new MyClass();
            myClass.Print();
            Console.WriteLine(myClass);
            Console.WriteLine(myClass.ToString());*/
           
        }
    }
}