
using ChallengeApp2024;

Employee employee1 = new Employee("Robert", "Kowlskie", 52);
Employee employee2 = new Employee("Darek", "Nowak", 32);
Employee employee3 = new Employee("Karol", "Mowakowski", 40);

employee1.AddGrade(2);
employee1.AddGrade(5);
employee1.AddGrade(9);
employee1.AddGrade(10);
employee1.AddGrade(3);

employee2.AddGrade(10);
employee2.AddGrade(10);
employee2.AddGrade(8);
employee2.AddGrade(1);
employee2.AddGrade(4);

employee3.AddGrade(1);
employee3.AddGrade(1);
employee3.AddGrade(3);
employee3.AddGrade(4);
employee3.AddGrade(2);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;
foreach (Employee employee in employees)
{
    if(employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee;
    }
}

Console.WriteLine("Pracownik z największą suma ocen");
Console.WriteLine($"{employeeWithMaxResult.Name} {employeeWithMaxResult.Surname} lat: {employeeWithMaxResult.Age} wynik: {employeeWithMaxResult.Result}");







