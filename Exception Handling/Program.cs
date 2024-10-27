// See https://aka.ms/new-console-template for more information

/*
 * try - try block attemps an operation
 * catch - catch any fatel error or exception
 * Finally - whetere the try or the catch was succesful
 * throw - end program execution with the error
 */

Console.WriteLine("Enter first number :  ");
int num1 =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number : ");
int num2 =Convert.ToInt32(Console.ReadLine());
try
{
    int quotation = num1 / num2;

}
catch (DivideByZeroException ex)
{

    Console.WriteLine($"Illigal Operation :  {ex.Message}");
}
catch (Exception ex)
{
    throw ex;
}
finally
{
    Console.WriteLine("This is the finally block");
}