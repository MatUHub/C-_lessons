// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Реализовать через функции.
int EnterNumber(){
Console.WriteLine("Введите число: ");
return Convert.ToInt32(Console.ReadLine());
}

void Start(){
    int number = EnterNumber();
    int result = 0;
    for( int i = 1; i <= number; i++){
        result = result + i;
    }
    Console.WriteLine($"Результат равен: {result}");
}

Start();
