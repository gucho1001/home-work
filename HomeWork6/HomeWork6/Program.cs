namespace HomeWork6;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("List of employees:\n");

        var manager = new Manager()
        {
            Name = "Valera",
            Position = "Older manager",
            Task = "Development",
            CurrentProject = new Manager.Project
            {
                ProjectName = "DOKA 2",
                Deadline = DateTime.Now,
            }
        };
        var manager1 = new Manager()
        {
            Name = "Vitya",
            Position = "Project manager",
            Task = "Development",
            CurrentProject = new Manager.Project
            {
                ProjectName = "DOKA 2",
                Deadline = DateTime.Now,
            }
        };

        var worker = new Worker()
        {
            Name = "Anton",
            Position = "Developer",
            Skill = "C#"
        };
        var worker1 = new Worker()
        {
            Name = "Monika",
            Position = "Engineer",
            Skill = "Java"
        };
        string input;
        EmployeeRegistry.AddEmployees(manager);
        EmployeeRegistry.AddEmployees(manager1);
        EmployeeRegistry.AddEmployees(worker);
        EmployeeRegistry.AddEmployees(worker1);
        EmployeeRegistry.ListAllEmployee();
        while (true)
        {
            Console.WriteLine("Enter a name to search for an employee:");
            input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Enter something!");
            }
            else
            {

                var result = EmployeeRegistry.FindEmployee(input);
                if (result != null)
                {
                    Console.WriteLine($"Employee found:\n {result.GetDetails()}");
                    break;
                }
                else
                {
                    Console.WriteLine("Employee not found!");
                }
            }
        }
    }
}

