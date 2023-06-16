using System.Text;

namespace _09_Inheritance
{

    // protected            - allow access from inherit classes
    // protected internal   - allow access from inherit classes only in assembly

    // sealed - dont allow to inherit
    abstract class Person // implicit inherit object class
    {
        protected string name;
        //protected string surnamname;
        private readonly DateTime birthDate;
        public Person()
        {
            name = "No name";
            birthDate = new DateTime();
        }
        //void SetDate(DateTime d)
        //{
        //    birthDate = d;
        //}
        public Person(string n, DateTime b)
        {
            name = n;

            if (b > DateTime.Now)
                birthDate = new DateTime();
            else
                birthDate = b;
        }

        public abstract void DoWork();

        public virtual void Print()
        {
            Console.WriteLine($"Name: {name}\n" +
                              $"Birth: {birthDate.ToLongDateString()}");
        }

        // virtual object.ToString()
        public override string ToString()
        {
            return $"Name: {name}\n" +
                   $"Birth: {birthDate.ToLongDateString()}";
        }
    }

    // class Name : BaseClass, Interface1, InterfaceN...
    class Worker : Person
    {
        private decimal salary;
        public decimal Salary
        {
            get
            {
                return salary;
            }
            private set
            {
                this.salary = value >= 0 ? value : 0;
            }
        }

        // base - reference to base class
        public Worker() : base()
        {
            salary = 0;
        }
        public Worker(string n, DateTime b, decimal s) : base(n, b)
        {
            Salary = s;
            //salary = s >= 0 ? s : 0;
        }     

        public override void DoWork()
        {
            Console.WriteLine("Doing some work!");
        }

        // new      - explicit hides a base member
        // override - override base member
        public override void Print()
        {
            //Person::Print();
            base.Print();
            Console.WriteLine($"Salary: {salary}");
        }
    }

     class Programmer : Worker//sealed
    {
        public int CodeLines { get; private set; }
        public Programmer() : base()
        {
            CodeLines = 0;
        }
        public Programmer(string n, DateTime b, decimal s) : base(n, b, s)
        {
            CodeLines = 0;
        }

        // new             - create new member and stop virtual 
        // sealer override - override base member and stop virtual 
        public sealed override void DoWork()
        {
            Console.WriteLine("Write C# code!");
        }
        public void WriteLine()
        {
            ++CodeLines;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Code lines: " + CodeLines);
        }
    }

    class TechLead : Programmer
    {
        public int ProjectCount { get; set; }

        // error with sealed
        //public override void DoWork()
        //{
        //    Console.WriteLine("Manage team project!");
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

           Worker worker = new Worker("Vova", new DateTime(2010, 3, 3), 4500);
           worker.Print();

            Person[] people = new Person[]
            {
                //new Person(),
                worker,
                new Programmer("Bill", DateTime.Now, 7800)
            };

            foreach (var person in people)
            {
                Console.WriteLine("---------- Info ----------");
                person.Print();
            }
            Console.WriteLine("--------------------------");
            ///////////////// Conversion Types
            Programmer pr = null;

            ////////// 1 - use cast ()
           try
            {
                pr = (Programmer)people[2];
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            Console.WriteLine(pr);
            
            ////////// 2 - use as
            pr = people[1] as Programmer;

            if (pr == null)
                Console.WriteLine("Incorrect type!");
            else
                Console.WriteLine(pr);
            ///////// 3 - use is with as
            if (people[1] is Programmer)
            {
                pr = people[1] as Programmer;
            }
            else Console.WriteLine("Incorrect type!");
            Console.WriteLine(pr);
            pr?.DoWork();

            //Worker w = new Programmer("Larry", new DateTime(1980, 1, 1), 20000);
            //w.DoWork();
        }
    }
}