// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма цифр = "+GetSum(num));     // Выводим результат

int GetSum(int number)                              // Функция
{
    int sum = 0;
    while (number > 0)
        {
        sum += number % 10;
        number /= 10;
         }
    return sum;                                     // Возвращаем значение
}
