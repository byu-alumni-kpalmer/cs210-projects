using System;

public class Running : Activity
{
    private double Distance { get; }

    public Running(DateTime date, int durationMinutes, double distance) : base(date, durationMinutes)
    {
        Distance = distance;
    }

    public override string GetDistance()
    {
        return $"{Distance} miles";
    }

    public override string GetSpeed()
    {
        return $"{(Distance / DurationMinutes) * 60:F1} mph";
    }

    public override string GetPace()
    {
        return $"{DurationMinutes / Distance:F2} min per mile";
    }
}
