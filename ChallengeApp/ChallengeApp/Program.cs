using ChallengeApp;
using System;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Witamy w programie XYZ do oceny Pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

var employee = new Employee("Adam", "Nowak");


while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika z zakresu (liczbowego 0-100) lub (literowego a-e): ");
    Console.WriteLine("Jeśli chcesz zobaczyć statystyki naciśnij q");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch(Exception e)
    {
        Console.WriteLine($"Exception catche: { e.Message}");
    }
    
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: { statistics.Average}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");




