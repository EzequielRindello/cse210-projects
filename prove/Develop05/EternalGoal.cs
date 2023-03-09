public class EternalGoal : Goal
{
    public EternalGoal() : base() { }

    public override string SetGoal()
    {
        this._name = SetName();
        this._description = SetDescription();
        this._points = SetPoints();
        this._goal = _name + "," + " (" + _description + ") " + "," + _points;
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