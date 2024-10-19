namespace minMaxFromArr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 12, 2, 0, 20, 1500 };

            int minValue = numbers[0];
            int sum = 0;
            int count = 0;

            
            foreach (int number in numbers)
            {
                if (number < minValue)
                {
                    minValue = number;
                }

                sum += number;
                count++;
            }

            double average = (double)sum / count;

            Console.WriteLine($"Минимальное значение: {minValue}");
            Console.WriteLine($"Среднее значение: {average}");
        }
    }
}
