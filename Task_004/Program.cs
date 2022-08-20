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