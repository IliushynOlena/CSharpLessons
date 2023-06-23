namespace _13_Delegates
{

    public delegate void SetStringDelegate(string str);
    public delegate double GetDoubleDelegate();
    public delegate void VoidDelegate();

    public class SuperClass
    {
        public void Print(string str)
        {
            Console.WriteLine("String : " + str); 
        }
        public static double GetKoef()
        {
            double res = new Random().NextDouble();
            return res;
        }
        public double GetNumber()
        {
            return new Random().Next();//int 999.0000000000
        }
        public void DoWork()
        {
            Console.WriteLine("Doing work.....");
        }
        public void Test()
        {
            Console.WriteLine("Testing......");
        }

    }
    public delegate double CalcDelegate(double x, double y);
    class Calculator
    {
        public double Add(double x, double y)
        {
            return x + y;
        }
        public double Sub(double x, double y)
        {
            return x - y;
        }
        public double Multi(double x, double y)
        {
            return x * y;
        }
        public double Div(double x, double y)
        {
            if(y != 0)
            {
                return x / y;
            }
            throw new DivideByZeroException();
        }
    }
        
    internal class Program
    {
        public static void DoOperation(double a, double b, CalcDelegate oper)
        {
            //count(arr);
            Console.WriteLine(oper?.Invoke(a, b));
        }
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            CalcDelegate calcDelegate2 = calculator.Add;
            calcDelegate2 += calculator.Sub;
            calcDelegate2 += calculator.Multi;
            calcDelegate2 += calculator.Div;

            foreach (var item in calcDelegate2.GetInvocationList())
            {
                Console.WriteLine( "Result = " + ((CalcDelegate)item)?.Invoke(154, 45));
            }

            DoOperation(100, 2, calculator.Add);
            DoOperation(48, 4, calculator.Sub);
            DoOperation(15, 6, calculator.Multi);
            DoOperation(128, 22, calculator.Div);

            double x, y;
            int key;
            do
            {
                Console.WriteLine("Enter first number : ");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter first number : ");
                y = double.Parse(Console.ReadLine());
                Console.WriteLine("Add - 1 ");
                Console.WriteLine("Sub - 2 ");
                Console.WriteLine("Multy - 3 ");
                Console.WriteLine("Div - 4 ");
                key = int.Parse(Console.ReadLine());
                CalcDelegate calcDelegate = null;
                switch (key)
                {
                    case 1:
                        calcDelegate = new CalcDelegate(calculator.Add);
                        break;
                    case 2:
                        calcDelegate = new CalcDelegate(calculator.Sub);
                        break;
                    case 3:
                        calcDelegate = calculator.Multi;
                        break;
                    case 4:
                        calcDelegate = calculator.Div;
                        break;
                    case 0:
                        Console.WriteLine("Good bye......");
                        break;
                    default:
                        Console.WriteLine("Incrrect choice");
                        break;
                }
                if (calcDelegate != null)
                    Console.WriteLine("Res = " + calcDelegate?.Invoke(x, y));
            } while (key != 0);


            /*
            SuperClass super = new SuperClass();


            //GetDoubleDelegate method = new GetDoubleDelegate(SuperClass.GetKoef);//address GetKoef
            GetDoubleDelegate method = SuperClass.GetKoef;//address GetKoef

            //Delegate.Combine(method, super.GetNumber);
            //Delegate.Combine(method, new GetDoubleDelegate(SuperClass.GetKoef));
            method += new GetDoubleDelegate(SuperClass.GetKoef);
            method += super.GetNumber;

            foreach (var item in method.GetInvocationList())
            {
                Console.WriteLine(((GetDoubleDelegate)item)?.Invoke());
            }
            Console.WriteLine("-------------------------");
         


            //some code - ++ delegate
            Console.WriteLine(SuperClass.GetKoef());;
            //Console.WriteLine(method());;
            Console.WriteLine(method?.Invoke()); ;
            Console.WriteLine("Countinue.......");

            GetDoubleDelegate[] delArr = new GetDoubleDelegate[]
            {
                SuperClass.GetKoef,
                //new GetDoubleDelegate(super.GetNumber)
                super.GetNumber
            };

            Console.WriteLine(delArr[0]?.Invoke()); ;

            GetDoubleDelegate dobDell = new GetDoubleDelegate(SuperClass.GetKoef);
            SetStringDelegate strDel = new SetStringDelegate(super.Print);
            VoidDelegate voidDel = new VoidDelegate(super.DoWork);

            Console.WriteLine(dobDell?.Invoke());
            strDel?.Invoke("Today is good day!!!");
            voidDel.Invoke();

            Console.WriteLine("----------------------");
            voidDel += super.Test;
            voidDel += super.DoWork;
            voidDel += super.Test;

            foreach (VoidDelegate item in voidDel.GetInvocationList())
            {
                //Console.WriteLine( ());
                item.Invoke();
            }
            Console.WriteLine("-------------------------");
            */
        }
    }
}