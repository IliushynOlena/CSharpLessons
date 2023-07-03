namespace _14_Event
{
    public delegate void ExamDelegate(string t);//Delegate MulticastingDelegate
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public void PassExam(string task)
        {
            Console.WriteLine($" Student : {FirstName}  {LastName} pass exam {task} ");
        }
    }

    class Teacher
    {
        public event Action TestEvent;
        //public event ExamDelegate ExamEvent = null;

        private ExamDelegate examEvent;

        public event ExamDelegate ExamEvent
        {
            add
            { examEvent += value; Console.WriteLine(value.Method.Name + " was added!"); }
            remove 
            { examEvent -= value; Console.WriteLine(value.Method.Name + " was removed!"); }
        }

        public void CreateExam(string theme)
        {
            //exam creating 
            //some code

            //call students .... ExamEvent
            //ExamEvent(theme);
            examEvent?.Invoke(theme);
        }
        public void StartAction()
        {
            TestEvent?.Invoke();
            //TestEvent();
        }
    }

    public delegate void FinishAction();
    internal class Program
    {
        static void HardWork(FinishAction action)//address
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Operation {i + 1} started... ");
                Thread.Sleep(rnd.Next(500));
                Console.WriteLine($"Operation {i + 1} finished.... ");
            }
            //finish action invoke
            action?.Invoke();

        }
        static void Action1()
        {
            Console.WriteLine("You are a good worker!!!!");
        }
        static void Action2()
        {
            Console.WriteLine("Bye bye !!!!");
        }
        // public event NameDelegate Birthday;
        static void Main(string[] args)
        {
            HardWork(Action1);
            HardWork(Action2);
            HardWork(delegate () { Console.WriteLine("I'am finished my operation"); });


            List<Student> students = new List<Student>
            {
                new Student
                {
                    FirstName = "Perto",
                    LastName = "Ivanchuk",
                    Birthday = new DateTime(1997,2,15)
                },
                new Student
                {
                    FirstName = "Ivan",
                    LastName = "Melnuk",
                    Birthday = new DateTime(2007,2,15),
                },
                new Student
                {
                    FirstName = "Kateruna",
                    LastName = "Oleksuk",
                    Birthday = new DateTime(2005,2,15),
                },
                new Student
                {
                    FirstName = "Ivanka",
                    LastName = "Pulupchuk",
                    Birthday = new DateTime(2010,2,15),
                }
            };


            Teacher teacher = new Teacher();
            foreach (Student st in students)
            {
                teacher.ExamEvent += new ExamDelegate(st.PassExam);
            }

            teacher.ExamEvent -= students[1].PassExam;
            //teacher.ExamEvent = null;

            teacher.CreateExam("C# exam in Microsoft Teams");

            teacher.TestEvent += Console.Clear;
            teacher.TestEvent += delegate () { Console.ForegroundColor = ConsoleColor.Green; };
            teacher.TestEvent += Teacher_TestEvent;
            //teacher.TestEvent += MyColor;
            teacher.TestEvent += () => Console.Beep(500, 1000);
            //teacher.TestEvent += MyBeep;
            //this methods not work
            //teacher.TestEvent -= delegate () { Console.ForegroundColor = ConsoleColor.Green; };
            //teacher.TestEvent -= () => Console.Beep(500, 1000);
            teacher.TestEvent -= Console.Clear;

            teacher.StartAction();

        }

        private static void MyColor()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        private static void MyBeep()
        {
            Console.Beep(500, 1000);
        }

        private static void Teacher_TestEvent()
        {
            Console.WriteLine("Auto-created method by PRESS TAB!!!");
            Console.WriteLine("Auto-created method by PRESS TAB!!!");
            Console.WriteLine("Auto-created method by PRESS TAB!!!");
            Console.WriteLine("Auto-created method by PRESS TAB!!!");
        }
    }
}