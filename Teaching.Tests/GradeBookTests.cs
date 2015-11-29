
using Teaching;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teaching.Tests
{
    [TestClass]
    public class TeacherTests
    {
        [TestMethod]
        public void UpperCaseString()
        {
            string name = "Dan";
            name.ToUpper();

            Assert.AreEqual("Dan", name);
        }

        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2015, 1, 1);
            date = date.AddDays(1);

            Assert.AreEqual(2, date.Day);
        }



        [TestMethod]
        public void CompareNames()
        {
            string Instructor1 = "Andrew";
            string Instructor2 = "Nick";
            string Instructor3 = "Ben";

            Console.WriteLine(Instructor1, Instructor2, Instructor3); 
        }

    }





    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Dan";
            string name2 = "dan";

            bool result = String.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
        }

        [TestMethod]
        public void ComputesHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(90, result.HighestGrade);
        }
    }
}
