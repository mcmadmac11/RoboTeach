﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teaching
{
    
        internal interface ITrackGrades : IEnumerable
        {
            void AddGrade(float grade);
            GradeStatistics ComputeStatistics();
            void WriteGrades(TextWriter destination);
            string Name { get; set; }
        
    }
}
