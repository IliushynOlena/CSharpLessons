using System;
using System.Runtime.InteropServices;
using System.Text;

namespace CSharpLessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello world");
            Console.Write("Hello world");
            Console.WriteLine("Hello world");


            Console.WriteLine("Enter number : ");
            string str = Console.ReadLine();
            int number = int.Parse(str);
            Console.WriteLine(str + "!!!");
            Console.WriteLine(number + 15);

            int a = 0;//not null
            //a = null;
            //Nullable<int> b = null;
            int? b = null;
            b = 0;
            b = null;

            string address = null;//nullable type
            //address = 0;            

            int c = 10;

            var d = 3.14;
            var name = "Olena";
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine(now.ToString());
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy/MM/dd/hh:mm:ss"));

            object obj = new object();
            Console.WriteLine(obj.ToString());

            bool myBool = true;
            short myshort = 6;//-32.....+32th
            int myInt = myshort;//2 147 685 0000

            decimal myDec = 3.14m;
            //Implicit 
            float myFloat = 3.14F;//15-16  // float - 7-8
            int int1 = 44;
            float fl2 = myFloat + int1;
            double db1 = fl2;
            //int int3 = db1;
            //Explicit
            int int3 =(int)db1;
            Console.WriteLine(myFloat);
            Console.WriteLine(int1);
            Console.WriteLine(fl2);
            Console.WriteLine(int3);
            
            
            /////////////////////// Type Converter
            //выводим пользователю сообщение
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Введите целое число: ");
            //получаем строку из консоли в строковую переменную
            string numberString = Console.ReadLine();
            //конвертируем строковое значение в числовое
            int number = int.Parse(numberString);
            //выводим результат
            Console.WriteLine("Число = " + number);

            number = Convert.ToInt32(numberString);

            try
            {
                numberString = Console.ReadLine();
                float float_num = Convert.ToSingle(numberString);
                Console.WriteLine($"float: {float_num}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            /////////////////////// non-nullable and nullable types
            // value-types     - non-nullable
            // reference-types - nullable

            int a = 6;              // not allow null
            Nullable<int> n = null; // allow null
            // or
            int? n2 = null;         // allow null    

            string s = null;
            string s2 = s;

            if (s != null)
                s.ToUpper();
            // or
            
            s?.ToUpper();       // ? null-conditional operator    

            s2 = (s == null ? "Error" : s);
            // or
            s2 = s ?? "Empty";  // ?? null-conditional operator    
            Console.WriteLine("s2 = " + s2);

            Console.ReadKey(); // pause

            /////////////////////// Randomizer
            Random rnd = new Random();
            //DateTime myBirth = new DateTime(2000, 12, 3);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rnd.Next(-10, 11));//-10...10
            }
            Console.WriteLine(rnd.Next());            // randome value (0...MaxInt)
            Console.WriteLine(rnd.Next(100));          // max value [0...99)
            Console.WriteLine(rnd.Next(-100, 100));    // range [-100...99)

            /////////////////////// Conditions, Cycles
            if (3 > 8)
            {
                Console.WriteLine(">");
            }

            if (s == null)
            {
                s2 = "error";
            }
            else
            {
                s2 = s;
            }

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;
            ConsoleColor color = Console.BackgroundColor;
            switch (color)
            {
                case ConsoleColor.Red: Console.WriteLine("Red"); break;
                case ConsoleColor.Black: Console.WriteLine("Black"); break;
                default: Console.WriteLine("Other Color"); break;
            }

            //for (int i = 0; i < 100; i++)
            //{

            //}
            //while (true)
            //{

            //}
            //do
            //{

            //} while (true);
            */
            /////////////////////// Invoke Methods
            //Literals();
            //FormatString();
            ConsoleMethods();
            // Console.WriteLine();            


        }
        static void FormatString()
        {
            Console.OutputEncoding = Encoding.Unicode;
            /////////////////////// Escape Sequences
            /*
                \'      – single quote, needed for character literals
                \"      – double quote, needed for string literals
                \\      – backslash
                \0      – Unicode character 0
                \a      – Alert (character 7)
                \b      – Backspace (character 8)
                \f      – Form feed (character 12)
                \n      – New line (character 10)
                \r      – Carriage return (character 13)
                \t      – Horizontal tab (character 9)
                \v      – Vertical quote (character 11)
                \uxxxx  – Unicode escape sequence for character with hex value xxxx                
            */
            Console.WriteLine("Некоторое простое сообщение\nИещё " +
                "одно простое сообщение на " +
                "новой строке");
            /*выводит в консоль следующее сообщение:
            Некоторое простое сообщение
            И ещё одно простое сообщение на новой строке*/
            Console.WriteLine("Пример табуляции: " +
             "\n1\t2\t3\n4\t5\t6");
            /*выводит в консоль следующее сообщение:
            Пример табуляции:
            1. 2 3
            4. 5 6*/
            Console.WriteLine("kghfdkjgh" +
                "sdjfisdgiusgf" +
                "sdhfiusdgfuisd" +
                "dsihfsdigiusd" +
                "shdgoisdgh");
            Console.WriteLine(@"C:\Users\helen\Desktop\Work\C#\1");
            /////////////////////// @ - litteral formatting
            Console.WriteLine(@"Пример буква        льного
         hhjfhf
                C:\Users\helen\Desktop\Work\C#\1
             kdfjgoihiodfhoihb
            строкового литерала:
ehoiweiowegtowei
            1 \t 3
            \n 5 6");
            /*выводит в консоль следующее сообщение:
            Пример буква        льного
            
            
            строкового литерала:
            1 \t 3
            \n 5 6*/

            /////////////////////// string concat
            string name = "Bob";
            int day = 29;
            bool isValid = true;

            Console.WriteLine("Hello " + name + " Day: " + day.ToString());
            Console.WriteLine("Hello " + name + " Day: " + day); // ToString() is called automatically
            // string interpolation: $ - operator
            Console.WriteLine($"Hello, {name}\tDay: {day}\nValid: {isValid}{{}}");
            // $ + @
            Console.WriteLine($@"Hello, {name}\tDay: {day}\nValid: {isValid}{{}}");
        }
        static void Literals()
        {

            /*при помощи метода GetType() программа возвращает
            тип данных литералов, демонстрируя действие суффиксов*/
            Console.WriteLine((10).GetType());  /*выводит в консоль: System.Int32 что соответствует типу данных int*/
            Console.WriteLine((10D).GetType()); /*выводит в консоль: System.Double что соответствует типу данных double*/
            Console.WriteLine((10f).GetType()); /*выводит в консоль: System.Single что соответствует типу данных float*/
            Console.WriteLine((10m).GetType()); /*выводит в консоль: System.Decimal что соответствует типу данных decimal*/
            Console.WriteLine((10L).GetType()); /*выводит в консоль: System.Int64 что соответствует типу данных long*/
            Console.WriteLine((10UL).GetType());/*выводит в консоль: System.Uint64 что соответствует типу данных ulong*/
            Console.WriteLine(0xFF);            /*выводит в консоль: 255 шестнадцатиричное число 0xFF соответствуетa десятичному числу 255*/
        }
        static void ConsoleMethods()
        {
            //изменяет заголовок окна консоли
            Console.Title = "Пример использования инструментов класса Console";
            //изменяет цвет фона
            Console.BackgroundColor = ConsoleColor.Green;
            //изменяет цвет текста                      
            Console.ForegroundColor = ConsoleColor.Magenta;
            //получаем размер самого длинного сообщения в рамках нашей программы
            //int length = ("Input Encoding: " + Console.InputEncoding.ToString()).Length + 1;
            Console.WriteLine("Input Encoding: dsnbfdjskjghdfjkghdfkjghdfjkhkjgbksdjghskghskdghkdsjgh");
            int length = ("Input Encoding: dsnbfdjsbsdjghdfjkghdfkjghdfjkhkjgbksdjghskghskdghkdsjgh ").Length + 1;
            Console.SetWindowSize(length, 8);
            //устанавливаем размер окна консоли
            /*устанавливаем размер буфера консоли
            (размер окна должен быть
            соответствующим и должен быть
            установлен до того, как мы изменим
            размер буфера)*/
            //Console.SetBufferSize(length, 8);
            //выводим информацию о кодировке потока ввода
            Console.WriteLine("Input Encoding: " + Console.InputEncoding.ToString());
            //выводим информацию о кодировке потока вывода
            Console.WriteLine("Output Encoding: " + Console.OutputEncoding.ToString());
            //устанавливает зеначение цвета текста в значение по умолчанию
            Console.ResetColor();
            //выводим информацию о том, нажат ли NUM LOCK
            Console.WriteLine("Is NUM LOCK turned on: " + Console.NumberLock.ToString());
            //выводим информацию о том, нажат ли CAPS LOCK
            Console.WriteLine("Is CAPS LOCK turned on: " + Console.CapsLock.ToString());
            /*выводим пользователю сообщение
            о том, что программа ожидает ввода
            некоторой информации*/
            Console.Write("Enter a simpe message: ");
            //получаем от пользователя текстовое сообщение
            string message = Console.ReadLine();
            //выводим сообщение, введённое пользователем
            Console.WriteLine("Your message is: " + message);
            //звук beep
            Console.Beep(300, 3000);
            //очистка консоли
            Console.Clear();
            Console.WriteLine("Your message is: " + message);
        }

    }
}
