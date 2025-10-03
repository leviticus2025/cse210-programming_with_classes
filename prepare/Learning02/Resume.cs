public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();
    public void DisplayResumeDetails()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs: ");
        //These two lines of code above are not included in the foreach loop
        //because it belongs to the resume details and not the job details
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
            //Then this line of code is calling the DisplayJobDetails
            //and going through that method and writing out that line
            //as I stated in the Job.cs file under class Job on line 9
        }
    }

}