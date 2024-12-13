using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MajdQadhi.Sprint0.Task4.V0.Lib;

namespace Tyuiu.MajdQadhi.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionalValid()
        {
            Assert.AreEqual(10, DataService.Additional(5, 5));
        }

        public static int Subtraction(int a, int b)
        {
            { return a - b; }
        }
        public static int Multiplication(int a, int b)
        { return a * b;
            }
        public static double Division(int a, int b)
            { return a / b;
        }
    }
}   