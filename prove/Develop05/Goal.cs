using System;

public abstract class Goal
{
    // Attributes
    private string _type;
    private string _shortName;
    private string _description;
    private int _points;


    // Constructors
    public Goal(string type, string shortName, string description, int points)
    {
        _type = type;
        _shortName = shortName;
        _description = description;
        _points = points;
    }
    public string GetType()
    {
        return _type;
    }
    public string GetName()
    {
        return _shortName;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }


    // Methods
    public abstract void ListGoal(int i);
    public abstract string SaveGoal();
    public abstract string LoadGoal();
    public abstract void RecordGoalEvent(List<Goal> goals);

}