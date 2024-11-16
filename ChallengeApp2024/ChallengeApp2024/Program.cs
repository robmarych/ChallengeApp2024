
using ChallengeApp2024;

Employee employee1 = new Employee("Robert", "Kowlskie", 52);
//Employee employee2 = new Employee("Darek", "Nowak", 32);
//Employee employee3 = new Employee("Karol", "Mowakowski", 40);
employee1.AddGrade(2);
employee1.AddGrade("2");
employee1.AddGrade(3);
employee1.AddGrade(10);
var statict = employee1.GetStatistics();
Console.WriteLine($"Average:\t{statict.Average:N2}");
Console.WriteLine($"Max:\t\t{statict.Max}");
Console.WriteLine($"Min:\t\t{statict.Min}");

Console.WriteLine("Pętla for ");
var statict1 = employee1.GetStatisticsWithFor();
Console.WriteLine($"Average:\t{statict1.Average:N2}");
Console.WriteLine($"Max:\t\t{statict1.Max}");
Console.WriteLine($"Min:\t\t{statict1.Min}");


Console.WriteLine("Pętla do while ");
var statict2 = employee1.GetStatisticsWithDoWhile();
Console.WriteLine($"Average:\t{statict2.Average:N2}");
Console.WriteLine($"Max:\t\t{statict2.Max}");
Console.WriteLine($"Min:\t\t{statict2.Min}");


Console.WriteLine("Pętla  wihile ");
var statict3 = employee1.GetStatisticsWithWhile();
Console.WriteLine($"Average:\t{statict3.Average:N2}");
Console.WriteLine($"Max:\t\t{statict3.Max}");
Console.WriteLine($"Min:\t\t{statict3.Min}");











