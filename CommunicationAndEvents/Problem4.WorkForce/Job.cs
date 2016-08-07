using System;
using Problem4.WorkForce.Employees;

namespace Problem4.WorkForce
{
    public delegate void JobUpdateHandler(object sender, JobDoneEventArgs args);
    public class Job
    {
        private string name;
        private int workHoursRequired;
        private Employee employee;

        public Job(string name, int workHoursRequired, Employee employee)
        {
            this.Name = name;
            this.WorkHoursRequired = workHoursRequired;
            this.Employee = employee;
        }

        public event JobUpdateHandler jobUpdateHandler;

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public int WorkHoursRequired
        {
            get { return workHoursRequired; }
            private set { workHoursRequired = value; }
        }

        public Employee Employee
        {
            get { return employee; }
            private set { employee = value; }
        }

        public void Update()
        {
            this.WorkHoursRequired = this.WorkHoursRequired - this.Employee.WorkHoursPerWeek;
            if (this.WorkHoursRequired <= 0)
            {
                Console.WriteLine($"Job {Name} done!");
                this.OnJobUpdate(new JobDoneEventArgs(this));
            }
        }

        public void OnJobUpdate(JobDoneEventArgs e)
        {
            jobUpdateHandler?.Invoke(this, e);
        }

        public override string ToString()
        {
            return $"Job: {Name} Hours Remaining: {WorkHoursRequired}";
        }
    }
}