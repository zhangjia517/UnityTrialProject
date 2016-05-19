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
            //Zoo theZoo = new Zoo();
            //theZoo.AddBird("Eagle");
            //theZoo.AddBird("Dragon");
            //theZoo.AddMammal("Pig");
            //theZoo.AddMammal("Monkey");

            //foreach (string name in theZoo)
            //{
            //    Console.Write(name + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //foreach (string name in theZoo.Birds)
            //{
            //    Console.WriteLine(name + " ");
            //}
            //Console.WriteLine();
            //foreach (string name in theZoo.Mammals)
            //{
            //    Console.WriteLine(name + " ");
            //}
            #endregion

            #region 示例4 Stack
            Stack<int> theStack = new Stack<int>();
            for (int number = 0; number < 15; number++)
            {
                theStack.Push(number);
            }

            foreach (int number in theStack)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();

            foreach (int number in theStack.TopToBottom)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();

            foreach (int number in theStack.BottomToTop)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();

            foreach (int number in theStack.TopN(5))
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();

            #endregion
            Console.ReadKey();
        }
    }
}