Console.WriteLine("Программа принимает на вход два числа и выдает, какое число больше.");
Console.WriteLine("Введите первое число: ");
string inputValue1 = Console.ReadLine();
Console.WriteLine("Введите второе число: ");
string inputValue2 = Console.ReadLine();

int value1 = Convert.ToInt32(inputValue1);
int value2 = Convert.ToInt32(inputValue2);

int max = 0;

if (value1 > value2)
{
max = value1;
} 
else 
{
    max = value2;
}

System.Console.WriteLine($"Максимальное значение равно {max}");


