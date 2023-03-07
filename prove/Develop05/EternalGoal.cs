public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points, bool isComplete) : base(name, description, points, isComplete)
    {
        _name = GetName();
        _description = GetDescription();
        _points = GetPoints();
        _isComplete = isComplete;
    }

    public override string CreateGoal()
    {
        string x = "[ ]" + " " + _name + " " + "(" + _description + _points + ")";
        return this._goal = x;
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