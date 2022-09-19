// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.


Console.WriteLine("Введите кол-во чисел: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] digits = new int[size];
CreateArray(digits);
Console.WriteLine("Созданный массив: ");
PrintArray(digits);

int summa = 0;
for(int n = 0; n < digits.Length; n++)
{
    if (n % 2 == 1)
    {
        summa += digits[n];
    }
}
Console.WriteLine($"Сумма элементов на нечетных позициях: {summa}");


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
        numbers[i] = new Random().Next(1, 10);
    }
}