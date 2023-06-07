using System.Text;

namespace _03_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Array
            /*
            //1     
            //тип_елементів [] ім'я_масива;             
           // int arr[10] = { };
            int[] array = new int[5];// Array

            array[0] = 10;
            array[1] = 20;
            array[2] = 30;
            array[3] = 40;
            array[4] = 50;

            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            Console.WriteLine(array[3]);
            Console.WriteLine(array[4]);

            Console.ReadKey(); // pause

            //2
            int[] array2 = new int[5];

            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = i * 2;
            }

            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(array2[i] + " ");
            }
            Console.WriteLine();
            Console.ReadKey(); // pause
            //3
            int[] array3 = new int[5] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < array3.Length; i++)
            {
                Console.Write(array3[i] + " ");
            }
            Console.WriteLine();
            Console.ReadKey(); // pause
            //4
            int[] array4 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < array4.Length; i++)
            {
                Console.Write(array4[i] + " ");
            }
            Console.WriteLine();
            Console.ReadKey(); // pause
            //5
            int[] array5 = new int[] { 1, 2, 3, 4 };

            for (int i = 0; i < array5.Length; i++)
            {
                Console.Write(array5[i] + " ");
            }
            Console.WriteLine();
            Console.ReadKey(); // pause
            //6
            int[] array6 = new int[5];

            for (int i = 0; i < array6.Length; i++)
            {
                Console.Write(array6[i] + " ");
            }
            Console.WriteLine();
            Console.ReadKey(); // pause

            array.SetValue(777, 2);

            foreach (int elem in array)
            {
                //elem = 1; // read only
                Console.WriteLine(elem);
            }*/
            #endregion
            #region _2D_Arrays
            /*
              //1
            int[,] array = new int[3, 3];

            array[0, 0] = 1;
            array[0, 1] = 2;
            array[0, 2] = 3;

            array[1, 0] = 4;
            array[1, 1] = 5;
            array[1, 2] = 6;

            array[2, 0] = 7;
            array[2, 1] = 8;
            array[2, 2] = 9;

            Console.Write(array[0, 0]);
            Console.Write(array[0, 1]);
            Console.Write(array[0, 2]);
            Console.Write("\n");
            Console.Write(array[1, 0]);
            Console.Write(array[1, 1]);
            Console.Write(array[1, 2]);
            Console.Write("\n");
            Console.Write(array[2, 0]);
            Console.Write(array[2, 1]);
            Console.Write(array[2, 2]);

            Console.WriteLine();
            Console.ReadKey(); // pause
            //2            
            int[,] array2 = new int[3, 4];

            for (int i = 0; i < array2.GetLength(0); i++)//3 - 0 1 2
            {
                for (int j = 0; j < array2.GetLength(1); j++)//4 - 0 1 2 3
                {
                    array2[i, j] = i * j + 1;
                }
            }

            for (int i = 0; i <= array2.GetUpperBound(0); i++)//2
            {
                for (int j = 0; j <= array2.GetUpperBound(1); j++)//3
                {
                    Console.Write($"{array2[i, j]}\t");
                }
                Console.Write("\n");
            }
            Console.ReadKey(); // pause
            //3
            int[,] array3 = {
                              { 1, 2, 3 },
                              { 4, 5, 6 },
                              { 7, 8, 9 }
                            };

            Console.WriteLine(array3.Length);
            Console.WriteLine(array3.ToString());
            Console.WriteLine();

            int a = 3, b = 3; // c = 3;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write($"{array3[i, j]}");

                }
                Console.Write("\n");
            }
            Console.ReadKey(); // pause
            //4
            
            int[,] matrix = new int[1, 1];
            matrix[0, 0] = 200;
            Console.WriteLine(matrix[0, 0]);
            //int g = null;
            //int? g = null;
           // g = 0;
            //string str = 0;
            int? someValue = null;
            if (someValue == null)
            {
                Console.WriteLine("It's not good!");
            }
            else
            {
                Console.WriteLine("something real wrong!");
            }
            Console.WriteLine();
             */
            #endregion
            #region _3D_Arrays
            /*
              //1
            int[,,] array = new int[3, 3, 3];

            array[0, 0, 0] = 1;
            array[0, 0, 1] = 2;
            array[0, 0, 2] = 3;
            array[0, 1, 0] = 4;
            array[0, 1, 1] = 5;
            array[0, 1, 2] = 6;
            array[0, 2, 0] = 7;
            array[0, 2, 1] = 8;
            array[0, 2, 2] = 9;

            array[1, 0, 0] = 1;
            array[1, 0, 1] = 2;
            array[1, 0, 2] = 3;
            array[1, 1, 0] = 4;
            array[1, 1, 1] = 5;
            array[1, 1, 2] = 6;
            array[1, 2, 0] = 7;
            array[1, 2, 1] = 8;
            array[1, 2, 2] = 9;

            array[2, 0, 0] = 1;
            array[2, 0, 1] = 2;
            array[2, 0, 2] = 3;
            array[2, 1, 0] = 4;
            array[2, 1, 1] = 5;
            array[2, 1, 2] = 6;
            array[2, 2, 0] = 7;
            array[2, 2, 1] = 8;
            array[2, 2, 2] = 9;


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write("{0} ", array[i, j, k]);
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
            }


            //2
            int[,,] array2 =
            {
                {
                    { 1, 2, 3 },
                    { 4, 5, 6 },
                    { 7, 8, 9 }
                },
                { { 1, 2, 3 }, { 4, 5, 6 }, {7, 8, 9} },
                { { 1, 2, 3 }, { 4, 5, 6 }, {7, 8, 9} }
            };


            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write("{0} ", array2[i, j, k]);
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
            }
             */
            #endregion
            #region _4D_Arrays
            /*
             int[,,,] array = new int[2, 2, 2, 2];

            array[0, 0, 0, 0] = 0x0;
            array[0, 0, 0, 1] = 0x1;
            array[0, 0, 1, 0] = 0x2;
            array[0, 0, 1, 1] = 0x3;

            array[0, 1, 0, 0] = 0x4;
            array[0, 1, 0, 1] = 0x5;
            array[0, 1, 1, 0] = 0x6;
            array[0, 1, 1, 1] = 0x7;

            array[1, 0, 0, 0] = 0x8;
            array[1, 0, 0, 1] = 0x9;
            array[1, 0, 1, 0] = 0xA;
            array[1, 0, 1, 1] = 0xB;

            array[1, 1, 0, 0] = 0xC;
            array[1, 1, 0, 1] = 0xD;
            array[1, 1, 1, 0] = 0xE;
            array[1, 1, 1, 1] = 0xF;


            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        for (int l = 0; l < 2; l++)
                        {
                            Console.Write("{0:X} ", array[i, j, k, l]);
                        }
                        Console.Write('\n');
                    }
                    Console.WriteLine();
                }
                Console.Write("\n");
            }

            //2
            int[,,,] array2 =
             {
              {
                { { 0x0, 0x1 }, {0x2, 0x3 } },
                { { 0x4, 0x5 }, {0x6, 0x7 } }
              },
              {
                { { 0x8, 0x9 }, {0xA, 0xB } },
                { { 0xC, 0xD }, {0xE, 0xF } }
              }
            };


            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        for (int l = 0; l < 2; l++)
                        {
                            Console.Write("{0:X} ", array2[i, j, k, l]);
                        }
                        Console.Write("\n");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
            }
            */
            #endregion
            #region ArrayMethods
            /*
            Console.OutputEncoding = Encoding.UTF8;
            int[] myArr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            PrintArr("Массив myArr1", myArr1);
            int[] tempArr = (int[])myArr1.Clone(); // shallow copy
            PrintArr("Clone", tempArr);                                // cw        
            Array.Reverse(myArr1,5,3);
            PrintArr("Массив myArr1 после реверсирования", myArr1);
            myArr1 = tempArr;
            PrintArr("Массив myArr1 после восстановления", myArr1);
            int[] myArr2 = new int[20];
            PrintArr("Массив myArr2 до копирования", myArr2);
            myArr1.CopyTo(myArr2, 10);
            PrintArr("Массив myArr2 после копирования", myArr2);
            Console.WriteLine(myArr2.Length);
            Console.WriteLine(myArr2.GetLength(0));
            Array.Clear(myArr2, 8, 3);
            PrintArr("Массив myArr2 после чистки: ", myArr2);
            Array.Resize(ref myArr2, 5);
            PrintArr("Массив myArr2 после изменения размера:", myArr2);
            myArr2 = new[] { 1, 5, 3, 2, 8, 9, 6, 10, 7, 4 };
            PrintArr("Несортированый массив myArr2: ", myArr2);
            Array.Sort(myArr2);
            PrintArr("Массив myArr2 после сортировки: ", myArr2);
            Console.WriteLine(Array.IndexOf(myArr1, 5));
            Console.WriteLine("Число 5 находится в массиве на " +
                Array.BinarySearch(myArr2, 5) + " позиции");

            Console.WriteLine("Максимальный элемент в массиве myArr2: " + myArr2.Max());
            Console.WriteLine("Минимальный элемент в массиве myArr2: " + myArr2.Min());
            Console.WriteLine("Среднее арифметическое элементов myArr2: " + myArr2.Average());

            Console.WriteLine("Количество измерений массива myArr3: " + myArr2.Rank);
            int[,] myArr3 = { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine("Количество измерений массива myArr3: " + myArr3.Rank);
             */
            #endregion
            #region Jagged_array
            /*
              // зубчастий масив
            int[][]jagged = new int[3][];

            jagged[0] = new int[] { 1, 2 };
            jagged[1] = new int[] { 1, 2, 3, 4, 5 };
            jagged[2] = new int[] { 1, 2, 3 };

            Console.WriteLine(jagged.Length);

            // перебор с помощью цикла for
            for (int i = 0; i < jagged.Length; ++i)//3
            {
                for (int j = 0; j < jagged[i].Length; ++j)
                {
                    Console.Write($"{i};{j}={     jagged[i][j]     }  ");
                }
                Console.Write("\n");
            }

            Console.WriteLine();
            Console.ReadKey(); 

            foreach (int[] item in jagged)
            {
                foreach (int i in item)
                {
                    Console.Write(i + "\t");
                }
                Console.WriteLine();
            }
             */
            #endregion
            #region MethodsWithArray
            /*
               int[] myArray = { 1, 2, 3, 4, 5 };
            myArray = ModifyArray(myArray, 5);

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + ", ");
            }

            Console.ReadKey();
             */
            #endregion
            #region Params
             int[] arr = new int[] { 3, 3, 3, 7, 7, 7 };
           
             //ShowArray(10, arr);
            ShowArray("hello",10, 15, 14, 47, 2, 3, 6, 9, 8);
            //int a = 5;
            //ShowArray(5, new int[] { 3, 3, 3, 7, 7, 7 });

            // pause
            Console.ReadKey();
            #endregion

        }
        static void PrintArr(string text, int[] arr)
        {
            Console.Write(text + ": ");
            for (int i = 0; i < arr.Length; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
        static int[] ModifyArray(int[] array, int modifier)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] * modifier;
                //array[i] *= modifier;
            }

            return array;
        }
        static void ShowArray(int num, int[] array)
        {
            Console.WriteLine(num);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
        static void ShowArray(string str,int num, int num1, int num2, params int[] array)
        {
            Console.WriteLine(num);
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }

    }
}