using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;
namespace ConsoleApp1
{ 
    using static Console;
    class Program
    {
        static void Main()
        {
            #region Ex 6
            Turtle.Speed = 8; 
            int n = 30;
            int ang = 360 / n;
            for (int j = 0; j < n; j++)
            {

                for (int i = 0; i < n; i++)
                {
                    Turtle.Move(15);
                    Turtle.Angle += ang;
                }
                Turtle.Angle += ang;
            }
                    #endregion

            #region Ex 5
            //double[] mass1 = new double[4];
            //double sum = 0;
            //for (int i = 0; i < mass1.Length; i++)
            //{
            //    Console.Write($"ВВедите arr[{i}]: ");
            //    mass1[i] = Convert.ToDouble(Console.ReadLine());
            //    sum += mass1[i];
            //}
            //Console.WriteLine($"Сумма: {sum}");

            #endregion

            #region Ex 4
            //Console.Write("Введите ваше Имя: ");
            //string name = Console.ReadLine();
            //if (name.ToLower() == "андрей" || name.ToLower() == "михаил")
            //{
            //    Console.WriteLine("Привет, красавчик!");
            //}
            //else
            //{
            //    Console.WriteLine("Доброе время суток, и уходите!!!");
            //}

            #endregion

            #region Ex 3
            //Console.Write("Введинте первое число: ");
            //int Value1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введинте второе число: ");
            //int Value2 = int.Parse(Console.ReadLine());
            //int result = Value1 + Value2;
            //Console.WriteLine(Convert.ToString(Value1) + " + " + Convert.ToString(Value2) + " = " + Convert.ToString(result));//+-
            //Console.WriteLine(Value1.ToString() + " + " + Value2.ToString() + " = " + result.ToString());//+-
            //Console.WriteLine("{0} + {1} = {2}", Value1, Value2, result); //+-
            //Console.WriteLine(String.Format("{0} + {1} = {2}", Value1,Value2, result));
            //Console.WriteLine(String.Format($"{Value1} + {Value2} = {result}"));
            #endregion

            #region Ex 2
            //Console.Write("Введите ваше имя: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Привет, " + name +"!");

            #endregion

            #region Ex 1
            //WriteLine("Привет!");
            ReadKey();


            #endregion 
        }
    }
}
