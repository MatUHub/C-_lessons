// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
void ShowArray(int [,] arr){
    for( int i = 0; i < arr.GetLength(0);i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            System.Console.Write($"{arr[i,j]} |");
        }
        System.Console.WriteLine();
    }
}

int MinSum(int [,] arr){
        int sum1 = 0;
        int sum2 = 0;
        int numberline = 0;
    for( int i = 0; i < arr.GetLength(0);i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            sum2 = sum2 + arr[i,j];
        }
        if (sum1 > sum2){
            sum1 = sum2;
numberline = i;
        } 
        System.Console.WriteLine();
    }
    return numberline;
}

int [,] arr = {{1,4,7,2}, {5,9,2,3}, {8,4,2,4}, {5,2,6,7}};
ShowArray(arr);
System.Console.WriteLine($" строка с нименьшей суммой элементов: {MinSum(arr) + 1}");
