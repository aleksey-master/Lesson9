/*Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в
промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"
*/
int Prompt(string message)
{
    System.Console.WriteLine(message);
    string ReadValue = Console.ReadLine();
    int result = int.Parse(ReadValue);
    return result;
}

void PrintNumber(int M, int N)
{
    if (M == N)
    {
        return;
    }

    if (N % 2 == 0)
    {
        PrintNumber(M, N - 2);
        Console.Write(N + " ");
    }
    if (N % 2 != 0)
    {
        N = N - 1;
        PrintNumber(M, N - 2);
        Console.Write(N + " ");
    }
}

int M = Prompt("Введите M -> ");
int N = Prompt("Введите N -> ");

if (M % 2 == 0)
{
    Console.Write(M + " ");
    PrintNumber(M, N);
}
if (M % 2 != 0)
{
    Console.Write(M + 1 + " ");
    PrintNumber(M + 1, N);
}
