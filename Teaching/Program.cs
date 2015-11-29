using System;using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teaching
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1 = new GradeBook();
            g1.Name = "Dan's grade book";
            Console.WriteLine(g1.Name);



            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);


            GradeStatistics stats = book.ComputeStatistics();
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", (int)stats.HighestGrade);
            WriteResult("Lowest", (int)stats.LowestGrade);

        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine(description + ": " + result);
        }
        
     
        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }
                        
        
    }
}
