public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }


    public override bool IsComplete()
    {
        return false;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"You've done it!! Added {GetPoints()}.");
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetName()};{GetDescription()};{GetPoints()}";
    }
}