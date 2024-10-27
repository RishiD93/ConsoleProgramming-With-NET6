// See https://aka.ms/new-console-template for more information



String firstName = "Rishi";
String lastName = "Dewangan";
DateTime date =DateTime.Now;

// Print to Screen
Console.WriteLine(firstName);
Console.WriteLine(lastName);    


// Concatenation
Console.WriteLine(firstName + " " + lastName);

// String Length

int length = firstName.Length;
Console.WriteLine(length);
Console.WriteLine($"Your name is {length} letters long.");


// Replacing string parts

String newNamw = firstName.Replace('T', 'K');
Console.WriteLine(newNamw);

// Append to other string variables

String fullName = firstName + lastName;
Console.WriteLine(fullName);
    
//Split String
String[] splitName =  fullName.Split('S');
for (int i = 0; i < splitName.Length; i++)
{ 
    Console.WriteLine(splitName[i]);

}
string nullString;
string emptyString = "";
string whiteSpaceString = " ";



// Compare Strings

if (string.IsNullOrEmpty(nullString))
{ 
     Console.WriteLine("Sring is null");   
}

if (firstName == lastName)
{ 
   Console.WriteLine("Names are equal");
}

if (firstName != lastName)
{
    Console.WriteLine("Names are not equal");
}

// Convert to Strings
string convertedString = string.Empty;
int number = 123456786776;

convertedString = number.ToString();
convertedString = 123456789.ToString();

fullName.ToUpper(); 
fullName.ToLower();
