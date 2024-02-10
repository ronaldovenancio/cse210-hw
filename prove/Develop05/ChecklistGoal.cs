using System;

public class ChecklistGoal : Goal
{
    // Attributes
    private string _type = "Check List Goal:";
    private int _target;
    private int _bonus;
    private bool _status;
    private int _amountCompleted;


    // Constructors
    public ChecklistGoal(string type, string name, string description, int points, int target, int bonus) : base(type, name, description, points)
    {
        _status = false;
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }
    public ChecklistGoal(string type, string name, string description, int points, bool status, int target, int bonus, int amountCompleted) : base(type, name, description, points)
    {
        _status = status;
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public int GetTimes()
    {
        return _target;
    }
    public void SetTimes()
    {
        _amountCompleted = _amountCompleted + 1;
    }
     public int GetCount()
    {
        return _amountCompleted;
    }
    public void SetCount()
    {

    }
     public int GetBonusPoints()
    {
        return _bonus;
    }
    public Boolean Finished()
    {
        return _status;
    }

    // Methods
    public override void ListGoal(int i)
    {
        if (Finished() == false)
        {
            Console.WriteLine($"{i}. [ ] {GetName()} ({GetDescription()})  --  Currently Completed: {GetCount()}/{GetTimes()}");
        }
        else if (Finished() == true)
        {
            Console.WriteLine($"{i}. [X] {GetName()} ({GetDescription()})  --  Completed: {GetCount()}/{GetTimes()}");
        }

    }
    public override string SaveGoal()
    {
        return ($"{_type}; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}; {GetTimes()}; {GetBonusPoints()}; {GetCount()}");
    }
    public override string LoadGoal()
    {
        return ($"Simple Goal:; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}; {GetTimes()}; {GetBonusPoints()}; {GetCount()}");
    }
    public override void RecordGoalEvent(List<Goal> goals)
    {
        SetTimes();
        int points = GetPoints();

        if (_amountCompleted == _target)
        {
            _status = true;
            points = points + _bonus;
  
            Console.WriteLine($"Congratulations! You have earned {points} points!");
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
        }
    }

}