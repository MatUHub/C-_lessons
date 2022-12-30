// Задача: Написать программу, которая из имеющегося списка массива строки формирует массив из строк,
//длина которых меньше либо равна 3 символам. Перовначально массив можно ввести с клавиатуры, либо
// задать на старте выполнение алгоритма.

string [] str1 = {"hello", "2","world", "^-)"};
string [] str2 = new string[str1.Length];

for(int i = 0; i < str1.Length; i++){
    char [] b = str1[i].ToCharArray();
    if( b.Length <= 3){
        str2[i] = str1[i];
    }
}

for( int j = 0; j < str2.Length;j++){  
        System.Console.Write($"{str2[j]}  ");
    }    



