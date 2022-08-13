Console.WriteLine("Введите число: ");
int myNum = Convert.ToInt32(Console.ReadLine());
 void numDefiniter(int num)
{
    bool simple = true;
    if (num < 0)
    {
        Console.WriteLine("Число отрицательное");
    }
    else
    {
        Console.WriteLine("Число положительное");
    }
    int[] myArr = new int[5] { 2, 3, 5, 6, 9 };
    for (int i = 0; i < 5; i++)
    {
        if (num % myArr[i] == 0)
        {
            simple = false;
            Console.WriteLine("число делится на:" + myArr[i]);
        }
    }
    if (simple)
    {
        Console.WriteLine("Число простое");

    }
    else
    {
        Console.WriteLine("Число не простое");
    }
}
numDefiniter(myNum);
Console.ReadKey();
