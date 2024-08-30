﻿namespace ContratosFuncionario.Entities
{
    class HourContrats
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContrats()
        {
        }

        public HourContrats(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }
        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
