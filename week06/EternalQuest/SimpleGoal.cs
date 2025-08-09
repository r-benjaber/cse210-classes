public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }
    public override void RecordEvent()
    {
        Console.WriteLine("Congratulations, you have completed this goal.");
        Console.WriteLine($"Added {GetPoints()} to your score.");
        _isComplete = true;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetName()};{GetDescription()};{GetPoints()}";
    }
}