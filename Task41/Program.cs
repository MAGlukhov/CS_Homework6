// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.WriteLine("Введите число");
string number = Console.ReadLine();

int ZerosCounter(string word)
{
    int result = 0;
    for(int i = 0; i < word.Length; i++)
    {
        if(word[i] == '0')
        {
            result++;
        }
    }
    return result;
}

Console.WriteLine(ZerosCounter(number));