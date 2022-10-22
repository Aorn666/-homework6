//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите кол-во чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = 0;
int a = 0;
for (int i = 0; i < m; i++)
{
    Console.Write("Введите число: ");
    n = Convert.ToInt32(Console.ReadLine());
     if (n>0)
     {
        a++;
     }
}
Console.WriteLine(a);