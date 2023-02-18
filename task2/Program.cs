// y = k1 * x + b1, y = k2 * x + b2
// k1*x+b1=k2*x+b2 
// k1*x-k2x=b2-b1
// x(k1-k2)= b2-b1
// x=(b2-b1)/(k1-k2)

int IputNum(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(System.Console.ReadLine());
}

double b1 = IputNum("Введите значение b1: ");
double k1 = IputNum("Введите число k1: ");
double b2 = IputNum("Введите значение b2: ");
double k2 = IputNum("Введите число k2: ");

double x = (b2 - b1) / (k1 - k2);
double y = k2 * x + b2;

if (k1 == k2 && b1 == b2)
{
    System.Console.WriteLine($"Прямые совпадают");
}
else if (k1 == k2 && b1 != b2)
{
    System.Console.WriteLine($"Прямые параллельны");
}
else
{
    System.Console.WriteLine($"Прямые пересекутся в точке с координатами x > {x} y > {y}");
}





