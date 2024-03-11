// Ex. 1: Scrieti o functie care va calcula suma cifrelor unui numar.

Console.WriteLine("Enter three nunbers: ");

int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());

int sum = SumOfNumbers(firstNumber, secondNumber, thirdNumber);

Console.WriteLine("The sum of the three numbers is: " + sum);

int SumOfNumbers(int a, int b, int c)
{
    int result = a + b + c;
    return result;
}