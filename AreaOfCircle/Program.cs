// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please enter a radius: ");
double radius = double.Parse(Console.ReadLine());
double pi = 3.14;
double area = pi * radius * radius;
Console.WriteLine("The area of the circle is " + area);
Console.WriteLine("The circumference of the circle is " + 2 * pi * radius);
Console.WriteLine("The diameter of the circle is " + 2 * radius);

Console.WriteLine("What is your MPG? ");
double mpg = double.Parse(Console.ReadLine());
double gallons = area / mpg;
Console.WriteLine("You will need " + gallons + " gallons of gas to travel around the circle");