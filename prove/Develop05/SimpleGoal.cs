public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points, bool isComplete, string goal) : base(name, description, points, isComplete, goal) { }

    public override string CreateGoal()
    {
        this._name = GetName();
        this._description = GetDescription();
        this._points = GetPoints();
        this._goal = _name + " " + "(" + _description + ")" + " " + _points;
        Console.WriteLine(_goal);
        Thread.Sleep(3000);
        return this._goal;
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