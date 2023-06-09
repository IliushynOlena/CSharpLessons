using System;

namespace RefOutParams
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"X : {X} Y: {Y}";
        }
    }
    class Rectangle
    {
        public int Height { get; set; }
        private int width;
        public int Width
        {
            get { return width; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid width");
                }
                else
                {
                    width = value;
                }
            }
        }

        public Rectangle(int h, int w)
        {
            Height = h;
            Width = w;
        }

        public Rectangle()
        {
        }
        public override string ToString()
        {
            return $" Height : {Height} Width {Width} ";
        }
    }
    struct Time
    {
        public int H { get; set; }
        public int M { get; set; }
        public int S { get; set; }
        //public Time()
        //{

        //}
        public override string ToString()
        {
            return $" {H} : {M} : {S}";

        }
    }
    class Program
    {

        static void MethodWithParams(string name, params int[] marks)
        {
            Console.WriteLine($"--------{name}-----------");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write(marks[i] + " ");
            }
        }
        static void Modify(ref int num, ref string str, ref Point p)
        {
            num += 1;
            str += "!";
            p.X++;
            p.Y++;
        }
       
        static void GetCurrentTime(out int hour,out  int minute,out  int second)
        {
            hour = DateTime.Now.Hour;
            minute = DateTime.Now.Minute;
            second = DateTime.Now.Second;
        }
        //static void GetCurrentTime(ref int hour, ref int minute, ref int second)
        //{
        //    hour = DateTime.Now.Hour;
        //    minute = DateTime.Now.Minute;
        //    second = DateTime.Now.Second;
        //}
        static void Main(string[] args)
        {
            //int[] marks = new int[5] { 11, 8, 7, 12, 4 };        
            //MethodWithParams("Olena", marks);
            //MethodWithParams("Olena", 11, 8, 7, 12, 4);
            //MethodWithParams("Olena", new int[] { 11, 8, 7, 12, 4 }, new int[] { 11, 8, 7, 12, 4 });

            int h, m, s;
            //GetCurrentTime(ref h, ref m, ref s);
            //GetCurrentTime( h,  m,  s);
            GetCurrentTime(out h, out m, out s);
            //GetCurrentTime(out int h, out int m, out int s);
            Console.WriteLine($" {h} : {m} : {s}");


            int num = 10;
            string str = "Hello world";
            Point point = new Point(5, 5);
            Console.WriteLine("Num : " + num);
            Console.WriteLine("Str : " + str);
            Console.WriteLine("Point : " + point);
            Modify(ref num, ref str, ref point);
            Console.WriteLine("Num : " + num);
            Console.WriteLine("Str : " + str);
            Console.WriteLine("Point : " + point);

            Rectangle rect = new Rectangle()
            {
                Height = 5,
                Width = 0
            };
            try
            {
                rect.Width--;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("ArgumentException");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            string name = Console.ReadLine();
            try
            {
                decimal price = decimal.Parse(Console.ReadLine());

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


            Rectangle r  = new Rectangle();//Ref
            Time time = new Time();//Values - 12b
            int a;//4b
            Console.WriteLine(r);
            Console.WriteLine(time);
            


          
        }  
    }
}