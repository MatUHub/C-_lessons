//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 

int EnterNumber(){
Console.Write("Введите трехзначное число: ");
return Convert.ToInt32(Console.ReadLine());
}

int number = EnterNumber();
number = number%100;
Console.WriteLine(number);
number = number/10;
Console.WriteLine(number);

Console.WriteLine($"Вторая цифра трехзначного числа {number}");
