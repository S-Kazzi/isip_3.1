// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
double a = Convert.ToDouble(Console.ReadLine());
char b = Convert.ToChar(Console.ReadLine());
double c = Convert.ToDouble(Console.ReadLine());
switch (b)
{
    case '+':
        Console.WriteLine(a + c);
        break;
    case '-':
        Console.WriteLine(a - c);
        break;
    case '*':
        Console.WriteLine(a * c);
        break;
    case '/':
        Console.WriteLine(a / c);
        break;
    default:
        Console.WriteLine("Ошибка!");
        break;
}
  
