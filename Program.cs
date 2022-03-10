// В двумерном массиве n×k заменить четные элементы на противоположные.

Console.Clear();

Console.Write("Задайте размер массива по X: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Задайте размер массива по Y: ");
int n = int.Parse(Console.ReadLine());
Random rnd = new Random();
int[,] mass = new int[m, n];

void Fillmass(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(10, 100);
        }
    }
}

void Printmass(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void Changemass(int[,] array)
{
    int change = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            if (j % 2 == 0)
            {
                change = array[i, j];
                array[i, j] = array[i, j + 1];
                array[i, j + 1] = change;
            }
        }
    }
}

Fillmass(mass);
Printmass(mass);
Changemass(mass);
Console.WriteLine();
Printmass(mass);