// See https://aka.ms/new-console-template for more information




for loop(Counter Controlled)
for (int i = 0; i < 10; i++) {
  Console.WriteLine("I am in the for loop");
}

Console.WriteLine();
Console.WriteLine("For loop is finished");

 while loop(Condition controlled loop)
int n = 0;
while (n < 5)
{
    Console.WriteLine("Input a  number");
    n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"You enterd : {n} ");
}
Console.WriteLine();
Console.WriteLine("While loop finished");



 Do.... while loop  
int n = 0;
do {
    Console.WriteLine("Input a  number");
    n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"You enterd : {n} ");

} while (n < 5);

//for each 
foreach (var item in collection)
{

}

