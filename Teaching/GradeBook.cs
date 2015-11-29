﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teaching
{
    public class GradeBook   
    {

        public GradeBook()
        {
            grades = new List<float>();      //New object created

        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats =  new GradeStatistics();
            float sum = 0;
            foreach(float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;
            return stats;
         }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public string Name;

        List<float> grades;

     }
      
      
}     
      