using System;
using System.Globalization;
using System.Text;

namespace _02_String
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1. By assigning a string literal to a String variable
            //2. By using a String class constructor
            //3. By using the string concatenation operator (+)
            //4. By retrieving a property or calling a method that returns a string
            //5. By calling a formatting method to convert a value or an object to its string representation

            //from string literal and string concatenation
            /* string fname, lname;//reference - null
             fname = "Rowan";
             lname = "Atkinson";

             string fullname = fname + " bla bla bla " + lname;
             Console.WriteLine($"Full Name: {fullname}");
             Console.ReadKey();

             //by using string constructor
             char[] letters = { 'H', 'e', 'l', 'l', 'o' };
             Console.WriteLine(letters.Length);
             string greetings = new string(letters, 1, 3); // ell        
             Console.WriteLine(greetings);
             Console.WriteLine("Greetings: " +  greetings);
             Console.WriteLine($"Greetings: {greetings}");
             Console.WriteLine("Greetings: {0} {1}, {2}", "Hello", greetings, 100);
             Console.ReadKey();

             //methods returning string

             string[] sarray = { "Hello", "From", "Tutorials", "Point" };
             string message = string.Join(" - ", sarray);
             Console.WriteLine("Message: {0}", message);
             message.Split(new char[] { ' ', ',', '.', '!' });
             message.Split(' ');
             string[] splitedArr = message.Split(new string[] { " - " }, StringSplitOptions.None);
             foreach (var item in splitedArr)
             {
                 Console.WriteLine(item);
             }

             ConsoleKeyInfo key = Console.ReadKey();
             if (key.Key == ConsoleKey.F12)
                 Console.WriteLine("F12 - Have a good day!");

             string sentense = "Hello, C#! What do you do, if balbla?";
             string[] words = sentense.Split(new char[] { ' ', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

             foreach (var word in words)
             {
                 Console.WriteLine($"|{word}|");
             }

             Console.OutputEncoding = Encoding.UTF8;
             //formatting method to convert a value
             DateTime dateNow = DateTime.Now;
             Console.WriteLine(dateNow);
             Console.WriteLine(dateNow.ToString());
             Console.WriteLine(dateNow.ToLongDateString());
             Console.WriteLine(dateNow.ToLongTimeString());
             Console.WriteLine(dateNow.ToShortDateString());
             Console.WriteLine(dateNow.ToShortTimeString());
             Console.WriteLine(dateNow.ToString("yyyy:MM:dd"));


             DateTime dateTime2 = dateNow;
             dateTime2 = dateTime2.AddDays(2.5);
             dateTime2 = dateTime2.AddHours(1.5);

             TimeSpan timeSpan = dateTime2 - dateNow;
             Console.WriteLine("TimeSpan: " + timeSpan.ToString());

             Console.WriteLine($"Milliseconds: {timeSpan.Milliseconds}");
             Console.WriteLine($"Seconds: {timeSpan.Seconds}");
             Console.WriteLine($"Minutes: {timeSpan.Minutes}");
             Console.WriteLine($"Hours: {timeSpan.Hours}");
             Console.WriteLine($"Days: {timeSpan.Days}");

             Console.WriteLine($"Total Milliseconds: {timeSpan.TotalMilliseconds}");
             Console.WriteLine($"Total Seconds: {timeSpan.TotalSeconds}");
             Console.WriteLine($"Total Minutes: {timeSpan.TotalMinutes}");
             Console.WriteLine($"Total Hours: {timeSpan.TotalHours}");
             Console.WriteLine($"Total Days: {timeSpan.TotalDays}");
             //String interpolations
            */
            //C / c
            //Задает формат денежной единицы, указывает количество десятичных разрядов после запятой
            //
            //D / d
            //Целочисленный формат, указывает минимальное количество цифр
            //
            //E / e
            //Экспоненциальное представление числа, указывает количество десятичных разрядов после запятой
            //
            //F / f
            //Формат дробных чисел с фиксированной точкой, указывает количество десятичных разрядов после запятой
            //
            //G / g
            //Задает более короткий из двух форматов: F или E
            //
            //N / n
            //Также задает формат дробных чисел с фиксированной точкой, определяет количество разрядов после запятой
            //
            //P / p
            //Задает отображения знака процентов рядом с число, указывает количество десятичных разрядов после запятой
            //
            //X / x
            //Шестнадцатеричный формат числа

            /*
            decimal money = 35.60M;

            CultureInfo us = new CultureInfo("de-DE");

            string chat = String.Format("Message sent at {0:t} on {0:d}", dateNow);
            string khat = $"Message sent at {dateNow:t} on {dateNow:d} bablo:{money.ToString("C2", us)}";
            Console.WriteLine($"Message: {chat}!");
            Console.WriteLine($"Message: {khat}");
            Console.ReadKey();
            */
            //Properties

            //1   Chars
            //Gets the Char object at a specified position in the current String object.
            //
            //2   Length
            //Gets the number of characters in the current String object.

            //Methods 
            //Sr.No Methods
            //1   public static int Compare(string strA, string strB)
            //Compares two specified string objects and returns an integer that indicates their relative position in the sort order.
            //
            //2	public static int Compare(string strA, string strB, bool ignoreCase)
            //Compares two specified string objects and returns an integer that indicates their relative position in the sort order.However, it ignores case if the Boolean parameter is true.
            //
            //3	public static string Concat(string str0, string str1)
            //Concatenates two string objects.
            //
            //4	public static string Concat(string str0, string str1, string str2)
            //Concatenates three string objects.
            //
            //5	public static string Concat(string str0, string str1, string str2, string str3)
            //Concatenates four string objects.
            //
            //6	public bool Contains(string value)
            //Returns a value indicating whether the specified String object occurs within this string.
            //
            //7	public static string Copy(string str)
            //Creates a new String object with the same value as the specified string.
            //
            //8	public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
            //Copies a specified number of characters from a specified position of the String object to a specified position in an array of Unicode characters.
            //
            //9	public bool EndsWith(string value)
            //Determines whether the end of the string object matches the specified string.
            //
            //10	public bool Equals(string value)
            //Determines whether the current String object and the specified String object have the same value.
            //
            //11	public static bool Equals(string a, string b)
            //Determines whether two specified String objects have the same value.
            //
            //12	public static string Format(string format, Object arg0)
            //Replaces one or more format items in a specified string with the string representation of a specified object.
            //
            //13	public int IndexOf(char value)
            //Returns the zero-based index of the first occurrence of the specified Unicode character in the current string.
            //
            //14	public int IndexOf(string value)
            //Returns the zero-based index of the first occurrence of the specified string in this instance.
            //
            //15	public int IndexOf(char value, int startIndex)
            //Returns the zero-based index of the first occurrence of the specified Unicode character in this string, starting search at the specified character position.
            //
            //16	public int IndexOf(string value, int startIndex)
            //Returns the zero-based index of the first occurrence of the specified string in this instance, starting search at the specified character position.
            //
            //17	public int IndexOfAny(char[] anyOf)
            //Returns the zero-based index of the first occurrence in this instance of any character in a specified array of Unicode characters.
            //
            //18	public int IndexOfAny(char[] anyOf, int startIndex)
            //Returns the zero-based index of the first occurrence in this instance of any character in a specified array of Unicode characters, starting search at the specified character position.
            //
            //19	public string Insert(int startIndex, string value)
            //Returns a new string in which a specified string is inserted at a specified index position in the current string object.
            //string res;
            //20	public static bool IsNullOrEmpty(string value)
            //Indicates whether the specified string is null or an Empty string.
            //
            //21	public static string Join(string separator, params string[] value)
            //Concatenates all the elements of a string array, using the specified separator between each element.
            //
            //22	public static string Join(string separator, string[] value, int startIndex, int count)
            //Concatenates the specified elements of a string array, using the specified separator between each element.
            //
            //23	public int LastIndexOf(char value)
            //Returns the zero-based index position of the last occurrence of the specified Unicode character within the current string object.
            //
            //24	public int LastIndexOf(string value)
            //Returns the zero-based index position of the last occurrence of a specified string within the current string object.
            //
            //25	public string Remove(int startIndex)
            //Removes all the characters in the current instance, beginning at a specified position and continuing through the last position, and returns the string.
            //
            //26	public string Remove(int startIndex, int count)
            //Removes the specified number of characters in the current string beginning at a specified position and returns the string.
            //
            //27	public string Replace(char oldChar, char newChar)
            //Replaces all occurrences of a specified Unicode character in the current string object with the specified Unicode character and returns the new string.
            //
            //28	public string Replace(string oldValue, string newValue)
            //Replaces all occurrences of a specified string in the current string object with the specified string and returns the new string.
            //
            //29	public string[] Split(params char[] separator)
            //Returns a string array that contains the substrings in the current string object, delimited by elements of a specified Unicode character array.
            //
            //30	public string[] Split(char[] separator, int count)
            //Returns a string array that contains the substrings in the current string object, delimited by elements of a specified Unicode character array.The int parameter specifies the maximum number of substrings to return.
            //
            //31	public bool StartsWith(string value)
            //Determines whether the beginning of this string instance matches the specified string.
            //
            //32	public char[] ToCharArray()
            //Returns a Unicode character array with all the characters in the current string object.
            //
            //33	public char[] ToCharArray(int startIndex, int length)
            //Returns a Unicode character array with all the characters in the current string object, starting from the specified index and up to the specified length.
            //
            //34	public string ToLower()
            //Returns a copy of this string converted to lowercase.
            //
            //35	public string ToUpper()
            //Returns a copy of this string converted to uppercase.
            //
            //36	public string Trim()
            //Removes all leading and trailing white-space characters from the current String object.
            /*
            string nullStr = null;

            if (nullStr != null)
                nullStr.ToString();
            Console.WriteLine(nullStr?.Length);
            nullStr?.ToString(); // null-conditional 

            string emptyStr = "";

            if (string.IsNullOrEmpty(nullStr) && string.IsNullOrEmpty(emptyStr))
            {
                Console.WriteLine("Is null or empty!");
            }
            Console.WriteLine(emptyStr.Length);
            Console.ReadKey(); // pause
            string str = "                ";
            Console.WriteLine(str.Length);
            if (string.IsNullOrWhiteSpace(str))
            {
                Console.WriteLine("Is null or white space...");
            }
            Console.ReadKey(); // pause

            // Comparing 2 strings 
            string str1 = "This is test";
            string str2 = "This is text";

            if (string.Compare(str1, str2) == 0)
            {
                Console.WriteLine(str1 + " and " + str2 + " are equal.");
            }
            else
            {
                Console.WriteLine(str1 + " and " + str2 + " are not equal.");
            }
            Console.ReadKey();

            //String Contains String:
            string str3 = "This is test ing";
            if (str3.Contains("test"))
            {
                Console.WriteLine("The sequence 'test' was found.");
            }
            Console.ReadKey();

            //Getting a Substring:
            string str4 = "Last night I dreamt of San Pedro";
            Console.WriteLine(str4);
            string substr = str4.Substring(23);
            Console.WriteLine(substr);
            Console.ReadKey();
            */
            //Joining Strings:
            /*
            string[] starray = new string[]{"Down, the way nights, are dark",
                                            "And the sun shines daily on the mountain top",
                                            "I took, a trip, on,a sailing ship",
                                            "And when I reached Jamaica",
                                            "I made a stop"};

            string str5 = string.Join("! ", starray);
            Console.WriteLine(str5);
            Console.ReadKey();

            string[] words2 = str5.Split(new char[] { ' ', ',', '\n', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in words2)
            {
                Console.WriteLine("Word: " + item);
            }
            Console.ReadKey();
            
            //String interpolations
            */
            //C / c
            //Задает формат денежной единицы, указывает количество десятичных разрядов после запятой
            //
            //D / d
            //Целочисленный формат, указывает минимальное количество цифр
            //
            //E / e
            //Экспоненциальное представление числа, указывает количество десятичных разрядов после запятой
            //
            //F / f
            //Формат дробных чисел с фиксированной точкой, указывает количество десятичных разрядов после запятой
            //
            //G / g
            //Задает более короткий из двух форматов: F или E
            //
            //N / n
            //Также задает формат дробных чисел с фиксированной точкой, определяет количество разрядов после запятой
            //
            //P / p
            //Задает отображения знака процентов рядом с число, указывает количество десятичных разрядов после запятой
            //
            //X / x
            //Шестнадцатеричный формат числа
            
            int number = 23;
            string result = String.Format("Number: {0:d5}", number);
            Console.WriteLine(result); // 23
            //string result2 = String.Format("{0:d4}", number);
            string result2 = $" Number : {number:d4}";
            Console.WriteLine(result2); // 0023
            Console.ReadKey(); // pause

            int number1 = 23;
            string result1 = String.Format("{0:f4}", number1);
            Console.WriteLine(result1); // 23,00
            Console.ReadKey(); // pause

            double number2 = 45.08;
            //string result3 = String.Format("{0:f4}", number2);
            string result3 = $"Number: {number2:f4}";
            Console.WriteLine(result3); // 45,0800
            Console.ReadKey(); // pause

            long number4 = 19876543210;
            string result5 = String.Format("{0:+# (###) ###-##-##}", number4);
            string result6 = $"{number4:+# (###) ###-##-##}";
            Console.WriteLine(result5); // +1 (987) 654-32-10
            Console.WriteLine(result6); // +1 (987) 654-32-10
            Console.ReadKey(); // pause

            //was
            
            var anInt = 1;
            var aBool = true;
            var aString = "3";
            var formated = string.Format("{0},{1},{2}", anInt, aBool, aString);
            Console.WriteLine(formated);
            Console.WriteLine("{0},{1},{2}", anInt, aBool, aString);
            Console.ReadKey();
            //become
            var anInt1 = 1;
            var aBool1 = true;
            var aString1 = "3";
            var formated1 = $"{anInt1:f4},{aBool1},{aString1}";
            Console.WriteLine(formated1);
            Console.ReadKey();
            //
            Console.WriteLine(@$"C:\Users\helen\Desktop\Work\C#\1{aBool}");
            var someDir = "a";
            Console.WriteLine(@$"c:\{someDir}\b         
mvbjcvl;bncv;
xcvxckbvx
            kjhrgksjerhglearhglierhg
erjkghaer               kherlkf
            ejhjer

\c");
            Console.ReadKey();

            //
            Console.WriteLine($"Name: {"Ivan",10} Age: {23}"); // spaces before
            Console.WriteLine($"Name: {"Veronika",10} Age: {34}"); // spaces after
            Console.ReadKey(); // pause
            

            //Concatanation
            string s1 = "hello";
            string s2 = "world";
            string s3 = s1 + " " + s2; // = string "hello world"
            string s4 = String.Concat(s3, "!!!"); // = string "hello world!!!"

            Console.WriteLine(s4);
            Console.ReadKey();

            string s5 = "apple";
            string s6 = "a day";
            string s7 = "keeps";
            string s8 = "a doctor";
            string s9 = "away";
            string[] values = new string[] { s5, s6, s7, s8, s9 };

            String s10 = String.Join(" ", values);
            Console.WriteLine(s10);
            Console.ReadKey();
            //  result = "apple a day keeps a doctor away"

            //Finding in string 
            string s11 = "hello world";
            char ch = 'o';
            int indexOfChar = s11.IndexOf(ch); // = 4
            Console.WriteLine(indexOfChar);

            string subString = "wor";
            int indexOfSubstring = s11.IndexOf(subString); // = 6
            Console.WriteLine(indexOfSubstring);
            Console.ReadKey();
            
            //broken string
            string text = "This is the last day of ^ ^ ^       winter";

            string[] words = text.Split(new char[] { ' ' });

            foreach (string s in words)
            {
                Console.WriteLine(s);
                //s = "hello";
            }
            Console.ReadKey();

            // remove empty string when "  "
            string[] words1 = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in words1)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();

            string s12 = " ? Me tengo?!, To be honest!!!   ";
            //s12 = s12.Trim();
           
            s12 = s12.Trim(new char[] { '?', ' ', '!' });
            Console.WriteLine($"After trimming: /{s12}/");
            Console.ReadKey();
           
        }
    }
}
