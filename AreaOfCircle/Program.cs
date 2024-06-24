// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please enter a radius: ");
double radius = double.Parse(Console.ReadLine());
double area = Math.PI * radius * radius;
Console.WriteLine("The area of the circle is " + area);
Console.WriteLine("The circumference of the circle is " + 2 * Math.PI * radius);
Console.WriteLine("The diameter of the circle is " + 2 * radius);
