using System.Text;

namespace _11_interface_props
{
    interface IPerson
    {
        string LastName { get; set; }
        int Age { get; }
        string Gender { set; }
    }

    interface IIndexer
    {
        string this[int index]
        {
            get;
            set;
        }
        string this[string name]
        {
            get;
        }
    }

    enum Numbers { one, two, three, four, five };

    class IndexerClass : IIndexer
    {
        string[] _names = new string[5];

        //public string this[int index]
        //{
        //    get
        //    {
        //        return _names[index];
        //    }
        //    set
        //    {
        //        _names[index] = value;
        //    }
        //}
        public string this[string name]
        {
            get
            {
                if (Enum.IsDefined(typeof(Numbers), name))
                    return _names[(int)Enum.Parse(typeof(Numbers), name)];
                else
                    return "";
            }
        }
        public IndexerClass()
        {
            // запись значений, используя индексатор
            // с целочисленным параметром
            this[0] = "Bob";
            this[1] = "Candice";
            this[2] = "Jimmy";
            this[3] = "Joey";
            this[4] = "Nicole";
        }

        public string this[int index]
        {
            get
            {
                return _names[index];
            }
            set { _names[index] = value; }
        }


    }
    #region Inherit Interface
    /*
      interface IA
    {
        string A1(int n);
    }
    interface IB
    {
        int B1(int n);
        void B2();
    }
    interface IC : IA, IB
    {
        void C1(int n);
    }
    class InherInterface : IC
    {
        public string A1(int n)
        {
            throw new NotImplementedException();
        }

        public int B1(int n)
        {
            throw new NotImplementedException();
        }

        public void B2()
        {
            throw new NotImplementedException();
        }

        public void C1(int n)
        {
            throw new NotImplementedException();
        }
    }

      interface IA
    {
        void Show();
    }
    interface IB
    {
        void Show();
    }
    interface IC
    {
        void Show();
    }
    public class ImplicitRealization : IA, IB, IC
    {
        public void Show()
        {
            Console.WriteLine("Base Realization!");
        }
    }

    class ExplicitRealization : IA, IB, IC
    {

        // private method with explicit implement
        void IA.Show()
        {
            Console.WriteLine("Interface IA");
        }
        void IB.Show()
        {
            Console.WriteLine("Interface IB");
        }
        public void Show()
        {
            Console.WriteLine("Interface IC");
        }
        //private void GlobalShow()
        //{
        //    ((IA)this).Show();
        //}
        //public void Show()
        //{
        //    Console.WriteLine("Base Realization!");
        //}

    }

    class Program
    {
        static void Main(string[] args)
        {
            // Implicit
            //ImplicitRealization ir = new ImplicitRealization();
            //ir.Show();         
            //IA iA = new ImplicitRealization();  
            //iA.Show();
            //IB iB = new ImplicitRealization();
            //iB.Show();
            //IC iC = new ImplicitRealization();
            //iC.Show();

            // Explicit
           ExplicitRealization er = new ExplicitRealization();
           er.Show();
            //Console.WriteLine(typeof(ExplicitRealization)); 
            //er.Show(); // вызов метода интерфейса IC неявно

       
           ((IA)er).Show();
            //((IA)er).Show(); // вызов метода интерфейса IA явно

            IB iB = new ExplicitRealization();
            iB.Show(); // вызов метода интерфейса IB через ссылку
        }
    }
     
     */
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            IndexerClass indexerClass = new IndexerClass();
            Console.WriteLine("\t\tВывод значений\n");
            Console.WriteLine("Использование индексатора с целочисленным параметром:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(indexerClass[i]);
            }
            Console.WriteLine("\nИспользование индексатора со строковым параметром:");
            foreach (string item in Enum.GetNames(typeof(Numbers)))
            {
                Console.WriteLine(indexerClass[item]);
            }
        }
    }
}