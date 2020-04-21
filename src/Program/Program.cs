using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string testDate = "01/10/2020";

            Format fecha1 = new Format();
            
            Console.WriteLine("{0} se convierte a {1}", testDate, fecha1.ChangeFormat(testDate));
           

        }

    }
}
