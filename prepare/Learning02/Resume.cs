namespace Learning02;

public class Resume
{
    public string _PersonName;
    public List<Job> _JobList = new List<Job>();

    public void Information()
    {
        Console.WriteLine($"Name: {_PersonName}");
        Console.WriteLine($"Jobs: ");
        foreach(Job job in _JobList)
        {
            job.Information();
        }
    }
}

