// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. Не использовать строки для расчета
int EnterNumber(){
Console.Write("Трехзначное число равно: ");
int value = new Random().Next(100, 999);
Console.WriteLine(value);
return value;
}

int number = EnterNumber();
int number1 = (number/100)*10;
int number2 = number%100;
number2 = number2%10;
number = number1 + number2;

Console.WriteLine($"Без второй цифры равно {number}");