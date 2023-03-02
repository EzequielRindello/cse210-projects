public class ChecklistGoal : Goal
{
    public ChecklistGoal(string name, string description, int points, bool isComplete) : base(name, description, points, isComplete)
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

    public override bool IsComplete()
    {
        return true;
    }
}