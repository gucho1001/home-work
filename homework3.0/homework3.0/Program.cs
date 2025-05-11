namespace homework3_0;

internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter your age");
            var age = Convert.ToInt32(Console.ReadLine());

            if (age < 0)
            {
                Console.WriteLine("I think you've got something mixed up.");
            }
            else
            {
                Console.WriteLine(age % 2 == 0 ? "Number is even" : "Number is odd");
                if (age >= 0 && age <= 2)
                {
                    Console.WriteLine("Age group: baby");
                }
                else if (age >= 3 && age <= 12)
                {
                    Console.WriteLine("Age group: kid");
                }
                else if (age >= 13 && age <= 17)
                {
                    Console.WriteLine("Age group: teenager");
                }
                else if (age >= 18 && age <= 59)
                {
                    Console.WriteLine("Age group: adult");
                }
                else
                {
                    Console.WriteLine("Age group: elderly");
                }
            }
        }
        catch
        {
            Console.WriteLine("Error:\nEnter a number!");
        }

        Console.ReadKey();
    }
}