// See https://aka.ms/new-console-template for more information


using ClassAndObjects;

Person person = new ();
string middleName = string.Empty;
Console.WriteLine("Enter First name : ");
person.FirstName = Console.ReadLine();

Console.WriteLine("Enter Last name");
person.LastName = Console.ReadLine();

Console.WriteLine("Enter your age : ");
person.Age = Convert.ToInt32(Console.ReadLine());
int salary = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter middle name : ");
middleName = Console.ReadLine();
if (string.IsNullOrEmpty(middleName))
{
    Console.WriteLine("Full name is : " + person.getFullName());
}
else
{
    Console.WriteLine("Full name is : " + person.getFullName(middleName));
}
Console.WriteLine("Enter your salery");    
person.setSalary(salary);


Console.WriteLine("First name is : " + person.FirstName);
Console.WriteLine("Last name is : "+ person.LastName);
Console.WriteLine("Age is : "+ person.Age);
Console.WriteLine("Salarey is : " +person.getSalary());

