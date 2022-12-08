// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int EnterNumber(string message){
Console.WriteLine(message);
return Convert.ToInt32(Console.ReadLine());
}

int Involution(int number1, int number2){
    int result = 1;
for (int i = 0; i < number2; i++){
    result = result * number1;
}
    return result;
}

void Start(){
   int number1 = EnterNumber("Введите число: "); 
   int number2 = EnterNumber("Введите степень числа: "); 
   int result = Involution(number1, number2);
   Console.WriteLine($"ответ равен: {result}");
}

Start();

