using System;
using System.Threading.Tasks;

namespace TaskApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Task<int> summ = new Task<int>(() =>
            {
                
                for (int i = 1; i < 101; i++)
                {
                    sum += i;
                }
                return sum;
                
            });
            summ.Start();
            Console.WriteLine(summ.Result);
            Console.ReadLine();
        }
    }
}
