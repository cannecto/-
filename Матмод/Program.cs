using System.Threading.Tasks.Dataflow;
double a, b, xn, E=1,m,i=0;
Console.Write("Введите первый корень a: ");
a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите первый корень b: ");
b = Convert.ToDouble(Console.ReadLine());
xn = a;

m = Math.Abs(3 * Math.Sin(xn) + (2 / Math.Sqrt((4 * xn) + 7)));
m = Math.Round(m,1);

void Schet(double _xn)
{
    xn = _xn - (Math.Sqrt((4 * _xn) + 7) - (3 * Math.Cos(_xn))) / ((3 * Math.Sin(_xn)) + (2 / Math.Sqrt((4 * _xn) + 7)));

    E = Math.Abs(Math.Sqrt((4 * xn) + 7) - (3 * Math.Cos(xn))) / m;

    xn = Math.Round(xn,4);
    E= Math.Round(E,5);
    i++;
}

while (E>0.001)
{
    Schet(xn);
    Console.WriteLine($"Корень x{i} найден: {xn} с точностью {(decimal)E}");
}