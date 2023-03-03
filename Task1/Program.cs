// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int InputInt32(string message)
{
    System.Console.Write(($"{message} "));
    int value;
    bool isCorrectInt32 = int.TryParse(Console.ReadLine(), out value);
    if (isCorrectInt32)
    {
        return value;
    }
    System.Console.WriteLine("You entered not a number");
    Environment.Exit(-1);
    return 0;
}



int[] UserInputArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = InputInt32("Enter you number");
    }
    return array;
}

int PositiveElementCounter(int[] array)
{
    int Count=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) Count++;
    }
    if (Count!=0)
    {
        return Count;
    }
    System.Console.WriteLine("You entered no one positive number");
    Environment.Exit(-1);
    return -1;
}

int  UserArraySize = InputInt32("Enter the amount of your numbers");
int[] UserArrayNumbers = UserInputArray(UserArraySize);
if (PositiveElementCounter(UserArrayNumbers)!=0) System.Console.WriteLine($"You entered {PositiveElementCounter(UserArrayNumbers)} positive number(s)");
