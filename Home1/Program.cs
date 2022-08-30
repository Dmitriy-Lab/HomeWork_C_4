// Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.

Console.WriteLine("Введите число А: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

if(numB >= 0)
{
    double result = Math.Pow(numA, numB);           // numA возводим в степень numB 
    Console.WriteLine(result);
}
else 
{
   Console.WriteLine("Число B не натуральное"); 
}