class Employee
{
    public string LastName { get; set; }
    public double Salary { get; set; }
    public int StartYear { get; set; }

    public Employee(string lastName, double salary, int startYear)
    {
        LastName = lastName;
        Salary = salary;
        StartYear = startYear;
    }

    public int YearsUntil60()
    {
        int currentYear = DateTime.Now.Year;
        int ageAt60 = 60 - (currentYear - StartYear);
        return ageAt60 > 0 ? ageAt60 : 0;
    }

    public int YearsAfter60()
    {
        int currentYear = DateTime.Now.Year;
        int age = currentYear - StartYear;
        return age > 60 ? age - 60 : 0;
    }
}

class CompanyEmployee : Employee
{
    public int BirthYear { get; set; }

    public CompanyEmployee(string lastName, double salary, int startYear, int birthYear)
        : base(lastName, salary, startYear)
    {
        BirthYear = birthYear;
    }
}

class Program
{
    static void Main()
    {
        CompanyEmployee companyEmployee = new CompanyEmployee("Иванов", 50000, 2015, 1980);

        int yearsUntil60 = companyEmployee.YearsUntil60();
        Console.WriteLine("Лет до 60 лет: " + yearsUntil60 + " лет");

        int yearsAfter60 = companyEmployee.YearsAfter60();
        Console.WriteLine("Лет после 60 лет: " + yearsAfter60 + " лет");
    }
}
