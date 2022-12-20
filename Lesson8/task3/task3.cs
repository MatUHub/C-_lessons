//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц
int [,] matrix1 = {{2,4,1}, {3,2,1}};
int [,] matrix2 = {{3,4}, {3,3}, {1,1}};
Multimatrix(matrix1, matrix2);

void Multimatrix(int [,] matrix1, int [,] matrix2){
    int [,] matrix3 = new int [2, 2];
    for( int a = 0; a<2; a++){
    for(int i = 0; i<2; i++){
        matrix3[a,i] = 0;
        for(int j = 0; i < 2; j++){
            matrix3[a,i] += matrix1[a,j] * matrix1[j,i]; 
        }
    }
}
ShowArray(matrix3);
}

void ShowArray(int [,] arr){
    for( int i = 0; i < arr.GetLength(0);i++){

        for (int j = 0; j < arr.GetLength(1); j++){
            System.Console.Write($"{arr[i,j]} |");
        }
        System.Console.WriteLine();
    }
}
