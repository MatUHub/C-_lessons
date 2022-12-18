// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int EnterNumber(string message){
    Console.WriteLine($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(Double [,] arr){
    for( int i = 0; i < arr.GetLength(0);i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            arr[i, j] = new Random().NextDouble()*10;
        }
    }
}

void ShowArray(Double [,] arr){
    for( int i = 0; i < arr.GetLength(0);i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            System.Console.Write($"{Math.Round(arr[i,j], 1)} |");
        }
        System.Console.WriteLine();
    }
}


int a = EnterNumber("Введите кол-во строк: ");
int b = EnterNumber("Введите кол-во столбцов: ");

Double [,] arr = new Double [a,b];

FillArray(arr);
ShowArray(arr);