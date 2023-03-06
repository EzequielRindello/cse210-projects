public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points, bool isComplete) : base(name, description, points, isComplete)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }

    public override string CreateGoal(string x)
    {
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