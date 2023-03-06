public class ChecklistGoal : Goal
{
    private int _howManyTimes;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, bool isComplete) : base(name, description, points, isComplete)
    {
        _name = GetName();
        _description = GetDescription();
        _points = GetPoints();
        _isComplete = isComplete;
    }

    public override string CreateGoal()
    {
        return x;
    }

    public override int RecordEvent()
    {
        return _points;
    }

    public override bool IsComplete()
    {
        return true;
    }
}