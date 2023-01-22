// Задайте массив вещественных чисел. Найдите разницу между максимальным и 
//минимальным элементом массива.
//[3 7 22 2 78] -> 76

Console.Clear();

int [] generateArray (int lenght, int start, int end)
{
    int [] result = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        result[i] = new Random().Next(start, end +1);
    }
    return result;
}

void printArray(int[] array)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write("[");
    Console.ResetColor();
    for (int i = 0; i < array.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write(array[i]);
        Console.ResetColor();
        if (i < array.Length - 1)
        {
            
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(", ");
            Console.ResetColor();
        }
    }
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("]");
    Console.ResetColor();
}

int getMaxDigit(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
            
}

int getMinDigit(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
            
}

int getDifferenceMaxMin(int max, int min)
{
    int difference = max - min;
    return difference;
}

int[] Array = generateArray(6,0,99);
printArray(Array);
int max = getMaxDigit(Array);
int min = getMinDigit(Array);
int difference = getDifferenceMaxMin(max,min);
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"Разница между максимальным и минимальным элементом массива - {difference}");
Console.ResetColor();