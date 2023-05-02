using StaticExtensiontask.Models;
using StaticExtensiontask.Utilies;


#region Task1

Student stu1 = new();
Student stu2 = new();
Student stu3 = new();
Student stu4 = new();


Console.WriteLine(stu1.Id);
Console.WriteLine(stu2.Id);
Console.WriteLine(stu3.Id);
Console.WriteLine(stu4.Id);

#endregion



#region Task2

string str = "Salam Laman. Laman necesen Laman?";

Console.WriteLine(str.MatchCount("Laman")); 

#endregion
