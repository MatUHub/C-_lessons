//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

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

void ShowResult(int [,] arr, int a, int b){
    try{
     System.Console.Write($"резултат равен {arr[a,b]}");
    }

    catch{
      System.Console.Write("такого числа в массиве нет");
    }
   
}

int a = EnterNumber("Введите строку: ");
int b = EnterNumber("Введите столбец: ");

int [,] arr = new int [4,5];

FillArray(arr);
ShowArray(arr);

ShowResult(arr, a, b);
