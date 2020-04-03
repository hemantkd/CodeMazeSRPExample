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

            // Create a Scheduler class that keeps track of its scheduled tasks
            // We would still like to save it to a file.
            var scheduler = new Scheduler();

            scheduler.AddEntry(new ScheduledTask
            {
                TaskId = 1,
                Content = "Do this...",
                ExecuteOn = DateTime.UtcNow.AddDays(5)
            });

            scheduler.AddEntry(new ScheduledTask
            {
                TaskId = 2,
                Content = "Do that...",
                ExecuteOn = DateTime.UtcNow.AddDays(2)
            });

            Console.WriteLine(scheduler.ToString());

            var saver = new FileSaver();
            saver.SaveToFile(@"Reports", "WorkReport.txt", report);
            saver.SaveToFile(@"Scheduler", "ScheduledTasks.txt", scheduler);
            // File will be created in "..\bin\Debug\netcoreapp2.2\Reports" folder location
        }
    }
}
