using System;

namespace ConsoleApplication
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region 示例1 偶数
            //EvenNumber evenNumbers = new EvenNumber();
            //foreach (int number in evenNumbers.EvenSequence(5, 18))
            //{
            //    Console.Write(number.ToString() + " ");
            //}
            #endregion

            #region 示例2 日历
            //DaysOfTheWeek days = new DaysOfTheWeek();
            //foreach (string day in days)
            //{
            //    Console.Write(day + " ");
            //}
            #endregion

            #region 示例3 动物园
            Zoo theZoo = new Zoo();
            theZoo.AddBird("Eagle");
            theZoo.AddBird("Dragon");
            theZoo.AddMammal("Pig");
            theZoo.AddMammal("Monkey");

            foreach (string name in theZoo)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            foreach (string name in theZoo.Birds)
            {
                Console.WriteLine(name + " ");
            }
            Console.WriteLine();
            foreach (string name in theZoo.Mammals)
            {
                Console.WriteLine(name + " ");
            }
            #endregion

            Console.ReadKey();
        }
    }
}