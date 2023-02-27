string[] inputStrings = new string[0];

// запрашиваем у пользователя ввод строк
while (true)
{
    Console.Write("Введите строку (или нажмите Enter для завершения ввода): ");
    string input = Console.ReadLine();

    if (input == "")
    {
        break;
    }

    // добавляем новую строку в массив
    Array.Resize(ref inputStrings, inputStrings.Length + 1);
    inputStrings[inputStrings.Length - 1] = input;
}

// вызываем метод для фильтрации массива
string[] filteredStrings = FilterStrings(inputStrings);

// выводим отфильтрованный массив в консоль
Console.WriteLine("Отфильтрованные строки:");
foreach (string str in filteredStrings)
{
    Console.WriteLine(str);
}

static string[] FilterStrings(string[] strings)
{
    // создаем новый массив для отфильтрованных строк
    string[] filteredStrings = new string[0];

    // проходим по каждой строке в массиве
    foreach (string str in strings)
    {
        // проверяем длину строки
        if (str.Length <= 3 && str.Length > 0)
        {
            // добавляем отфильтрованную строку в массив
            Array.Resize(ref filteredStrings, filteredStrings.Length + 1);
            filteredStrings[filteredStrings.Length - 1] = str;
        }
    }

    return filteredStrings;
}
