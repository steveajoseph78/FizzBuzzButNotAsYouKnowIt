namespace FizzBuzzEngine
{
    public static class FizzBuzzEngine
    {
        public static string Calculate(int number)
        {

            if (IsNumberDivisibleBy(number, 15)) // Always perform this check first! As if true other conditions will also return true
            {
                Console.WriteLine(ConstantsFizzBuzz.Fizzbuzz);
                return ConstantsFizzBuzz.Fizzbuzz;
            }

            if (IsNumberDivisibleBy(number, 3))
            {
                Console.WriteLine(ConstantsFizzBuzz.Fizz);
                return ConstantsFizzBuzz.Fizz;
            }

            if (IsNumberDivisibleBy(number, 5))
            {
                Console.WriteLine(ConstantsFizzBuzz.Buzz);
                return ConstantsFizzBuzz.Buzz;
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
