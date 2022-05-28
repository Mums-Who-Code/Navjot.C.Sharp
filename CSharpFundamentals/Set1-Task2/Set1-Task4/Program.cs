int a = 20;
int b = 10;
int c;
c = a + b;
Console.WriteLine("\n\t variable a value before  increament  : " +a);
Console.WriteLine("\t variable b value before decsrement  : " + a);
Console.WriteLine("sum of a and b is =   " + c);

a = ++a;
b = --b;
c = a - b;
Console.WriteLine("\n\t variable a value after first increment = "+a);
Console.WriteLine("\t variable b value after first decrement = "+b);   
Console.WriteLine("subtract of a and b is = " + c);

a = ++a;
b= --b;
c = a * b;
Console.WriteLine("\n\t variable a value after second increment = "+ a);
Console.WriteLine("\t variable b value after second decrement = " + b);
Console.WriteLine("Multiplation of a and b is = " + c);

a = ++a;
b = --b;
c = a / b;
Console.WriteLine("\n\t variable a value after third increment = " + a);
Console.WriteLine("\t variable b value after third decrement = " + b);
Console.WriteLine("Division of a and b is = " + c);
