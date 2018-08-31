using System;

namespace _12OB
{
    class Date
    {
        private int? year;
        private int? month;
        private int? day;

        public int? Year
        {
            get { return year; }
            set
            {
                if (value >= 1)
                    year = value;
                else
                    throw new Exception("Error: year should have only positive values!");
            }
        }
        public int? Month
        {
            get { return month; }
            set
            {
                if (year != null)
                {
                    if (value >= 1 && value <= 12)
                        month = value;
                    else
                        throw new Exception($"{value} is invalid number of Month. Year have range from 1 to 12 Months");
                }
                else
                    throw new Exception("Error: enter year first!");
            }
        }
        public int? Day
        {
            get { return day; }
            set
            {
                if (year != null && month != null)
                {
                    int NumbOfDays = GetNumbOfDays();
                    if (value >= 1 && value <= NumbOfDays)
                        day = value;
                    else
                        throw new Exception($"Error: {value} is invalid number of day! {month} Month have range from 1 to {NumbOfDays} day");

                }
                else
                    throw new Exception("Set Year and Month first!");
            }
        }

        private int GetNumbOfDays()
        {
            if (Month == 1 || Month == 3 || Month == 5 || Month == 7 || Month == 8 || Month == 10 || Month == 12)
                return 31;
            else if (Month == 4 || Month == 6 || Month == 9 || Month == 11)
                return 30;
            else
            {
                if (Year % 4 == 0)
                    return 29;
                else
                    return 28;
            }
        } // Определяем количество дней в текущем месяце

        public Date() : this(DateTime.Now.Day) { }
        public Date(int? Day) : this(Day, DateTime.Now.Month) { }
        public Date(int? Day, int? Month) : this(Day, Month, DateTime.Now.Year) { }
        public Date(int? Day, int? Month, int? Year)
        {
            this.Year = Year;
            this.Month = Month;
            this.Day = Day;
        }

        public void AddDays(int value)
        {
            value = (int)Day + value;
            while (true)
            {
                //Определяем количество дней в текущем месяце
                int NumbOfDays = GetNumbOfDays();


                //логика
                if (value >= 1 && value <= NumbOfDays)
                {
                    Day = value;
                    break;
                }
                else if (day + value > NumbOfDays)
                {
                    AddMonths(1);
                    value -= NumbOfDays;
                }
                else
                {
                    AddMonths(-1);
                    //нужно отнять кол-во дней в предыдущем месяце!
                    value += GetNumbOfDays();

                }

            }
        }

        public void AddMonths(int value)
        {
            value = (int)Month + value;
            while (true)
            {
                if (value >= 1 && value <= 12)
                {
                    Month = value;
                    break;
                }
                else if (value > 12)
                {
                    AddYears(1);
                    value -= 12;
                }
                else
                {
                    AddYears(-1);
                    value += 12;
                }
            }
        }

        public void AddYears(int value)
        {
            Year += value;
        }

        public override string ToString()
        {
            return $"{Day}.{Month}.{Year}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            Date d = (Date)obj;
            return (Day == d.Day) && (Month == d.Month) && (Year == d.Year);
        }

        public override int GetHashCode()
        {
            string y = Year.ToString();

            string m = Month.ToString().PadLeft(2, '0');

            string d = Day.ToString().PadLeft(2, '0');
            
            return Convert.ToInt32(y+m+d);
        }
    }
}
