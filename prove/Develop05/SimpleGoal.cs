public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points, bool isComplete, string goal) : base(name, description, points, isComplete, goal) { }

    public override string CreateGoal()
    {
        this._name = GetName();
        this._description = GetDescription();
        this._points = GetPoints();
        string fullGoal = _name + " " + "(" + _description + ")" + " " + _points;
        this._goal = fullGoal;
        return fullGoal;
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