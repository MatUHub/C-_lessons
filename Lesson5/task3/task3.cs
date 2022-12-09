// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
int[] CreateArray()
{
    Console.WriteLine("Введите размер массива: ");
    int arLen = Convert.ToInt32(Console.ReadLine());
    int[] newArray = new int[arLen];
    for (int i = 0; i < newArray.Length; i++)
    {
        Random ran = new Random();
        int number = ran.Next(0, 100);
        newArray[i] = number;
    }
    ShowArray(newArray);
    return newArray;
}

void ShowArray(int[] array)
{
    Console.Write("Массив равен: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}   ");
    }
}

void Result(int[] array)
{
    int max = array[0];
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i];
        if (max < array[i]) max = array[i];
    }

    Console.Write($" Разница между максимальным и минимальным значением {max - min}");
}

Result(CreateArray());