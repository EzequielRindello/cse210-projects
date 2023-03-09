public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points, bool isComplete, string goal) : base(name, description, points, isComplete, goal) { }

    public override string SetGoal()
    {
        this._name = SetName();
        this._description = SetDescription();
        this._points = SetPoints();
        this._goal = _name + " " + "(" + _description + ")" + " " + _points;
        return this._goal;
    }

    public override void RecordEvent()
    {
        _isComplete = true;  
    }

    public override bool IsComplete()
    {
        return true;
    }
}