/*Ex. 4: Scrieti un program care va inversa elementele unui vector
 Lungimea vectorului va fi citita de la tastatura
 Inversarea elementelor va fi facuta in functia Main (fara o functie dedicate)
 Afisarea vectorului se va face printr-o functie de afisare dedicata
 */

Console.WriteLine("Enter the lenght of the vector: ");

int number = int.Parse(Console.ReadLine());

int[] vector = new int[number];

for(int i = 0; i < number; i++)
{
    Console.WriteLine($"Elements of the vector are: {i + 1}");
    vector[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Before reverse: ");
DisplayVector(vector);

for (int i = 0; i < number / 2; i++)
{
    int temp = vector[i];
    vector[i] = vector[number - 1 - i];
    vector[number - 1 - i] = temp;
}

Console.WriteLine("After reverse: ");
DisplayVector(vector);

void DisplayVector(int[] vector)
{
    foreach(int i in vector)
    {
        Console.WriteLine(i);
    }
}

