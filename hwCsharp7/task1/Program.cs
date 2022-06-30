// Задача 1: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Enter your number, please: ");

int[] array = InitArray();
int count = CountPositiveNumbers();
Console.WriteLine($"Number of numbers greater then zero is {count}");

int[] InitArray()
{
    char[] delimiterChars = { ' ', ',', ':', '\t'};
    string[] stringArray = Console.ReadLine().Split(delimiterChars);
    return Array.ConvertAll(stringArray, int.Parse);
}

int CountPositiveNumbers()
{
    int count = 0;
    foreach (int element in array)
    {
        if (element > 0) count++;
    }

    return count;
}