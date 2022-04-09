/* Задача 1: Задайте значения M и N. Напишите программу, 
которая выведет все чётные натуральные числа в промежутке от M до N.*/
int Promt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}

void PrintEvenNumbers(int A, int B)
{
    if (A > B) return;
    if (A % 2 == 0) Console.Write(A+" ");
    PrintEvenNumbers(A + 1, B);
}

int A = Promt("Введите A => ");
int B = Promt("Введите B => ");
PrintEvenNumbers(A, B);
