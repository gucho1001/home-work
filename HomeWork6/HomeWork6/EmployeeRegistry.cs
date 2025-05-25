namespace HomeWork6;

public static class EmployeeRegistry
{
    public static List<EmployeeBase> employees = new List<EmployeeBase>();

    public static void AddEmployees(EmployeeBase employ)
    {
        employees.Add(employ);
    }

    public static void ListAllEmployee()
    {
        for (int i = 0; i < employees.Count; i++)
        {
            Console.WriteLine(employees[i].GetDetails());
        }
    }

    public static EmployeeBase FindEmployee(string name)
    {
        for (int i = 0; i < employees.Count; i++)
        {
            if (name.ToLower() == employees[i].Name.ToLower())
            {
                return employees[i];
            }
        }
        return null;
    }
}
