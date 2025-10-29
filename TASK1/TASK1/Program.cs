// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter 3 number :");
int student1 = Convert.ToInt32(Console.ReadLine());
int student2 = Convert.ToInt32(Console.ReadLine());
int student3 = Convert.ToInt32(Console.ReadLine());

double average = (student1 + student2 + student3) / 3;
Console.WriteLine($"Average score :{average}");