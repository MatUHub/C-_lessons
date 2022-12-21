// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
long EnterNumber(string message){
    Console.WriteLine($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}

long m = EnterNumber("Введите значение М");
long n = EnterNumber("Введите значение N");

Console.WriteLine(Akerman(m, n));
long Akerman(long m, long n){
if ( m == 0) return n = n+1;
if ( m != 0 && n == 0) return Akerman(m - 1, 1);
if (m > 0 && n > 0)return Akerman(m - 1, Akerman(m, n - 1));
return Akerman(m , n);
}

