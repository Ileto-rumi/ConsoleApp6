namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int N = int.Parse(Console.ReadLine());

            
            if (N < 10 || N > 100)
            {
                Console.WriteLine("Vuvedete chislo mejdu 10 i 100");
                return;
            }

            
            List<int> evenNumbers = new List<int>();
            Stack<int> oddNumbers = new Stack<int>();

            
            Random rand = new Random();
            Console.WriteLine($"Генерирани числа:");
            for (int i = 0; i < N; i++)
            {
                int number = rand.Next(1, 102); 
                Console.Write(number + " ");

                
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
                else
                {
                    oddNumbers.Push(number);
                }
            }

            Console.WriteLine("Izhod");
            foreach (var even in evenNumbers)
            {
                Console.Write(even + " ");
            }

           
            while (oddNumbers.Count > 0)
            {
                Console.Write(oddNumbers.Pop() + " ");
            }
        }
    }
}
