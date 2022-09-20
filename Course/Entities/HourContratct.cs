

namespace Course.Entities
{
    internal class HourContratct
    {
        public DateTime Date { get; set; }
        public double ValuePerHour {get; set;}
        public int Hours { get; set; }

        public HourContratct() { }

        public HourContratct(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return ValuePerHour * Hours;
        }

    }
}
