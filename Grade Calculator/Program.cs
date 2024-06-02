namespace Grade_Calculator;

internal class Program
{
    static void Main()
    {
        double grade;

        Console.WriteLine("Welcome to the Grade Calculator Program: ");
        Console.WriteLine("Enter your grade: ");

        grade = Convert.ToInt32(Console.ReadLine());

        while (grade < 0 || grade > 100)
        {
            Console.WriteLine("Your Grade input should be in the range 0 - 100");
            Console.WriteLine("Enter your grade: ");
            grade = Convert.ToInt32(Console.ReadLine());
        }

        if (grade >= 90)
        {
            Console.WriteLine("Result : A");
        }
        else if (grade >= 80 && grade <= 89 )
        {
            Console.WriteLine("Result : B");
        }
        else if (grade >= 70 && grade <= 79 )
        {
            Console.WriteLine("Result : C");
        }
        else if (grade >= 60 && grade <=69 )
        {
            Console.WriteLine("Result : D");
        }
        else
        {
            Console.WriteLine("Result : F");
        }
    }
}