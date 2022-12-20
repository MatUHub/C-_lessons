// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
void ShowArray(int [,] arr){
    for( int i = 0; i < arr.GetLength(0);i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            System.Console.Write($"{arr[i,j]} |");
        }
        System.Console.WriteLine();
    }
}

void MaxToMin(int [,] arr){
    for(int c = 0; c<arr.GetLength(1); c++){
    for( int i = 0; i < arr.GetLength(0);i++){
        int a = 0;
        for (int j = 0; j < arr.GetLength(1)-1; j++){
           if(arr[i,j]< arr[i,j+1]){
            a = arr[i,j];
arr[i,j] = arr[i,j+1];
arr[i,j+1] = a;
           } 
        }
        System.Console.WriteLine();
    }
}
}


int [,] arr = {{1,4,7,2}, {5,9,2,3}, {8,4,2,4}};
ShowArray(arr);
MaxToMin(arr);
ShowArray(arr);

