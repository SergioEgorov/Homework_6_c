//Задача 40.

Console.Write("Введите разрад числа Фибоначчи: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
array[0] = 0;
array[1] = 1;
Console.WriteLine(array[0]);
Console.WriteLine(array[1]);

for (int i = 2; i < size; i++)
{
    int nextIndex = array[0] + array[1];
    array[0] = array[1];
    array[1] = nextIndex;
    Console.WriteLine(nextIndex);
}
