// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
String EnterNumber(){
Console.WriteLine("Введите числа: ");
return Console.ReadLine();
}

void ShowResult(){
    String [] str = EnterNumber().Split(',', ' ');
    int count = 0;
    foreach( String ch in str){
        int a = Convert.ToInt32(ch);
        if(a > 0){
          count++;
        }
    }
    Console.WriteLine($"Кол-во чисел больше нуля: {count}");
}

ShowResult();



