//Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да

Console.WriteLine("Введите 5-ти значное число");
string num = Console.ReadLine();
int control = 0;
for (int i = 0; i < num.Length / 2; i++)
{
    if ((num.Substring(i, 1)) != (num.Substring(num.Length - 1 - i, 1)))
    {
        Console.WriteLine(" Число не палиндром");
        break;
    }
    else
        control = 1;

}
if (control == 1) Console.WriteLine(" Число является палиндромом");