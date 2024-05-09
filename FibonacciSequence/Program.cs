/// Write a C# program to generate the Fibonacci sequence up to a specified number of terms. 
/// The Fibonacci sequence is a series of numbers where each number is the sum of the two preceding ones, 
/// usually starting with 0 and 1. 
/// For example, the first few numbers in the Fibonacci sequence are 0, 1, 1, 2, 3, 5, 8, 13, 21, ...
/// Your program should prompt the user to enter the number of terms they want in the Fibonacci sequence
/// and then output the sequence up to that number of terms.

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the number of terms for the Fibonacci sequence:");
var numTerms = Convert.ToInt32(Console.ReadLine());

var iteration = 0;
var firtNumber = 0;
var secondNumber = 1;
var nextNumber = 0;

while (iteration != numTerms)
{
    Console.WriteLine($"next sequence: {nextNumber}");
    nextNumber = firtNumber + secondNumber;

    firtNumber = secondNumber;
    secondNumber = nextNumber;

    iteration++;
}
Console.ReadLine();