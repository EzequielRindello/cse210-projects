public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points, isComplete)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }

    public override string CreateGoal(string x)
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        return x;
    }

    public override string RecordEvent(string x)
    {
        return x;
    }

    public override bool IsComplete()
    {
        return true;
    }
}