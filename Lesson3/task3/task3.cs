// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int EnterNumber(){
Console.Write("Введите число: ");
return Convert.ToInt32(Console.ReadLine());
}

int enterNumber = EnterNumber();
for (int i = 1; i <= enterNumber; i++){
    if (i == enterNumber) Console.Write($"{i*i*i} ");
    else Console.Write($"{i*i*i}, ");
}