double GetValue(string text)
{
    Console.Write(text + ": ");
    double value = Convert.ToDouble(Console.ReadLine());
    return value;
}

void Print(double ax, double ay, double bx, double by, double result)
{
    // |A(1, 2), B(4, 5)| = 6
    string output = "|A(" + ax + ", " + ay + "); B(" + bx + ", " + by + ")| = " + 
                      Math.Round(result, 2);
    //result;

    Console.WriteLine(output);
}

double GetDistance(double ax, double ay, double bx, double by)
{
    double x = (ax - bx) * (ax - bx);
    double y = Math.Pow(ay - by, 2);
    double result = Math.Sqrt(y + x);
    return result; 
}

//System.Console.WriteLine(GetDistance(0, 0, 0, 10));
//System.Console.WriteLine(GetDistance(0, 0, 10, 0));
//System.Console.WriteLine(GetDistance(0, 0, 1, 1));

//Print (1, 2, 4, 5, 6);

double ax = GetValue(" ax ");
double ay = GetValue(" ay ");
double bx = GetValue(" bx ");
double by = GetValue(" by ");

double dis = GetDistance(ax, ay, bx, by);
Print(ax, ay, bx, by, dis);
    

