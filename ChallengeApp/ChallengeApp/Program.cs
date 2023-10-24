using ChallengeApp;
using System;

var employee = new Employee("Jan", "Nowak");
employee.AddGrade(2);
employee.AddGrade(6);
employee.AddGrade(2);
var statistics = employee.GetStatistics();
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Average: {statistics.Average:N2}");