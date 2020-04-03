using System;
using System.Collections.Generic;
using System.Linq;

namespace SRP
{
    public class Scheduler : IEntryManager<ScheduledTask>
    {
        private readonly List<ScheduledTask> _scheduleTasks;

        public Scheduler()
        {
            _scheduleTasks = new List<ScheduledTask>();
        }

        public void AddEntry(ScheduledTask entry) => _scheduleTasks.Add(entry);

        public void RemoveEntryAt(int index) => _scheduleTasks.RemoveAt(index);

        public override string ToString() =>
            string.Join(Environment.NewLine,
                _scheduleTasks.Select(x =>
                    $"Task with id: {x.TaskId} with content: {x.Content} is going to be executed on: {x.ExecuteOn}"));
    }
}