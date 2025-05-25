namespace HomeWork6;

public class Manager : EmployeeBase
{
    public string Task { get; set; }

    public Project CurrentProject { get; set; }
    public override string GetDetails()
    {
        string project = CurrentProject?.DisplayProjectInfo();
        return ($"Manager:\nName: {Name}, Position: {Position}," +
            $" Task: {Task}\n{project}");
    }
    public class Project
    {
        public string ProjectName { get; set; }
        public DateTime Deadline { get; set; }

        public string DisplayProjectInfo()
        {
            return ($"Project: {ProjectName}, Deadline: {Deadline.ToShortDateString()}\n");
        }
    }
}