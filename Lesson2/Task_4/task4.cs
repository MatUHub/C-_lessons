//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. Не использовать
int EnterNumber(){
Console.Write("Введите число: ");
return Convert.ToInt32(Console.ReadLine());
}

int number = EnterNumber();
if (number < 6)
{
    Console.WriteLine("нет");
}
else
{
    Console.WriteLine("да");
}