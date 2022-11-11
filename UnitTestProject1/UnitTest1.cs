using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Program;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program.matmodel prog = new Program.matmodel();
            prog.minus(10, 2);
        }
    }
}
