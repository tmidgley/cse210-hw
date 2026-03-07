using System;

class Program
{
    static void Main(string[] args)
    {
        //ask for grade percentage
        Console.WriteLine("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int gradePercentageInt = int.Parse(gradePercentage);
        // set variables for letter grade and sign
        string letterGrade = "";
        string sign = "";
        // letter grade
        if (gradePercentageInt >= 90)
        {        
            letterGrade = "A";
        }    
        else if (gradePercentageInt >= 80)
        {        
            letterGrade = "B";
        }    
        else if (gradePercentageInt >= 70)
        {        
            letterGrade = "C";
        }    
        else if (gradePercentageInt >= 60)
        {        
            letterGrade = "D";
        }    
        else
        {        
            letterGrade = "F";
        }
        // stretch goal +/-
        int secondDigit = gradePercentageInt % 10;

        if (letterGrade != "F")
        {
            if (secondDigit >= 7)
            {
                sign = "+";
            }
            else if (secondDigit <= 3)
            {
                sign = "-";
            }
        }
        Console.WriteLine($"Your letter grade is {letterGrade}{sign}.");

        // pass/fail
        if (gradePercentageInt >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the class.");
        }
    }
}