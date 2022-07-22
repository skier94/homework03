// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите целое число");
int num = int.Parse(Console.ReadLine());
int Result(int iLocal)
{
    return iLocal * iLocal * iLocal;
}
for (int i = 1; i <= num; i++)
{
    Console.WriteLine(Result(i));
}