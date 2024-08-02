namespace FizzBuzzEngine
{
    public static class FizzBuzzEngine
    {
        const string Fizz = "Fizz";
        const string Buzz = "Buzz";
        const string Fizzbuzz = "Fizzbuzz";

        public static string Calculate(int number)
        {

            if (IsNumberDivisibleBy(number, 15))
            {
                Console.WriteLine(Fizzbuzz);
                return Fizzbuzz;
            }

            if (IsNumberDivisibleBy(number, 3))
            {
                Console.WriteLine(Fizz);
                return Fizz;
            }

            if (IsNumberDivisibleBy(number, 5))
            {
                Console.WriteLine(Buzz);
                return Buzz;
            }

            Console.WriteLine(number);
            
            return number.ToString();
        }


        private static bool IsNumberDivisibleBy(int number , int divBy)
        {
            if (number % divBy == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
