//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();

Console.WriteLine("Введите число элементов массива");
int [] array = new int [Convert.ToInt32(Console.ReadLine())];
Random rnd = new Random();

int i = 0;
for (i = 0; i < array.Length; i++)
{
    array [i] = rnd.Next (100, 999);
}
Console.WriteLine($"Заданный массив: "+ '[' + string.Join(", ", array) + ']');

int sum = 0;
int index = 0;
for (index = 0; index<array.Length; index++)
{
    if (array [index] % 2 == 0)
    {
        sum = sum + 1;
    }
}
System.Console.WriteLine("Количество четных чисел в заданном массиве равно " + sum);