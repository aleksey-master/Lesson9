/*Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке
от M до N с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8 -> 30
*/

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string ReadValue = Console.ReadLine();
    int result = int.Parse(ReadValue);
    return result;
}

void PrintSum(int M, int N, int sum)
{
    sum = sum + N;

    if (N <= M)
    {
        Console.Write($"Сумма элементов= {sum} ");
        return;
    }
    PrintSum(M, N - 1, sum);
}

int M = Prompt("Введите M -> ");
int N = Prompt("Введите N -> ");

int sum = M;
sum = 0;
if (M > N)
{
    M = N;
    N = sum;
}
PrintSum(M, N, sum);
