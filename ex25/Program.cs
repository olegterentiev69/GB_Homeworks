int Prompt(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}
int Power(int powerBase, int exponent)
{
    int power = 1;
    for (int = 0; i < exponent; i++)
    {
        power *= powerBase;
    }
    return power;
}
bool ValidateExponent(int exponent)
{
    if (exponent < 0)
    {
        System.Console.Writeline("Показатель не должен быть меньше нуля");
        return false;
    }
    return true;
}
int powerBase = Prompt("Введите основание: ");
int exponent = Prompt(" Введите показатель степени: ");
if (ValidateExponent(exponent))
{
    System.Console.Writeline($"Число(powerbase) в степени(exponent) равно {Power(powerBase, exponent)}");
}