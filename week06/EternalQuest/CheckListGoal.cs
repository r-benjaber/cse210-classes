using System.Runtime;

public class ChecklistGoal : Goal
{
    private int _ammountComplete;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int ammountComplete, int target, int bonus) : base(name, description, points)
    {
        _ammountComplete = ammountComplete;
        _target = target;
        _bonus = bonus;
    }

    public override bool IsComplete()
    {
        if (_ammountComplete == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string GetDetailsString()
    {
        if (IsComplete() == false)
        {
            return $"[ ] {GetName()}: {GetDescription()} -- Completed {_ammountComplete}/{_target}";
        }
        else
        {
            return $"[X] {GetName()}: {GetDescription()} -- Completed {_ammountComplete}/{_target}";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetName()};{GetDescription()};{GetPoints()};{_ammountComplete};{_target};{_bonus}";
    }

    public override void RecordEvent()
    {
        _ammountComplete++;
        if (_ammountComplete < _target)
        {
            Console.WriteLine("Great! You completed one step!");
            Console.WriteLine($"Added {GetPoints()} points.");
        }
        else
        {
            Console.WriteLine("Congratulations, you've completed your goal!!");
            Console.WriteLine($"You've got a {_bonus} points bonus.");
            _points += _bonus;
        }
    }
}