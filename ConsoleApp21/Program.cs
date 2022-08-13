Console.WriteLine("Вас приветсвует UAH - USD конвертор");
double deposite;
byte type;
Console.WriteLine("выберите валюту ввода:\n1- USD\n2-UAH");
type = Convert.ToByte(Console.ReadLine());
Console.WriteLine("введите суму:");
deposite = Convert.ToDouble(Console.ReadLine());
static void Conv(byte type, double deposite)
{
    if (type == 1)
    {
        deposite *= 36.92;
    }
    else if (type == 2)
    {
        deposite /= 36.92;
    }
    else
    {
        Console.WriteLine("ошибка");
    }
    Console.WriteLine("после конвертирования = " + deposite);
}
Conv(type, deposite);