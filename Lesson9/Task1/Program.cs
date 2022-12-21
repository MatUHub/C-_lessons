// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
int EnterNumber(string message){
    Console.WriteLine($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}

int m = EnterNumber("Введите значение М");
int n = EnterNumber("Введите значение N");
RecursNumbers(m, n);
void RecursNumbers(int m, int n){
    if (m > n) return;
    if (m%2 == 0) Console.Write($"{m} ");
    RecursNumbers(m + 1, n);
}
