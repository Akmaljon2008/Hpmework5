var st1 = new Student();
Console.WriteLine("Введите имя студента:");
st1.Name = Console.ReadLine();
Console.WriteLine("Введите уровень класса студента:");
st1.GradeLevel = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите оценки студента через запятую:");
st1.Scores = Console.ReadLine().Split(',').Select(int.Parse).ToList();

double average = st1.GetAverage();
if (average > 85)
{
    Console.WriteLine($"Congratulations{st1.Name} on achieving above average scores{average}. Keep up the good work.");
}
else if (average < 70)
{
    Console.WriteLine($"{st1.Name}, your avarage {average} no high.If you're having difficulties with your studies, don't hesitate to seek help");
}
else
{
    Console.WriteLine($"{st1.Name}, your avarage {average} good, but you can better.");
}
class Student{
    public string Name;
    public int GradeLevel;
    public List<int> Scores;

    public double GetAverage(){
        int avarage = 0;
        foreach (var score in Scores)
        {
            avarage += score;
        }
        return (double)avarage / Scores.Count;
    }
}