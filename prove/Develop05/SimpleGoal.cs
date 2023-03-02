public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public override string RecordEvent()
    {
        return "";
    }

    public override string IsComplete()
    {
        return " ";
    }

}