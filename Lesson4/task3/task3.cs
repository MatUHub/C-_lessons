// Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами.

void Start(){
    int [] newArray = new int [8];
    for(int i = 0; i < 8; i++){
        Random ran = new Random();
        int number = ran.Next(0, 100);
        newArray[i] = number;
    }
    ShowArray(newArray);
}

void ShowArray(int [] array){
    for(int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]}, ");
    }
}

Start();