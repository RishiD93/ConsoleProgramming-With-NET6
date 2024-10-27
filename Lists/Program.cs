// See https://aka.ms/new-console-template for more information
//Declare
List<string> names = new List<string>();
string name = string.Empty;

// add values to list
Console.WriteLine("Enter names");
while (!name.Equals("-1"))
{
    Console.WriteLine(" Enter names");
    name = Console.ReadLine();
    names.Add(name);
    if (!string.IsNullOrEmpty(name) && !name.Equals("-1"))
        {
        Console.Write($"{name} was added suucesfully");
        names.Add(name);
    }

}

// print vlue in list
for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine("Printing names via for loop");
    Console.WriteLine(names[i]);
}

Console.WriteLine("Printing names via foreach loop");
foreach (string item in names)
{
    Console.WriteLine(item);

}

