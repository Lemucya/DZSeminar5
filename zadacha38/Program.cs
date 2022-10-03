/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.*/
Console.WriteLine("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[arraySize];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Ваш массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int j = 0; j < numbers.Length; j++)
{
    if(numbers[j] > max)
    {
       max = numbers[j]; 
    }
    if(numbers[j] < min)
    {
       min = numbers[j]; 
    }
}
Console.WriteLine($"Всего в Вашем массиве {numbers.Length} чисел. Максимальное число = {max}, минимальное число = {min}");
Console.WriteLine($"Разница между максимальным и минимальным числом = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(1, 100));
    }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
