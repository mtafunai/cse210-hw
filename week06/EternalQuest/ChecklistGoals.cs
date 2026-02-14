using System.Reflection;

public class ChecklistGoals: Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public ChecklistGoals(string name, string description, int points, int targetCount, int bonus) : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _currentCount++;

        if (_currentCount == _targetCount)
        {
            return GetPoints() + _bonus;
        }

        return GetPoints();
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    public override string GetStatus()
    {
        return $" [{(_currentCount >= _targetCount ? " X" : " " )}] Completed {_currentCount}/{_targetCount}";

    }

    public override string GetSaveString()
    {
        return $" ChecklistGoal| {GetName()}|{GetDescription()}|{GetPoints()}|{_targetCount}|{_currentCount}|{_bonus}";
    }

}