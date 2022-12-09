// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateArray()
{
    Console.WriteLine("Введите размер массива: ");
    int arLen = Convert.ToInt32(Console.ReadLine());
    int[] newArray = new int[arLen];
    for (int i = 0; i < newArray.Length; i++)
    {
        Random ran = new Random();
        int number = ran.Next(100, 999);
        newArray[i] = number;
    }
    ShowArray(newArray);
    return newArray;
}

void EvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count = count + 1;
    }
    Console.WriteLine($"Кол-во четных чисел в массиве равно: {count}");
}

void ShowArray(int[] array)
{
    Console.Write("Массив равен: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}   ");
    }
}

EvenNumbers(CreateArray());
