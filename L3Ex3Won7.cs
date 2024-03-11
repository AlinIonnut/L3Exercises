/* Ex. 3: Se citeste de la tastatura un vector continant n numere intregi, n fiind si el citit la randul sau citit de la tastatura. Scrieti functii care vor returna
• Cel mai mare numar din vector
• Cel mai mic numar din vector
• Numerele divizibile cu 3
• Numerele patrate perfecte din vector
 
 */
Console.WriteLine("Enter how many elements should the vector have: ");

int number = int.Parse(Console.ReadLine());
int[] vector = ShowVector(number);

Console.WriteLine("Elements of the vector are: ");
foreach(int element in vector)
{
    Console.WriteLine(element);
}

int max = BiggestElementOfVector(vector);
Console.WriteLine("The biggest element from the vector is: " + max);

int min = SmallestElementOfVector(vector);
Console.WriteLine("The smallest element from the vector is: " + min);

int divisible = ElementsDivisibleWithThree(vector);
Console.WriteLine("The numbers divisible with three are: " + divisible);

double count = PerfectSquare(vector);
Console.WriteLine("The numbers that are perfect square are: " + count);

int[] ShowVector(int n)
{
    int[] vector = new int[n];
    for (int i = 0; i < n; i++) 
    {
        Console.WriteLine($"You need to enter the vector element number: {i + 1}");
        vector[i] = int.Parse(Console.ReadLine());
    }
    return vector;
}

int BiggestElementOfVector(int[] vector)
{
    int max = vector.Max();
    return max;
}

int SmallestElementOfVector(int[] vector)
{
    int min = vector.Min();
    return min;
}

int ElementsDivisibleWithThree(int[] vector)
{
    int count = 0;
    foreach(int element in vector)
    {
        if( element % 3 == 0)
        {
            Console.WriteLine(element + " is divisible with 3.");
            count++;
        }
        else
        {
            Console.WriteLine(element + " is not divisible with 3.");
        }
    }
    return count;
}

int PerfectSquare(int[] vector)
{
    int count = 0;
    foreach(int element in vector)
    {
        double Square = Math.Sqrt(element);
        if (Square == Math.Floor(Square))
        {
            Console.WriteLine(element + " is a perfect square!");
            count++;
        }
        else
        {
            Console.WriteLine(element + " is not a perfect square!");
        }
    }
    return count;
}