public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points, bool isComplete, string goal) : base(name, description, points, isComplete, goal) { }

    public override string CreateGoal()
    {
        string x = "[ ]" + " " + _name + " " + "(" + _description + ")" + " " + _points;
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