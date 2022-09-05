/*Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа
m и n.
m = 3, n = 2 -> A(m,n) = 29
*/

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string ReadValue = Console.ReadLine();
    int result = int.Parse(ReadValue);
    return result;
}

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}

int m = Prompt("Введите m -> ");
int n = Prompt("Введите n -> ");
int functionAkkerman = Akkerman(m, n);

Console.Write($"Функция Аккермана A({m},{n}) = {functionAkkerman} ");
