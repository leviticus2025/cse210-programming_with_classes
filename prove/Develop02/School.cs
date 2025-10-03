public class School
{
    public int _numStudents;
    public int _numTeachers;
    public string _name;
    public List<Student> _students = new List<Student>();
    public string _courseName;

    public void Register()
    {
        //Type code here:
    }
    public void ShowDetails()
    {
        Console.WriteLine($"School: {_name} has {_numStudents} students and {_numTeachers} teachers");
        foreach (Student theStudent in _students)
        {
            Console.WriteLine(theStudent.GetName());
        }
    }
}