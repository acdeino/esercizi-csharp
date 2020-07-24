int a = 18;
int b = 6;
int c = a + b;
Console.WriteLine(c);

int d = a - b;
Console.WriteLine(d);

int e = a * b;
Console.WriteLine(e);

int f = a / b;
Console.Write(f);

// Order of operations

int a = 5;
int b = 4; 
int c = 2;
int d = a + b * c;
int e = (a + b) * c;

Console.WriteLine(d);
Console.WriteLine(e);

int f = (a + b) - 6 * c + (12 * 4) / 3 + 12;
Console.WriteLine(f);

int g = 7;
int h = 4;
int i = 3;
int j = (g + h) / i;
Console.WriteLine(j);

// Integer precision and limits

int k = (g + h) % i;
Console.WriteLine($"quotient: {j}");
Console.WriteLine($"remainder: {k}");

int k = (g + h) % i;
Console.WriteLine($"quotient: {j}");
Console.WriteLine($"remainder: {k}");


int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

int what = max + 3;
Console.WriteLine($"An example of overflow: {what}");


//   with doubles
double a = 5;
double b = 4;
double c = 2;
double d = (a + b) / c;
Console.WriteLine(d);

double a = 19;
double b = 23;
double c = 8;
double d = (a + b) / c;
Console.WriteLine(d);

double max = double.MaxValue;
double min = double.MinValue;
Console.WriteLine($"The range of double is {min} to {max}");

double third = 1.0 / 3.0;
Console.WriteLine(third);


decimal min = decimal.MinValue;
decimal max = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {min} to {max}");

double a = 1.0;
double b = 3.0;
Console.WriteLine(a / b);

decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c / d);

double radius = 2.50;
double area = Math.PI * radius * radius;
Console.WriteLine(area);