
void WorkWithIntegers()
{
int a = 18;
int b = 6;
int c = a + b;
Console.WriteLine(c);
// subtraction
c = a - b;
Console.WriteLine(c);

// multiplication
c = a * b;
Console.WriteLine(c);

// division
c = a / b;
Console.WriteLine(c);

c = a + b - 12 * 17;
Console.WriteLine(c);
}
WorkWithIntegers();
OrderPrecedence();
void OrderPrecedence()
{
 int a = 7;
int b = 4;
int c = 3;
int d = (a + b) / c;
int e = (a + b) % c;
Console.WriteLine($"quotient: {d}");
Console.WriteLine($"remainder: {e}");
}
 testlimits();
void testlimits()
{
int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

int what = max + 3;
Console.WriteLine($"An example of overflow: {what}");
}
Testdouble();
void Testdouble()
{
double a = 5;
double b = 4;
double c = 2;
double d = (a + b) / c;
Console.WriteLine(d);

double e = 19;
double f = 23;
double g = 8;
double h = (e + f) / g;
Console.WriteLine(h);

double max = double.MaxValue;
double min = double.MinValue;
Console.WriteLine($"The range of double is {min} to {max}");

double third = 1.0 / 3.0;
Console.WriteLine(third);
}
Testdecimal();
void Testdecimal()
{
decimal min = decimal.MinValue;
decimal max = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {min} to {max}");

double a = 1.0;
double b = 3.0;
Console.WriteLine(a / b);

decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c / d);
}

void raiocirculo()
{
double r = 2.5;
double Areadocirculo = (r*r)*Math.PI;
Console.WriteLine(Areadocirculo);
}

raiocirculo();



