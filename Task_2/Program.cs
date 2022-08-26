// // Задача 41: 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа: ");
int numbers = Convert.ToInt32(Console.ReadLine());
int [] array = new int[numbers];
int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers > 0)
    {
        count++;
    }
}
Console.WriteLine();
Console.WriteLine($"Количество чисел больше 0 = {count}");

