using ChallengeApp;
using System;

var employee = new Employee("Jan ", "Nowak ");
employee.AddGrade(5);
employee.AddGrade(6);
employee.AddGrade(10.12);
employee.AddGrade(2);
//var statistics = employee.GetStatistics();
var statistics1 = employee.GetStatisticsWithForeach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWhile();

Console.WriteLine("Dla pętli Foreach otrzymano wyniki: ");
Console.WriteLine("Pracownik: "+employee.Name + employee.Surname);
Console.WriteLine($"Ocena Min: {statistics1.Min}");
Console.WriteLine($"Ocena Max: {statistics1.Max}");
Console.WriteLine($"Srednia ocen: {statistics1.Average:N2}");
Console.WriteLine("");

Console.WriteLine("Dla pętli For otrzymano wyniki: ");
Console.WriteLine("Pracownik: " + employee.Name + employee.Surname);
Console.WriteLine($"Ocena Min: {statistics2.Min}");
Console.WriteLine($"Ocena Max: {statistics2.Max}");
Console.WriteLine($"Srednia ocen: {statistics2.Average:N2}");
Console.WriteLine("");

Console.WriteLine("Dla pętli DoWhile otrzymano wyniki: ");
Console.WriteLine("Pracownik: " + employee.Name + employee.Surname);
Console.WriteLine($"Ocena Min: {statistics3.Min}");
Console.WriteLine($"Ocena Max: {statistics3.Max}");
Console.WriteLine($"Srednia ocen: {statistics3.Average:N2}");
Console.WriteLine("");

Console.WriteLine("Dla pętli While otrzymano wyniki: ");
Console.WriteLine("Pracownik: " + employee.Name + employee.Surname);
Console.WriteLine("");
Console.WriteLine($"Ocena Min: {statistics4.Min}");
Console.WriteLine($"Ocena Max: {statistics4.Max}");
Console.WriteLine($"Srednia ocen: {statistics4.Average:N2}");