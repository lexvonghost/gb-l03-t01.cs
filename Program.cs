Console.WriteLine("Введите пятизначное число");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 9999 && n <= 99999)
{
    string s = n.ToString();
    char d1 = s[0];
    char d2 = s[1];
    char d3 = s[2];
    char d4 = s[3];
    char d5 = s[4];
    if(d1 == d5 && d2 == d4)
    {
        Console.WriteLine("Число является полиндромом");
    }
    else
    {
        Console.WriteLine("Число не является полиндромом");
    }

}
else
{
    Console.WriteLine("Неправильный ввод");
}
