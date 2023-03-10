public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points, bool isComplete) : base() {_isComplete = false; }

    public override string SetGoal()
    {
        this._name = SetName();
        this._description = SetDescription();
        this._points = SetPoints();
        this._goal = $"EternalGoal,{_name},{_description},{_points},{_isComplete}";
        return this._goal;
    }

    public override void RecordEvent()
    {
        _isComplete = true; 
    }
}