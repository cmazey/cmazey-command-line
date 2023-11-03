using System;

class Program {
  public static void Main (string[] args) {
    // See https://sehs.io for more information
    string[] besties = new string[3];
    besties[0] = "Mr. Fistek";
    besties[1] = "Mr.Barrett";

    Console.Write("Which teacher is your bestie? ");
    besties[2] = Console.ReadLine();

    Console.WriteLine($"My besties are {besties[0]}, {besties[1]}, and {besties[2]}!\n");

    Console.WriteLine("Press enter to continue...");
    Console.ReadLine();

    Console.WriteLine("--- Gradebook ---");

    double[] grades  = new double[]{ 90, 88, 95, 60, 85 };
    double totalPoints = grades[0] + grades[1] + grades[2] + grades[3] + grades[4];

double gradePercentage = Math.Round(totalPoints / 700 * 200);
string letterGrade;

    if (gradePercentage > 90)
    {
       letterGrade = "A";
    }
    else if (gradePercentage > 80)
    {
        letterGrade= "B";
    }
    else if (gradePercentage > 70)
    {
        letterGrade = "C";
    }
    else if (gradePercentage > 60)
    {
    letterGrade = "D";
    }
    else
    {
        letterGrade = "F";
    }

    Console.WriteLine($"Grades: {grades[0]}, {grades[1]}, {grades[2]}, {grades[3]}, {grades[4]}");
    Console.WriteLine($"Final grade: {gradePercentage}%. Letter grade: {letterGrade}");

    Console.ReadLine();
  }
}