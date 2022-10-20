//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

(int, string)Count_Positive_Num(int sum, string check)
{
    try
    {
        int number = Convert.ToInt32(check);
        if (number>0)
        {
            sum++;
        }
    }
    catch (FormatException)
    {
      check = "M";
    }
    return (sum,check);
}

int sum = 0;
string check = "O";
Console.WriteLine("Пиши числа или М чтобы остановить");
while (check != "M")
{
    check = Console.ReadLine();
   (sum,check)=Count_Positive_Num(sum,check);
}
Console.WriteLine("Чисел >0: " + sum + "\n");