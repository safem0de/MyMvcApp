namespace MyMvcApp.Helpers
{
    public static class DataHelper
    {
        public static bool IsMonthSpecial(int year, int month)
        {
            // Count occurrences of Saturdays, Sundays, and Mondays
            int saturdays = 0, sundays = 0, mondays = 0;

            int daysInMonth = DateTime.DaysInMonth(year, month);

            for (int day = 1; day <= daysInMonth; day++)
            {
                DateTime date = new DateTime(year, month, day);
                switch (date.DayOfWeek)
                {
                    case DayOfWeek.Saturday: saturdays++; break;
                    case DayOfWeek.Sunday: sundays++; break;
                    case DayOfWeek.Monday: mondays++; break;
                }
            }

            return saturdays == 5 && sundays == 5 && mondays == 5;
        }

        public static int ConvertBCtoBE(int BE_year)
        {
            return BE_year - 543 < 0 ? 1990 : BE_year - 543;
        }
    }
}