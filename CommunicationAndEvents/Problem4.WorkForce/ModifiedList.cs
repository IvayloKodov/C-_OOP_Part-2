namespace Problem4.WorkForce
{
    using System.Collections.Generic;
    public class ModifiedList :List<Job>
    {
        public void HandleJobCompletion(object sender, JobDoneEventArgs args)
        {
            this.Remove(args.Job);
        }
    }
}