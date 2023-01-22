// Вывод третьей цифры заданного числа, если такая существует


int InputInt (string message)
{
    Console.Write (message + ">");
    string? inputValue = Console.ReadLine ();
    int result = Convert.ToInt32 (inputValue);
    return result;
}

bool ValidateN3 (int Numb)
{
    if (Numb > 99)
    {
        return true;
    }
    Console.WriteLine ("Нет 3 цифры в числе");
    return false;
}

int Numb = InputInt("Введите число > 99 ");
if (ValidateN3(Numb))
{
    while (Numb > 999)
    {
        Numb = Numb / 10;
    }
    int result = Numb % 10;
    System.Console.WriteLine($"Третья цифра числа {Numb} = {result}");
}