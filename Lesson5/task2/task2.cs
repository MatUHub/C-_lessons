// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] CreateArray()
{
    Console.WriteLine("Введите размер массива: ");
    int arLen = Convert.ToInt32(Console.ReadLine());
    int[] newArray = new int[arLen];
    for (int i = 0; i < newArray.Length; i++)
    {
        Random ran = new Random();
        int number = ran.Next(-100, 100);
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

void OddPositions(int[] array)
{
    int count = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (i % 2 != 0) count = count + array[i];
    }
    Console.Write($"Сумма элементов стоящих на нечетных позициях {count}");

}

OddPositions(CreateArray());
