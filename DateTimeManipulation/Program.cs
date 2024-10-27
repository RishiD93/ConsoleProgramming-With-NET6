// See https://aka.ms/new-console-template for more information

//Empty DateTime
using System.Globalization;

DateTime date = new DateTime();



// Create a DateTime from date and time

DateTime dateofBirth = new DateTime(1993,06,29);
Console.WriteLine("Date of birth is "+ dateofBirth);



// Create a DateTime from current timestamp
DateTime now = DateTime.Now;
Console.WriteLine("The time now is : " + now);

//Create a DateTime from a String
DateTime datefromString = DateTime.Parse("1993/06/29", CultureInfo.InvariantCulture);
Console.WriteLine("String to date is " + datefromString);

//Add additional time
now.AddHours(1);
Console.WriteLine("One hour From now is " + now.AddHours(1));
Console.WriteLine("One Day From now is " + now.AddDays(1));


//DateTime from Ticks
Console.WriteLine("Time as numeral : " + now.Ticks);


// Date only
DateOnly dateOnlyofBirth = DateOnly.FromDateTime(dateofBirth.Date);

//Time only
TimeOnly timeOnly = TimeOnly.FromDateTime(date);

