//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите кол-во трехзначных чисел: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] digits = new int[size];
CreateArray(digits);
Console.WriteLine("Созданный массив: ");
PrintArray(digits);

int evenNum = 0;
for (int i = 0; i < digits.Length; i++)
{
    if (digits[i] % 2 == 0)
    {
        evenNum++;
    }
}

Console.WriteLine($"Количество четных чисел: {evenNum}");


void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}

void CreateArray (int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }
}