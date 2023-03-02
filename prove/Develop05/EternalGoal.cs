public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points, bool isComplete) : base(name, description, points, isComplete)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }

    public override string RecordEvent()
    {
        return "";
    }

    public override string IsComplete()
    {
        return " ";
    }

}