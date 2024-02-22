using System;

public class Swimming : Activity
{
    private int Laps { get; }

    public Swimming(DateTime date, int durationMinutes, int laps) : base(date, durationMinutes)
    {
        Laps = laps;
    }

    public override string GetDistance()
    {
        return $"{Laps * 50 / 1000:F1} km";
    }

    public override string GetSpeed()
    {
        return $"{(Laps * 50 / 1000) / (DurationMinutes / 60):F1} kph";
    }

    public override string GetPace()
    {
        return $"{(DurationMinutes / Laps) * 60:F2} min per km";
    }
}
