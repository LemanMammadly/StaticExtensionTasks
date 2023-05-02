namespace StaticExtensiontask.Models;

public class Student
{
	public int Id { get; }
	public string Name { get; set; }
	public string Surname { get; set; }
	public static int Count { get; set; }

	public Student()
	{
		Count++;
		Id = Count;
	}
}

