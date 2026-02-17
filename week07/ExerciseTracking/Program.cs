using System;
using System.Diagnostics;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
    }

    abstract class Activity
    {
        private DateTime _date;
        private double _lengthMinutes;

        public Activity(DateTime date, double lengthMinutes)
        {
            _date = date;
            _lengthMinutes = lengthMinutes;
        }

        public DateTime Date { get { return _date; } }
        public double LengthMinutes { get { return _lengthMinutes; } }

        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        public string GetSummary()
        {
            return $"{_date:dd MM yyyy} {this.GetType().Name} ({_lengthMinutes} min) " +
            $"Distance {GetDistance():0.00} miles. " +
            $"Speed {GetSpeed():0.00} mph. " +
            $"Pace: {GetPace():0.00} min per mile";
        }
    }

    class Running : Activity
    {
        private double _distance;

        public Running(DateTime date, double lengthMinutes, double distance) : base(date, lengthMinutes)
        {
            _distance = distance;
        }

        public override double GetDistance()
        {
            return _distance;
        }

        public override double GetSpeed()
        {
            return (GetDistance() / LengthMinutes) * 60.0;
        }

        public override double GetPace()
        {
            return LengthMinutes / GetDistance();
        }
    }

    class Cycling : Activity
    {
        public double _speed;

        public Cycling(DateTime date, double lengthMInutes, double speed) : base(date, lengthMInutes)
        {
            _speed = speed;
        }

        public override double GetDistance()
        {
            return (_speed * LengthMinutes / 60.0);

        }

        public override double GetSpeed()
        {
            return _speed;
        }

        public override double GetPace()
        {
            return 60.0 / _speed;
        }
    }

    class Swimming : Activity
    {
        private int _laps;

        public Swimming(DateTime date, double lengthMinutes, int laps) : base(date, lengthMinutes)
        {
            _laps = laps;
        }

        public override double GetDistance()
        {
            return _laps * 50.0 / 1000.0 * 0.02;
        }

        public override double GetSpeed()
        {
            return (GetDistance() / LengthMinutes) * 60.0;
        }

        public override double GetPace()
        {
            return LengthMinutes / GetDistance();
        }
    }

    static void Main()
    {
        List<Activity> activities = new List<Activity>()
        {
            new Running(new DateTime(2024, 11, 3), 30, 3.0),
            new Cycling(new DateTime(2024, 11, 3), 45, 12.0),
            new Swimming(new DateTime(2024, 11, 3), 60, 40)

        };
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}