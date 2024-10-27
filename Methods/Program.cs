// See https://aka.ms/new-console-template for more information

//prototype - Defines the function(type, name and parameters

// Defination - has the code. It contains the code block


//Function call - Makes the function
// DRY - Don't Repeat yourself
//YAGNI - You aren't going to Need it



// void function - complete a task and move along

void PrintName()
{
    Console.WriteLine("Rishi Dewangan");
}
void Addition(int num1, int num2)
{   
    Console.WriteLine($"The sum of {num1} and {num2} is {num1 + num2}");
}




// value returning functions - complete a task, return a result


int LargestNumber(int num1, int num2, int num3)
{
    int Largest = num1;
    if (Largest < num2)
    { 
        Largest = num2;
    }
    if (Largest < num3)
    {
        Largest = num3;
    }
    return Largest;
}
PrintName();

Console.WriteLine("End of void function");
Console.WriteLine("Enter number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int Result = LargestNumber(number1, number2, number3);
Console.WriteLine($"The Largest number is: {Result}" );
//Console.WriteLine($"The largest number is : {LargestNumber(number1, number2, number3)}");




//Addition(number1, number2);



