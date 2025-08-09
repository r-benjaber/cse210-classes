public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool running = true;
        while (running == true)
        {
            Console.Clear();
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create a New Goal.");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Please enter your option: ");
            string option = Console.ReadLine();

            Console.Clear();
            switch(option)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoalDetails(); break;
                case "3": SaveGoals(); break;
                case "4": LoadGoals(); break;
                case "5": RecordEvent(); break;
                case "6": running = false; break;
                default: Console.WriteLine("Please enter a valid option."); break;
            }
            Console.ReadLine();
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalName()
    {
        int n = 1;
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{n}. {g.GetName()}");
            n++;
        }
        Console.WriteLine();
    }

    public void ListGoalDetails()
    {
        int n = 1;
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{n}. {g.GetDetailsString()}");
            n++;
        }
    }

    public void CreateGoal()
    {

        Console.WriteLine("1. Simple Goal.");
        Console.WriteLine("2. Eternal Goal.");
        Console.WriteLine("3. Checklist Goal.");
        Console.WriteLine();
        Console.Write("Select a type of goal: ");
        string choice = Console.ReadLine();
        if (choice == "1")
        {
            Console.WriteLine("Name your goal: ");
            string name = Console.ReadLine();
            Console.WriteLine("Describe your goal: ");
            string description = Console.ReadLine();
            Console.WriteLine("How many points would it give to you? ");
            string stringPoints = Console.ReadLine();
            int points = int.Parse(stringPoints);
            _goals.Add(new SimpleGoal(name, description, points));
        }
        if (choice == "2")
        {
            Console.WriteLine("Name your goal: ");
            string name = Console.ReadLine();
            Console.WriteLine("Describe your goal: ");
            string description = Console.ReadLine();
            Console.WriteLine("How many points would it give to you? ");
            string stringPoints = Console.ReadLine();
            int points = int.Parse(stringPoints);
            _goals.Add(new EternalGoal(name, description, points));
        }
        if (choice == "3")
        {
            Console.WriteLine("Name your goal: ");
            string name = Console.ReadLine();
            Console.WriteLine("Describe your goal: ");
            string description = Console.ReadLine();
            Console.WriteLine("How many points would it give to you? ");
            string stringPoints = Console.ReadLine();
            int points = int.Parse(stringPoints);
            Console.WriteLine("How many times do you want to do this goal? ");
            string stringTarget = Console.ReadLine();
            int target = int.Parse(stringTarget);
            Console.WriteLine("How many points will you recive when you finish? ");
            string stringBonus = Console.ReadLine();
            int bonus = int.Parse(stringBonus);
            _goals.Add(new ChecklistGoal(name, description, points, 0, target, bonus));
        }
    }

    public void RecordEvent()
    {

        Console.WriteLine("What did you do? ");
        ListGoalName();
        string stringChoice = Console.ReadLine();
        int choice = int.Parse(stringChoice);
        Goal goal = _goals[choice - 1];
        if (!goal.IsComplete())
        {
            goal.RecordEvent();
            _score += goal.GetPoints();
        }
        else Console.WriteLine("This goal is completed already.");
    }

    public void SaveGoals()
    {
        Console.WriteLine("What's the name of the file you want to save in? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{_score}");
            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.WriteLine("What's the name of the file you want to load from? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        _score = int.Parse(lines[0]);
        foreach (string line in lines.Skip(1))
        {
            string[] goals = line.Split(":");
            string type = goals[0];
            string partSide = goals[1];
            string[] parts = partSide.Split(";");
            if (type == "ChecklistGoal")
            {
                _goals.Add(new ChecklistGoal(parts[0], parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5])));
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(parts[0], parts[1], int.Parse(parts[2])));
            }
            else if (type == "SimpleGoal")
            {
                _goals.Add(new SimpleGoal(parts[0], parts[1], int.Parse(parts[2])));
            }
        }
    }
}