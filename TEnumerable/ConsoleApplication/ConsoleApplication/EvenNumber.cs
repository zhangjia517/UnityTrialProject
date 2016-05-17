namespace ConsoleApplication
{
    public class EvenNumber
    {
        public System.Collections.Generic.IEnumerable<int> EvenSequence(int firstNum, int lastNum)
        {
            for (int number = firstNum; number <= lastNum; number++)
            {
                if (number % 2 == 0)
                {
                    yield return number;
                }
            }
        }
    }
}