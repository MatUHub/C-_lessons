// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии

int EnterNumber(string message){
    Console.WriteLine($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}

int m = EnterNumber("Введите значение М");
int n = EnterNumber("Введите значение N");

Console.WriteLine(SumNumbers(m, n));
int SumNumbers(int m, int n){
if(m == n) return n;
return m + SumNumbers(m + 1, n);
}