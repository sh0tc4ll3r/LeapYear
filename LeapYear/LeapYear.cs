namespace LeapYear
{
    public class LeapYear
    {
        public static bool IsLeap(int year)
        {
            if (year % 4 == 0 && year % 100 != 0)
            {
                return true;
            }
            return year % 400 == 0;
        }
    }

}
