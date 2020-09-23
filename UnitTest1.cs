using System;
using Expression;
using NUnit.Framework;

namespace ExpressionTest
{
    [TestFixture]
    public class UnitTest1
    {
        private ExpressionParser expressionParser;

        [OneTimeSetUp]
        public void OnTestStarted()
        {
            expressionParser = new ExpressionParser();
        }
        [Test]
        public void TestDigit()
        {
            string testExpression = "4";
            
            int acualResult = expressionParser.Parse(testExpression);

            
            Assert.AreEqual(4, acualResult);

        }
        [Test]
        public void TestNumber()
        {
            string testExpression = "15";

            int acualResult = expressionParser.Parse(testExpression);


            Assert.AreEqual(15, acualResult);

        }
        [Test]
        public void TestNumberAdd()
        {
            string testExpression = "15+28+0+75";

            int acualResult = expressionParser.Parse(testExpression);


            Assert.AreEqual(118, acualResult);

        }
        [Test]
        public void TestNumberSubtract()
        {
            string testExpression = "100-20";

            int acualResult = expressionParser.Parse(testExpression);


            Assert.AreEqual(80, acualResult);

        }
        [Test]
        public void TestNumberSubtractAdd()
        {
            string testExpression = "20+80+35-100-40";

            int acualResult = expressionParser.Parse(testExpression);


            Assert.AreEqual(35, acualResult);

        }
    }
}
