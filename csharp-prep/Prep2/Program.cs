using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int gradePercent = int.Parse(userInput);

        string letter;
        
        if (gradePercent >= 90)
        {
            
            letter = "A";
        }
        else if (gradePercent >= 80)
        {
            
            letter = "B";
        }
        else if (gradePercent >= 70)
        {
           
            letter = "C";
        }
        else if (gradePercent >= 60)
        {
            
            letter = "D";
        }
        else
        {
            
            letter = "F";
        }

        // Stretch Challenge #1, #2, #3
        string fd = userInput.Substring(0, 1);
        int firstDigit = int.Parse(fd);

        string ld = userInput.Substring(1, 1);
        int lastDigit = int.Parse(ld);

        
        string ext;
        if ((firstDigit > 5 && firstDigit < 9) && lastDigit >= 7)
        {
            ext = "+";
        }
        else if ((firstDigit > 5 && firstDigit <= 9) && lastDigit < 3)
        {
            ext = "-";
        }
        else
        {
            ext = "";
        }

        Console.WriteLine($"You earned an letter grade of {letter}{ext}");

        if (gradePercent >= 70)
        {
            Console.WriteLine("Congratulations you passed the test!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass.  Better luck next time!");
        }
    }
}