namespace QuestionNo6
{

    public class Date
    {
        private int day;
        private int month;
        private int year;

      
        public int Day
        {
            get { return day; }
            set { day = value; }
        }

        public int Month
        {
            get { return month; }
            set { month = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

    
        public Date()
        {
        }

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

       
        public void AcceptDate()
        {
            Console.Write("Enter Day: ");
            Day = int.Parse(Console.ReadLine());

            Console.Write("Enter Month: ");
            Month = int.Parse(Console.ReadLine());

            Console.Write("Enter Year: ");
            Year = int.Parse(Console.ReadLine());
        }

   
        public void PrintDate()
        {
            Console.WriteLine(ToString());
        }

        public bool IsValid()
        {
            return DateTime.TryParse($"{Year}-{Month}-{Day}", out _);
        }

      
        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }

      
        public static int DifferenceInYears(Date date1, Date date2)
        {
            DateTime d1 = new DateTime(date1.Year, date1.Month, date1.Day);
            DateTime d2 = new DateTime(date2.Year, date2.Month, date2.Day);

            int years = Math.Abs(d1.Year - d2.Year);
            if (d1 > d2 && d1.AddYears(-years) < d2)
            {
                years--;
            }
            else if (d2 > d1 && d2.AddYears(-years) < d1)
            {
                years--;
            }
            return years;
        }

       
        public static int operator -(Date date1, Date date2)
        {
            return DifferenceInYears(date1, date2);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Date date1 = new Date();
            date1.AcceptDate();
            date1.PrintDate();
            Console.WriteLine("Is date valid? " + date1.IsValid());

            Date date2 = new Date(1, 1, 2000);
            date2.PrintDate();
            Console.WriteLine("Is date valid? " + date2.IsValid());

            int difference = date1 - date2;
            Console.WriteLine($"Difference in years: {difference}");
        }
    }
}
