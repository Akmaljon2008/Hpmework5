



int year = 2023;
var p1 = new Person();
p1.FirstName = Console.ReadLine();
p1.LastName = Console.ReadLine();
p1.Age = Convert.ToInt32(Console.ReadLine());



System.Console.WriteLine($"My name is {p1.GetFullInfo()}");
System.Console.WriteLine($"My birth year is {p1.GetBirthYear(year)}");

class Person{
    public string FirstName;
    public string LastName;
    public int Age;

    public string GetFullInfo(){
        return $"{FirstName} {LastName}";
    }
    public int GetBirthYear(int Year){
       return Year - Age;
    }
}