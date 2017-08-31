using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using processRunner;

namespace processTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public IParameteriseAble TestNumber()
        {
            Number n = new Number();
            return n;
        }
        [TestMethod]
        public IParameteriseAble TestText()
        {
            IParameteriseAble n = new Text();
            return n;
        }

        [TestMethod]
        public IParameteriseAble TestArray()
        {
            IParameteriseAble n = new processRunner.Array();
            return n;
        }
    }
}
