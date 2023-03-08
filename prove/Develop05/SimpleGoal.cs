public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points, isComplete) { }

    public override string CreateGoal()
    {
        this._name = GetName();
        this._description = GetDescription();
        this._points = GetPoints();
        string goal = _name + " " + "(" + _description + ")" + " " + _points;
        return this._goal = goal;
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