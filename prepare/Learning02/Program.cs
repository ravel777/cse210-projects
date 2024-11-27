using System;
namespace Learning02;
class Program
{
    static void Main(string[] args)
    {
        //Comment
        Job info1 = new Job();
        info1._CompanyName = "Komput";
        info1._JobTitle = "Programmer";
        info1._StartYear = "2021";
        info1._EndYear = "2090";

        Job info2 = new Job();
        info2._CompanyName = "Pépère";
        info2._JobTitle = "Accountable";
        info2._StartYear = "2026";
        info2._EndYear = "2090";

        Job info3 = new Job();
        info3._CompanyName = "BITOUNGUI Group";
        info3._JobTitle = "Finance Manager";
        info3._StartYear = "2030";
        info3._EndYear = "2090";

        Resume res = new Resume();
        res._PersonName = "Vri";

        res._JobList.Add(info1);
        res._JobList.Add(info2);
        res._JobList.Add(info3);

        res.Information();
    }
}