/*Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/

int count = 0;
int count2 = 0;
string? str = string.Empty;
string[] arrayStr = new string[count];
string[] tempArrayStr;
string[] arrayStr3 = new string[count2];
string[] tempArrayStr3;
int m = 1;

do
{
    Console.WriteLine($"Введите {m} строку и нажмите один раз Enter или дважды для завершения ввода.");
    str = Console.ReadLine();
    m++;

    if (str != "")
    {
        count++;
        tempArrayStr = new string[count];

        for (int i = 0; i < tempArrayStr.Length - 1; i++)
            tempArrayStr[i] = arrayStr[i];
        tempArrayStr[count - 1] = str;
        arrayStr = tempArrayStr;
    }
    if (str != "" && str.Length <= 3)
    {
        count2++;
        tempArrayStr3 = new string[count2];

        for (int i = 0; i < tempArrayStr3.Length - 1; i++)
            tempArrayStr3[i] = arrayStr3[i];
        tempArrayStr3[count2 - 1] = str;
        arrayStr3 = tempArrayStr3;
    }

}
while
(str != "");

Console.WriteLine($"[{string.Join(", ", arrayStr)}] -> [{string.Join(", ", arrayStr3)}]");
Console.WriteLine("Нажмите любую клавишу для выхода из программы");
Console.ReadKey();
