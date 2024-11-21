using System;
namespace Learning02;

public class Job
{
    public string _CompanyName;
    public string _JobTitle;
    public string _StartYear;
    public string _EndYear;

    public void Information()
    {
        Console.WriteLine($"{_JobTitle} ({_CompanyName}) {_StartYear}-{_EndYear}");
    }
}