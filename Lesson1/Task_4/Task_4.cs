Console.WriteLine("Программа принимает на вход число N и выдает, все четные числа от 1 до N.");
Console.WriteLine("Введите число: ");
string inputValue1 = Console.ReadLine();
int value1 = Convert.ToInt32(inputValue1);
Console.WriteLine("Результат равен: ");
for(int i=1;value1>=i;i++){
    if (i%2==0){
       Console.Write(i);
    }
}