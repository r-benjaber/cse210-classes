public abstract class Goal
{
    private string _shortName;
    private string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _shortName;
    }
    public int GetPoints()
    {
        return _points;
    }
    public string GetDescription()
    {
        return _description;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        if (IsComplete() == false)
        {
            return $"[ ] {_shortName}: {_description}";
        }
        else
        {
            return $"[X] {_shortName}: {_description}";
        }
    }
    public abstract string GetStringRepresentation();
}