namespace HomeWork6;

public abstract class EmployeeBase
{
    public string Name { get; set; }
    public string Position { get; set; }

    public abstract string GetDetails();
    public override string ToString()
    {
        return Name;
    }
}
