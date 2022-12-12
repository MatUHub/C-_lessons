//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
void EnterParametrs(){
    Console.WriteLine("Введите значение b1: ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение k1: ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение b2: ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение k2: ");
    double k2 = Convert.ToDouble(Console.ReadLine());
    EquationCalculation(b1, k1, b2, k2);
}
 
void EquationCalculation(double b1, double k1, double b2, double k2){
    for(double x = -100; x < 100; x+=0.5){
        Console.WriteLine(x);
       if(k1*x+b1 == k2*x+b2){
        Console.WriteLine($"Точка пересечния двух прямых: ({x},{k1*x+b1})");
       }
    }
} 

EnterParametrs();
