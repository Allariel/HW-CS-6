// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// k1*x+b1=k2*x+b2
// k1*x-k2*x = b2-b1
// x = b2-b1/k1-k2 
void XY(double [] k, double [] b)
{
    if(k[0]==k[1])
    {
        Console.WriteLine("Прямые параллельны");
        if(b[0]==b[1])
        {
             Console.WriteLine("и совпадают");
        }
        return;
    }
    double x = (b[1] - b[0]) / (k[0] - k[1]);
    double y = k[0] * x + b[0];
    Console.WriteLine("("+ x + ";" + y + ")" );
}

Console.WriteLine("Привет, напиши k1 b1 k2 b2!");
double[] k = new double[2];
double[] b = new double[2];

for (int i = 0; i < 2; i++)
{
    k[i]= Convert.ToDouble(Console.ReadLine());
    b[i]= Convert.ToDouble(Console.ReadLine());
}
XY(k,b);



