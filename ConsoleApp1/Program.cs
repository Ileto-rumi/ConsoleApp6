namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int N = int.Parse(Console.ReadLine());

           
            if (N < 5 || N > 55)
            {
                Console.WriteLine("Chisloto da me mejdu 5 i 55.");
                return;
            }

            
            Stack<int> fibonacciStack = new Stack<int>();

            
            int a = 1, b = 1;

           
            fibonacciStack.Push(a);
            if (N > 1)
            {
                fibonacciStack.Push(b);
            }

            
            for (int i = 3; i <= N; i++)
            {
                int next = a + b;
                fibonacciStack.Push(next);
                a = b;
                b = next;
            }

            
            Console.Write("Изход: ");

            List<int> fibonacciNumbers = new List<int>();

           
            while (fibonacciStack.Count > 0)
            {
                fibonacciNumbers.Add(fibonacciStack.Pop());
            }

           
            for (int i = 0; i < fibonacciNumbers.Count; i++)
            {
                Console.Write(fibonacciNumbers[i]);
                if (i < fibonacciNumbers.Count - 1)
                {
                    Console.Write("; ");
                }
            }
        }
    }
}
