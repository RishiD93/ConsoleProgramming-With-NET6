// See https://aka.ms/new-console-template for more information


Console.WriteLine("Enter the number of apples  : ");
int numofApples = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of oranges number : ");
int numoforanges = Convert.ToInt32(Console.ReadLine());
//if statments

if (numofApples > numoforanges)
{
    Console.WriteLine("You have more apples");
}
else if (numofApples < numoforanges)
{
    Console.WriteLine("You have more oranges");
}
else if (numofApples == numoforanges)
{

    Console.WriteLine("Apples and oranges numbers  are equal");
}
else {
    Console.WriteLine("No direct action");
}



Console.WriteLine("Enter final grade : ");
int grade =Convert.ToInt32(Console.ReadLine());
//switch statment
switch (grade) { 
    case int n when n<=59:
        Console.WriteLine("You failed");
        break;
    case int n when n> 60 && n<=100:
        Console.WriteLine("You passed");
        break;
    default:
        Console.WriteLine("Invalid grade");
        break;


}


//Ternary Operator
var message = numofApples > numoforanges ? "you have more apples " : "ypu have more oranges";
Console.WriteLine(message);

