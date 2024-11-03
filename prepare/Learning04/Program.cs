using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment A1 = new Assignment("Tatum Miller", "Mathematics" );
        Console.WriteLine(A1.GetSummary());

        MathAssignment A2 = new MathAssignment("Tatum Miller", "Graphing Linear Equations", "Section 6", "Problems 4-25");
        Console.WriteLine(A2.GetSummary());
        Console.WriteLine(A2.GetHomeworkList());

        WritingAssignment A3 = new WritingAssignment("Tatum Miller", "The Beatles", "The Most Influential Band");
        Console.WriteLine(A3.GetSummary());
        Console.WriteLine(A3.GetWritingInformation());
    }
}