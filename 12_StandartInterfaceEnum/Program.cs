using System.Collections;
using System.Security.AccessControl;

namespace _12_StandartInterfaceEnum
{

    class StudentCard : ICloneable
    {
        public int Number { get; set; }//111111
        public string Series { get; set; }//000gdgdsg

        public object Clone()
        {
            StudentCard temp = (StudentCard) this.MemberwiseClone();
            return temp;
        }

        public override string ToString()
        {
            return $"Student Card : {Number} : {Series}";
        }
    }
    class Student : IComparable<Student>, ICloneable //IComparable
    {
        public string  FirstName { get; set; }//00x1456KKK
        public string  LastName { get; set; }//00xgGUU654
        public DateTime Birtday { get; set; }//2000.10.2
        public StudentCard StudentCard { get; set; }//00x65465sdg

        public object Clone()
        {
            Student temp =(Student)this.MemberwiseClone();
            //temp.FirstName = this.FirstName;
            //temp.LastName = this.LastName;
            //temp.StudentCard = new StudentCard 
            //{ Number = this.StudentCard.Number, Series = this.StudentCard.Series};
            temp.StudentCard = (StudentCard) this.StudentCard.Clone();


            return temp;
        }

        public int CompareTo(Student? other)
        {
            return this.FirstName.CompareTo(other.FirstName);
        }

        //public int CompareTo(object? obj)
        //{
        //    if(obj is Student)
        //    {
        //       return this.FirstName.CompareTo( (obj as Student).FirstName);
        //    }
        //    throw new ArgumentException();
        //}

        public override string ToString()
        {
            return $"{FirstName}  {LastName}  {Birtday.ToShortDateString()}\n{StudentCard}\n";
        }
    }
    class SurnameComparer : IComparer<Student>//IComparer
    {
        //public int Compare(object? x, object? y)
        //{
        //    if(x is Student && y is Student)
        //    {
        //        return (x as Student).LastName.CompareTo( (y as Student).LastName);
        //    }
        //    throw new ArgumentException();
        //}
        public int Compare(Student? x, Student? y)
        {
            return x.LastName.CompareTo(y.LastName);
        }
    }
    class BirtdayComparer : IComparer<Student>//IComparer
    {
        public int Compare(Student? x, Student? y)
        {
            return x.Birtday.CompareTo(y.Birtday);
        }
    }
    class Auditory : IEnumerable
    {
        Student[] students =
        {
            new Student
            {
                FirstName = "Perto",
                LastName = "Ivanchuk",
                Birtday = new DateTime(1997,2,15),
                StudentCard = new StudentCard{ Number = 11111, Series = "AA"}
            },
            new Student
            {
                FirstName = "Ivan",
                LastName = "Melnuk",
                Birtday = new DateTime(2007,2,15),
                StudentCard = new StudentCard{ Number = 222222, Series = "AA"}
            },
            new Student
            {
                FirstName = "Kateruna",
                LastName = "Oleksuk",
                Birtday = new DateTime(2005,2,15),
                StudentCard = new StudentCard{ Number = 333333, Series = "BB"}
            },
            new Student
            {
                FirstName = "Ivanka",
                LastName = "Pulupchuk",
                Birtday = new DateTime(2010,2,15),
                StudentCard = new StudentCard{ Number = 44444, Series = "AA"}
            }
        };

        public IEnumerator GetEnumerator()
        {
            return students.GetEnumerator();
        }
        public void Sort()
        {
            Array.Sort(students);
        }
        public void Sort(IComparer<Student> comparer)
        {
            Array.Sort(students, comparer);
        }
    
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Student st = new Student
            {
                FirstName = "Ivan",
                LastName = "Melnuk",
                Birtday = new DateTime(2007, 2, 15),
                StudentCard = new StudentCard { Number = 222222, Series = "AA" }
            };
            Console.WriteLine(st);
            Console.WriteLine("-------------------------------------");
            
            Student copy = (Student) st.Clone();
            Console.WriteLine(copy);
            Console.WriteLine("-------------------------------------");
            copy.FirstName = "Ivanka";
            copy.StudentCard.Number = 99999;
            Console.WriteLine(st);
            Console.WriteLine(copy);
            /*
            //int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
           
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            Auditory auditory = new Auditory();

            foreach (Student item in auditory)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Array after sort Firstname :" );
            auditory.Sort();
            foreach (Student item in auditory)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Array after sort LastName :");
            auditory.Sort(new SurnameComparer());
            foreach (Student item in auditory)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Array after sort Birtday :");
            auditory.Sort(new BirtdayComparer());
            foreach (Student item in auditory)
            {
                Console.WriteLine(item);
            }
            */



        }
    }
}