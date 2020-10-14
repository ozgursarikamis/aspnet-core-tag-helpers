using System;

namespace TagHelpers
{
    public interface ITimeSinceService
    {
        string TimeSince(DateTime dateTime);
    }

    public class TimeSinceService: ITimeSinceService
    {
        public string TimeSince(DateTime dateTime)
        {
            var timeSpan = DateTime.Now.Subtract(dateTime);
            return PeriodOfTimeOutput(timeSpan);
        }

        /// <summary>
        /// from: http://stackoverflow.com/questions/3383464/is-there-a-smarter-way-to-generate-time-since-with-a-datetime-objects
        /// </summary>
        /// <param name="tspan"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        private static string PeriodOfTimeOutput(TimeSpan tspan, int level = 0)
        {
            var howLongAgo = "ago";
            if (level >= 2) return howLongAgo;
            if (tspan.Days > 1)
                howLongAgo = $"{tspan.Days} Days ago";
            else if (tspan.Days == 1)
                howLongAgo =
                    $"1 Day {PeriodOfTimeOutput(new TimeSpan(tspan.Hours, tspan.Minutes, tspan.Seconds), level + 1)}";
            else if (tspan.Hours >= 1)
                howLongAgo =
                    $"{tspan.Hours} {((tspan.Hours > 1) ? "Hours" : "Hour")} {PeriodOfTimeOutput(new TimeSpan(0, tspan.Minutes, tspan.Seconds), level + 1)}";
            else if (tspan.Minutes >= 1)
                howLongAgo =
                    $"{tspan.Minutes} {((tspan.Minutes > 1) ? "Minutes" : "Minute")} {PeriodOfTimeOutput(new TimeSpan(0, 0, tspan.Seconds), level + 1)}";
            else if (tspan.Seconds >= 1)
                howLongAgo = $"{tspan.Seconds} {((tspan.Seconds > 1) ? "Seconds" : "Second")} ago";
            return howLongAgo;
        }
    }
}
