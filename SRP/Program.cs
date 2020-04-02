using System;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            var report = new WorkReport();

            report.AddEntry(new WorkReportEntry
            {
                ProjectCode = "123Ds", ProjectName = "Project1", SpentHours = 5
            });

            report.AddEntry(new WorkReportEntry
            {
                ProjectCode = "987Fc", ProjectName = "Project2", SpentHours = 3
            });

            Console.WriteLine(report.ToString());

            var saver = new FileSaver();
            saver.SaveToFile(@"Reports", "WorkReport.txt", report);
            // File will be created in "..\bin\Debug\netcoreapp2.2\Reports" folder location
        }
    }
}
