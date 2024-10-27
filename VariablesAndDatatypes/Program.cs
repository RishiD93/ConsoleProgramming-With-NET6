// See https://aka.ms/new-console-template for more information
string fullName = string.Empty;
int age = 1;
double Salery = 0.0;
char gender = char.MinValue;
bool working = false;
Console.Write("Please enter your name");
fullName = Console.ReadLine();

Console.Write("Please enter your age");
age =  Convert.ToInt32 (Console.ReadLine());

Console.Write("Please enter your Salery");
Salery = Convert.ToDouble(Console.ReadLine());


Console.Write("Please enter your Gender(M of F :");
gender = Convert.ToChar(Console.ReadLine());


Console.Write("Are you working (true or false");
working = Convert.ToBoolean(Console.ReadLine());


Console.WriteLine("Your name is " + fullName);
Console.WriteLine("Your age is " + age);
Console.WriteLine($"Your Salery is :{Salery}");
Console.WriteLine($"Your Gender is :{gender}");
Console.WriteLine($"Are you Working ? :{working}");











