//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. . Не использовать строки
int EnterNumber(){
Console.Write("Введите число: ");
return Convert.ToInt32(Console.ReadLine());
}
int enterNumber = EnterNumber();
int number = 1;

while (enterNumber > number) {
number = number * 10;
}
if (number > 999)
{
number = number/10;
int otvet = enterNumber%number;
number = number/10;
otvet = otvet%number;
number = number/10;
otvet = otvet/number;
Console.WriteLine($"Третья цифра цисла равна {otvet}");
}
else{
Console.WriteLine("Третьей цифры нет"); 
}