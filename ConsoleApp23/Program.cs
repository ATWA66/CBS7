static int ADD( int num1,  int num2) 
{
    int res = num1 + num2;
    return res;
}

static int Sub(int num1,  int num2) 
{
    int res = num1 - num2;
    return res;
}
static int Mul( int num1,  int num2) 
{
    int res = num1 * num2;
    return res;
}
static double Div( int num1,  int num2) 
{
    double res = (double)num1 / (double)num2;
    return res;
}

Console.WriteLine("Введите первый операнд");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второй операнд");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите знак арифметической операции");
string sign = Console.ReadLine();
switch (sign)
{
    case "+":
{
    Console.WriteLine(ADD( num1, num2));
            break;
}
    case "-":
        {
    Console.WriteLine(Sub( num1, num2));
            break;
}
    case "*":
        {
    Console.WriteLine(Mul(num1, num2));
            break;
}
    case "/":
        {
    if (num2 == 0)
    {
        Console.WriteLine("ошибка");
    }
    else
        Console.WriteLine(Div( num1,  num2));
            break;
}
    default:
        {
            Console.WriteLine("ошибка");
            break;
        }

}