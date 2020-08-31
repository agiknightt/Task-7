using System;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string message;
            int countOutput;

            Console.Write("Введите любое слово или текст : ");
            message = Console.ReadLine();

            Console.Write("Сколько раз повторить ваше сообщение? : ");
            countOutput = Convert.ToInt32(Console.ReadLine());

            while (countOutput-- > 0)
            {
                Console.WriteLine(message);
            }            
            Console.ReadKey();
        }
    }
}
