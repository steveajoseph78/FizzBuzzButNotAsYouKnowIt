const int startNumber = 1;
const int endNumber = 100;


FizzBuzzEngine.FizzBuzzEngine fizzBuzzEngine = new FizzBuzzEngine.FizzBuzzEngine();

for (int num = startNumber; num <= endNumber; num++)
{
    fizzBuzzEngine.Calculate(num);
}
