using System;

namespace _12OB
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Date date1 = new Date(12, 01, 1996);

                Date date2 = new Date(23, 8, 1995);

                date2.AddDays(142);

                Console.WriteLine(date2);

                Console.WriteLine(Equals(date1, date2));

            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.WriteLine(new string('-', 60));
                Console.WriteLine("Source:          {0}", e.Source);
                Console.WriteLine("Type of member:  {0}", e.TargetSite.MemberType);
                Console.WriteLine("Name of member:  {0}", e.TargetSite);
                Console.WriteLine("Stack :          {0}", e.StackTrace);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
