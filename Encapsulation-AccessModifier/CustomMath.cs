namespace Encapsulation_AccessModifier
{
    internal class CustomMath
    {
        public void GetOddNumberSum(params int[] nums)
        {
            int sum = 0;
            foreach (var item in nums)
            {
                if (item % 2 == 1)
                {
                    sum += item;
                }
            }
            Console.WriteLine($"result = {sum}");
        }


        public void CheckNumber(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is even number");
            }
            else
            {
                Console.WriteLine($"{num} is odd number number");
            }
        }


        public void GetEvenNumbersSumSquare(params int[] nums)
        {
            int sum = 0;
            foreach (var item in nums)
            {
                if (item % 2 == 0)
                {
                    sum += item;
                }
            }
            int result = sum * sum;
            Console.WriteLine($"result = {result}");
        }


        public void Factorial(int num)
        {
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"factorial of {num} is {factorial}");
        }
    }
}
