using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Teaching
{
    public class GradeStatistics
    {
        public GradeStatistics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }

        public float HighestGrade;
        public float LowestGrade;
        public float AverageGrade;

        //public int DefineGradeType()
        //{
        //    IndividualProjectGrades = 30;
        //    ExamGrades = 40;
        //    GroupProjectGrades = 30;

        


    }
}