using static System.Console;
Clear();

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

WriteLine("Введите числовые элементы массива через пробел: ");
string[] parameters = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] array = ParseArrayToInt(parameters);
WriteLine($"Количество положительных элементов массива равно: {QuantityOfPositiveNumbersInArray(array)}");
//Array.ForEach(array, el=> Write(" "+el));



int QuantityOfPositiveNumbersInArray(int[] userArray)
{
    int positive = 0;
    foreach (int item in userArray)
    {
        if(item>0)
        positive+=1;
    }
    return positive;
}

int[] ParseArrayToInt(string[] arrayFromUser)
{
    int[] newarray = new int[arrayFromUser.Length];
    for (int i = 0; i < arrayFromUser.Length; i++)
    {
        newarray[i] = int.Parse(arrayFromUser[i]);
    }
    return newarray;
}

