//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите кол-во чисел: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] digits = new double[size];
CreateArray(digits);
Console.WriteLine("Созданный массив: ");
PrintArray(digits);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for(int n = 0; n < digits.Length; n++)
{
    if (digits[n] > max)
    {
        max = digits[n];
    }
    if (digits[n] < min)
    {
        min = digits[n];
    }
}
Console.WriteLine($"Минимальный элемент: {min}. Максимальный элемент: {max}");
Console.WriteLine($"Разность элементов = {max - min}");


void PrintArray(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}

void CreateArray (double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(100, 1000))/100;
    }
}