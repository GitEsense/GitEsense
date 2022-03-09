double result = 0; //результат падает сюда
string[] act = { "+", "-", "/", "*" };
string value;
bool msgerror;
Console.WriteLine("Введите первое число : ");
msgerror = double.TryParse(Console.ReadLine(), out double a);
    while (!msgerror)
        {
          Console.WriteLine("Неверно введено первое число, повторите : ");
          msgerror = double.TryParse(Console.ReadLine(), out a);
        }
 Console.WriteLine("Введите второе число : ");
 msgerror = double.TryParse(Console.ReadLine(), out double b);
    while (!msgerror)
        {
          Console.WriteLine("Неверно введено второе число, повторите : ");
          msgerror = double.TryParse(Console.ReadLine(), out b);
        }
Console.WriteLine("Введите действие, где '*' - умножение, '/' - деление, '-' - вычитание, '+' - сложение :");
msgerror = act.Contains(value = Console.ReadLine());

switch (value) {
    case "*": result = a * b; break;
    case "/": if (b != 0)
        {
            result = a / b;
            break;
        }
        else
        { 
            while (b == 0)
            {
                Console.WriteLine("Вы пытаетесь поделить на ноль, введите другое число : ");
                msgerror = double.TryParse(Console.ReadLine(), out b);
                while (!msgerror)
                {
                    Console.WriteLine("Неверно введено второе число, повторите : ");
                    msgerror = double.TryParse(Console.ReadLine(), out b);
                }
            }
            result = a / b;
            break;
        }
    case "+": result = a + b; break;
    case "-": result = a - b; break;
}

Console.WriteLine("{0} {1} {2} = {3}", a, value, b, result);            