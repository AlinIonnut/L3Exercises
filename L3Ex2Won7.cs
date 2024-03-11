// Ex. 2: Scrieti o functie care va determina daca un numar este sau nu patrat perfect. Apelati-o si afisati-i rezultatul

Console.WriteLine("Enter a number and let's find out it's is a perfect square!");

int value = int.Parse(Console.ReadLine());

Console.WriteLine(PerfectSquare(value));

double PerfectSquare(double number)
{
    if (number > 0)
    {
        double x = Math.Sqrt(number);

        if (x == Math.Floor(x))
        {
            Console.WriteLine("The number is a perfect square!");
        }
        else
        {
            Console.WriteLine("The number is not a perfect square!");
        }
        return x;
    }
    return double.NaN;
}