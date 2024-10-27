// See https://aka.ms/new-console-template for more information


// declare Fixed Size Array
int[] grades = new int[5];


// Add values in Fixed Size Array
//grades[0] = 45;
//grades[1] = 65;
//grades[2] = 76;
//grades[3] = 89;
//grades[4] = 98;

//int[] newgrades = new int[] { 23, 45, 65, 65, 34 };
Console.WriteLine("Enter All grades: ");
for (int i = 0; i < grades.Length; i++)
{ 
    Console.WriteLine("Enter grades :");
    grades[i] = Convert.ToInt32(Console.ReadLine());

}



//Print values in Fixed size array
Console.WriteLine("Grades you have entered are ");
for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine(grades[i]);
}




//Declare Variable sized Array
String[] Studentnames = new String[] { "Test","Student1","student2"};


//Add values to Variable sized Array
for (int i = 0; i < Studentnames.Length; i++)
{
    Console.WriteLine("Enter names : ");
    Studentnames[i] = Console.ReadLine();
}

// Print values in Variable sized Array
Console.WriteLine("The names which you have entered are : ");
for (int i = 0; i < Studentnames.Length; i++)
{
    Console.WriteLine(Studentnames[i]);
}
