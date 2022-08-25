// Напишите программу, которая на вход принимает
// одно число (N),а на выходе показывает все целые
// числа в промежутке от -N до N.

// 4 → "-4,-3,-2,-1,0,1,2,3,4"

// 2 → "-2,-1,0,1,2"

//Console.WriteLine("Input number");
//int number1 = int.Parse(Console.ReadLine());
//int i=0;
//int y = 2*(number1);

//Console.WriteLine("Ответ:");
//while (i<=y)
//{

//Console.WriteLine(-number1);
    //i++;
    //number1--;
//}

Console.WriteLine("Input number");
string NumberStr;
NumberStr = Console.ReadLine();
int n = int.Parse(NumberStr);
int a = n*(-1);
while (a<=n)
{
    Console.WriteLine (a);
    a = a + 1;
}