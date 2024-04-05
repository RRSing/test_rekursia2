// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

int A(int m, int n)
{
    if (m == 0) {return n + 1;}
    if (m > 0 && n == 0) {return A(m - 1, 1);}
    else {return A(m - 1, A(m, n - 1));}
}

Console.WriteLine("В задании ошибка нужно поменять аргументы местами 2 и 3 иначе получится 9");
Console.WriteLine(A(2,3));
Console.WriteLine(A(3,2));