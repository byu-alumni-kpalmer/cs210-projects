using System;

public class Cycling : Activity
{
    private double Speed { get; }

    public Cycling(DateTime date, int durationMinutes, double speed) : base(date, durationMinutes)
    {
        Speed = speed;
    }

    public override string GetDistance()
    {
        return $"{(Speed * DurationMinutes) / 60:F1} miles";
    }

    public override string GetSpeed()
    {
        return $"{Speed} mph";
    }

    public override string GetPace()
    {
        return $"{60 / Speed:F2} min per mile";
    }
}
