// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] array = new int[8];

int length = array.Length;
int index = 0;
Console.WriteLine(" ");
Console.Write("[");                                 // Добавляем вывод как в условии задачи - в виде массива с квадратными скобками
while (index < length)
{
    array[index] = new Random().Next(0, 1000);
    if( index < length - 1)                         // Отделяем последний элемент массива, чтобы убрать запятую
    {
        Console.Write(array[index]+", ");
    }
    else
    {
        Console.Write(array[index]); 
    }
    index++;
}

Console.Write("] ");
Console.WriteLine(" ");