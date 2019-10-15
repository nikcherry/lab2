using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Лаба_2
{
    class Program
    {
        

        static void Main()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 }; // массив для функции 
            void func(int[] arr1, string str) // создаем локлаьную функцию
            {
                int min = arr1[0];
                int max = arr1[0];
                int sum = 0;
                (int, int, int, char) krt; // кортеж для записи результата 
                for (int i = 0; i < arr1.Length; i++) // поиск максимального и минимального элементов и суммы всех элементов 
                {
                    if (arr1[i] < min)
                        min = arr[i];
                    if (arr1[i] > max)
                        max = arr1[i];
                    sum += arr1[i];
                }
                char ch1 = str[0]; // поиск первого символа строки 
                krt.Item1 = min; // инициализация элементов кортежа 
                krt.Item2 = max;
                krt.Item3 = sum;
                krt.Item4 = ch1;
                Console.WriteLine(krt); // вывод кортежа 
            }
            func(arr, "googlLOL"); // вызов локлаьной функции 
        }

        public static int local(int[] numbers, string temp)
        {
            

            for (int i = 0; i < numbers.Length; i++)
            {

                Console.WriteLine(numbers[i]);

            }
            Console.WriteLine("Размерность массива:" + numbers.Length);
            return 0;
        }

        public static void variables() //№1.1
        {
            int a;
            a = 5;

            bool b;
            b = true;

            long c = 10;

            float f = 5.5f;

            char g = 'g';

            double d = 3D;
            d = 4.0;

            decimal myMoney = 300.5m;
            myMoney = 400.75M;


        }

        public static void transformation() //№1.2
        {
            int a = 35;
            short b = 10;
            long c = 10;
            double d = 3D;
            float f = 5.5f;
            string hello = "Hello!";
            string Bye = "Bye!";
            c = a;
            a = b;
            c = b;
            d = f;
            hello = Bye;
            ////////////////
            c = (short)b;
            c = (int)a;
            d = (float)f;
            hello = (string)Bye;
            c = (short)a;
        }

        //  упаковка(boxing) и распаковка(unboxing).
        public static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
        public static void boxingUnboxing() //№1.3
        {// значемый в сылочный 
            int x = 7;
            int y = 25; 
            Swap<int>(ref x, ref y);
            Console.WriteLine($"x={x}    y={y}");   // x=25   y=7

            string s1 = "hello";
            string s2 = "bye";
            Swap<string>(ref s1, ref s2);
            Console.WriteLine($"s1={s1}    s2={s2}"); // s1=bye   s2=hello

            Console.Read();
        }



        public static void implicitlyVar() //№1.4
        {
            var number = 5; //  int
            var text = "some text"; //  string
          

            // number = "some text";   ошибка
            text = "Hello C#"; 
        }

        public static void nullableVar() //№1.5
        {
            Object a = null; 
            string b = null;
            ////
            bool? c = null;
        }



        public static void stringVar() //№2.1
        {

            
                string flag;
                string a = "hello";
                string b = "Hello University";
                if (a.Length > b.Length)
                {
                    flag = "Yes";
                    Console.WriteLine("Строка a больше, чем строка b? : " + flag);
                }
                else
                {
                    flag = "No";
                    Console.WriteLine("Строка a больше, чем строка b? : " + flag);
                }
            
        }
      
        public static void actionLines() //№2.2
        {
            string temp = null;
            string a = "hi Google";
            string b = "hello";
            string c = "Hello University";

            temp = a + " " + b; //сцепление
            Console.WriteLine(temp);
        }

        static void copyMain() //копировние
        {
            Console.Write("Введите строку: ");
            string txt = Console.ReadLine();
            string result = Copy(txt, 5);
            Console.WriteLine("Новая строка: {0}", result);

            Console.ReadLine();
        }

        public static string Copy(string text, int count)
        {
            string tempStr = "";
            for (int i = 0; i < count; i++)
                tempStr += text;
            return tempStr;
        }

        public static void substringVar() // выделение подстроки +  разделение строки на слова
        {
            string text = "сколько у нас тут построк и строк?";

            string[] words = text.Split(new char[] { ' ' });

            foreach (string s in words)
            {
                Console.WriteLine(s);
            }

        }

        public static void insert() //вставки в заданную позицию
        {
            string text = "должен начинаться с чашечки кофе";
            string subString = "Вторник ";

            text = text.Insert(0, subString);
            Console.WriteLine(text);
        }

        public static void del() //удаление заданной подстроки.
        {
            string tempText = "Я учусь в БГТУA";
          
            int delText = tempText.Length - 1;
            
            tempText = tempText.Remove(delText);
            Console.WriteLine(tempText);

            //// вырезаем первые два символа
            //tempText = tempText.Remove(0, 2);
        }

        public static void emptilyNull()
        {
            string tempTxt_1 = "";
            string tempTxt_2 = null;

            Console.WriteLine("Plus: " + (tempTxt_1 + tempTxt_2));//Конкатенация строк
            Console.WriteLine("Equals: " + (tempTxt_1.Equals(tempTxt_2))); //Метод Equals позволяет сравнить два объекта на равенство
            Console.WriteLine("CompareTo: " + tempTxt_1.CompareTo(tempTxt_2));//Метод Compare предназначен для сравнения двух объектов o1 и o2
            Console.WriteLine("String.Concat: " + String.Concat(tempTxt_2, tempTxt_1)); //Конкатенация строк
            string[] array = { tempTxt_1, tempTxt_2 };

        }

        public static void stringBuilder() //2.4 StringBuilder
        {

            StringBuilder tempSB = new StringBuilder("Hello world");
            tempSB.Append("!"); //Append - этот метод добавляет к строке подстроку
            tempSB.Insert(7, "компьютерный ");
            Console.WriteLine(tempSB);

            // заменяем слово
            tempSB.Replace("Hello", "Bye");
            Console.WriteLine(tempSB);

            // удаляем 10 символов, начиная с 5-го
            tempSB.Remove(5, 10);
            Console.WriteLine(tempSB);
        }


        public static void arrTwo() //3.0
        {
            int[,] mas = { { 1,2,3 }, { 4,5,6 }, { 7,8,9 }, { 10,11,12 } };

            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mas[i, j]} \t");
                }
                Console.WriteLine();
            }
        }


        public static void arrOne(int x, int cur) //3.1
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < numbers.Length; i++)
            {
                if(i == cur)
                {
                    numbers[i] = x;
                }
                int counter = 0;
                ++counter;
                Console.WriteLine(numbers[i]); 
                  
            }
            Console.WriteLine("Размерность массива:" + numbers.Length);

        }


        public static void arrSteps() //3.2
        {
            int[][] numbers = new int[3][];
            numbers[0] = new int[] { 1, 2 };
            numbers[1] = new int[] { 1, 2, 3 };
            numbers[2] = new int[] { 1, 2, 3, 4 };
           

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    Console.Write($"{numbers[i][j]} \t");
                }
                Console.WriteLine();
            }
        }

        public static void arr() //3.3
        {
            var A = new[] { 5.5 , 10, 23, 16, 8 };
            var str = "";
        }

        public static void tupleVar() //4.0+1+2
        {

            (string, int, double, char, ulong) person = ("Tom", 25, 81.23,'P',100);
            Console.WriteLine(person.Item1);

            var (name, age) = ("Tony", 23);
            Console.WriteLine(name  +" "+ age);

        }
        public static void tupleVar1() //4.3
        {

            var age = (45);
            var _age = (47);
           if(age == _age)
            {
                return;
            }
            Console.WriteLine("Враки!!!");
        }

    }
}