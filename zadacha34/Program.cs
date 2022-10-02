/*Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.*/
Console.WriteLine("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[arraySize];
FillArrayRandomThreeNumbers(numbers);
Console.WriteLine("Ваш массив: ");
PrintArray(numbers);
int count = 0;

for (int j = 0; j < numbers.Length; j++)
if(numbers[j] % 2 ==0)
count++;

Console.WriteLine($"Всего в Вашем массиве {numbers.Length} чисел, {count} из них чётные");

void FillArrayRandomThreeNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}