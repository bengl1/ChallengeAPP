﻿using ChallengeApp;
using System;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Witamy w programie XYZ do oceny Pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

var employee = new EmployeeInFile("Adam", "Nowak");
employee.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę.");
}

while (true)
{
    Console.WriteLine();
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
    catch (Exception e)
    {
        Console.WriteLine($"exception catche: {e.Message}");
    }

}

var statistics = employee.GetStatistics();
Console.WriteLine($"average: {statistics.Average}");
Console.WriteLine($"max: {statistics.Max}");
Console.WriteLine($"min: {statistics.Min}");
Console.WriteLine($"averageletter: {statistics.AverageLetter}");




