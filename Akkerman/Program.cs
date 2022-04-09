/* Задача 3: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n. */
int Promt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}

int Akkerman(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return Akkerman(n - 1, 1);
    return Akkerman(n - 1, Akkerman(n, m - 1));
}

int N = Promt("Введите n => ");
int M = Promt("Введите m => ");
Console.Write(Akkerman(N,M));
