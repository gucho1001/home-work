namespace HomeWork6;

public class Worker : EmployeeBase
{
    public string Skill { get; set; }

    public override string GetDetails()
    {
        return ($"Worker:\nName: {Name}, Position: {Position}," +
            $" Skill: {Skill}\n");
    }
}