using System.Diagnostics.SymbolStore;

public class WritingAssignment : Assignment
{
    string _title;

    public WritingAssignment(string studentName, string topic, string title)
      : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }
}