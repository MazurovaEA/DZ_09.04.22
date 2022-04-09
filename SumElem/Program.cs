/* Задача 2: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N.*/
int Promt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}

int PrintN(int A, int B)
{
    if (A == B) return A;
    return A + PrintN(A + 1, B);
}

int N = Promt("Введите N => ");
int M = Promt("Введите M => ");
Console.WriteLine($"Сумма чисел от {N} до {M} равна {PrintN(N, M)}");
