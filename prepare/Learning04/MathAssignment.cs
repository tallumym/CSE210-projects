using System;

public class MathAssignment : Assignment
{
    string _section;
    string _problems;

    public MathAssignment(string studentName, String topic, string section, string problems)
     : base(studentName, topic)
    {
        _section = section;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"section {_section} Problems {_problems}";
    }
}