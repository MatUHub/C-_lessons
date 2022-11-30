//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
int EnterNumber(){
Console.Write("Введите пятизначное число: ");
return Convert.ToInt32(Console.ReadLine());
}

int number = EnterNumber();

int number1 = number/10000;
number = number%10000;
int number2 = number/1000;
number = number%1000;
number = number%100;
int number3 = number/10;
number = number%10;
int number4 = number;

if (number1 == number4 && number2 == number3){
    Console.Write("да");
} else Console.Write("нет");
