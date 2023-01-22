// На входе цифра дня недели, на выходе - явл-ся ли этот день выходным

int InputInt(string message)
{
    System.Console.Write(message + " > ");
    string? inputValue = System.Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

bool ValidateNWeek(int Numb)
{
    if (Numb > 0 && Numb < 8)
    {
        return true;
    }
    System.Console.WriteLine($"Ошибка! Число {Numb} не соответствует дню недели, введите число повторно ");
    return false;
}

string[] dayweeks = new string [7];
int Numb = InputInt("Введите число, обозначающее день недели");
if (ValidateNWeek(Numb))
{
    if (Numb > 5)
    {
        System.Console.WriteLine($"Ура, выходной!");
    }
    else 
    {
        System.Console.WriteLine($"Будний день");
    }
}
