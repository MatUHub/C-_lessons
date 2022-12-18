// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void FillArray(int [,] arr){
    for( int i = 0; i < arr.GetLength(0);i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

int EnterNumber(string message){
    Console.WriteLine($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}

void ShowArray(int [,] arr){
    for( int i = 0; i < arr.GetLength(0);i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            System.Console.Write($"{arr[i,j]} |");
        }
        System.Console.WriteLine();
    }
}

void MidArifm(int [,] arr){
     System.Console.Write($"среднее арифметическое каждого столбца равно: ");
    for( int i = 0; i < arr.GetLength(0);i++){
        double a = 0;
        for (int j = 0; j < arr.GetLength(1); j++){
            a = a +arr[i,j];
        }
        System.Console.Write($"{a/arr.GetLength(1)} ");
    }
}

int [,] arr = new int [4,5];

FillArray(arr);
ShowArray(arr);
MidArifm(arr);
