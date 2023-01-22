// на входе трехзначное число, на выходе - вторая цифра

int InputInt (string message)
{
    Console.Write (message + ">");
    string? inputValue = Console.ReadLine ();
    int result = Convert.ToInt32 (inputValue);
    return result;
}

bool ValidateN3 (int Numb)
{
    if (Numb > 99 && Numb < 1000)
    {
        return true;
    }
    Console.WriteLine ("Число не трехзначное");
    return false;
}

int Numb = InputInt ("Введите трехзначное число");
if (ValidateN3 (Numb))
{
    int result = Numb / 10 % 10;
    Console.WriteLine ($"Вторая цифра {Numb} = {result}");
}