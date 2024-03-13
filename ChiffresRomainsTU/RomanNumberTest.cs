using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumbers;

namespace RomanNumbersTU
{
    [TestClass]
    public class RomanNumberTest
    {
        [TestMethod]
        public void GenerateRomanNumber_1()
        {
            const string expectedValue = "I";
            var actValue = new RomanNumber(1).Generate();
            Assert.AreEqual(expectedValue, actValue);
        }

        [TestMethod]
        public void GenerateRomanNumber_2()
        {
            const string expectedValue = "II";
            var actValue = new RomanNumber(2).Generate();
            Assert.AreEqual(expectedValue, actValue);
        }

        [TestMethod]
        public void GenerateRomanNumber_3()
        {
            const string expectedValue = "III";
            var actValue = new RomanNumber(3).Generate();
            Assert.AreEqual(expectedValue, actValue);
        }

        [TestMethod]
        public void GenerateRomanNumber_4()
        {
            const string expectedValue = "IV";
            var actValue = new RomanNumber(4).Generate();
            Assert.AreEqual(expectedValue, actValue);
        }

        [TestMethod]
        public void GenerateRomanNumber_5()
        {
            const string expectedValue = "V";
            var actValue = new RomanNumber(5).Generate();
            Assert.AreEqual(expectedValue, actValue);
        }

        [TestMethod]
        public void GenerateRomanNumber_6()
        {
            const string expectedValue = "VI";
            var actValue = new RomanNumber(6).Generate();
            Assert.AreEqual(expectedValue, actValue);
        }

        [TestMethod]
        public void GenerateRomanNumber_7()
        {
            const string expectedValue = "VII";
            var actValue = new RomanNumber(7).Generate();
            Assert.AreEqual(expectedValue, actValue);
        }

        [TestMethod]
        public void GenerateRomanNumber_8()
        {
            const string expectedValue = "VIII";
            var actValue = new RomanNumber(8).Generate();
            Assert.AreEqual(expectedValue, actValue);
        }

        [TestMethod]
        public void GenerateRomanNumber_9()
        {
            const string expectedValue = "IX";
            var actValue = new RomanNumber(9).Generate();
            Assert.AreEqual(expectedValue, actValue);
        }

        [TestMethod]
        public void GenerateRomanNumber_10()
        {
            const string expectedValue = "X";
            var actValue = new RomanNumber(10).Generate();
            Assert.AreEqual(expectedValue, actValue);
        }

        [TestMethod]
        public void GenerateRomanNumber_11()
        {
            const string expectedValue = "XI";
            var actValue = new RomanNumber(11).Generate();
            Assert.AreEqual(expectedValue, actValue);
        }

        [TestMethod]
        public void GenerateRomanNumber_12()
        {
            const string expectedValue = "XII";
            var actValue = new RomanNumber(12).Generate();
            Assert.AreEqual(expectedValue, actValue);
        }

        [TestMethod]
        public void GenerateRomanNumber_14()
        {
            const string expectedValue = "XIV";
            var actValue = new RomanNumber(14).Generate();
            Assert.AreEqual(expectedValue, actValue);
        }

        [TestMethod]
        public void GenerateRomanNumber_50()
        {
            const string expectedValue = "L";
            var actValue = new RomanNumber(50).Generate();
            Assert.AreEqual(expectedValue, actValue);
        }

        [TestMethod]
        public void GenerateRomanNumber_15()
        {
            const string expectedValue = "XV";
            var actValue = new RomanNumber(15).Generate();
            Assert.AreEqual(expectedValue, actValue);
        }

        [TestMethod]
        public void GenerateRomanNumber_54()
        {
            const string expectedValue = "LIV";
            var actValue = new RomanNumber(54).Generate();
            Assert.AreEqual(expectedValue, actValue);
        }

        [TestMethod]
        public void GenerateRomanNumber_80()
        {
            const string expectedValue = "LXXX";
            var actValue = new RomanNumber(80).Generate();
            Assert.AreEqual(expectedValue, actValue);
        }

        [TestMethod]
        public void GenerateRomanNumber_90()
        {
            const string expectedValue = "XC";
            var actValue = new RomanNumber(90).Generate();
            Assert.AreEqual(expectedValue, actValue);
        }

        [TestMethod]
        public void GenerateRomanNumber_100()
        {
            const string expectedValue = "C";
            var actValue = new RomanNumber(100).Generate();
            Assert.AreEqual(expectedValue, actValue);
        }

        [TestMethod]
        public void GenerateRomanNumber_119()
        {
            const string expectedValue = "CXIX";
            var actValue = new RomanNumber(119).Generate();
            Assert.AreEqual(expectedValue, actValue);
        }

        [TestMethod]
        public void GenerateRomanNumber_199()
        {
            const string expectedValue = "CXCIX";
            var actValue = new RomanNumber(199).Generate();
            Assert.AreEqual(expectedValue, actValue);
        }

        [TestMethod]
        public void GenerateRomanNumber_500()
        {
            const string expectedValue = "D";
            var actValue = new RomanNumber(500).Generate();
            Assert.AreEqual(expectedValue, actValue);
        }

        [TestMethod]
        public void GenerateRomanNumber_1000()
        {
            const string expectedValue = "M";
            var actValue = new RomanNumber(1000).Generate();
            Assert.AreEqual(expectedValue, actValue);
        }

        [TestMethod]
        public void GenerateRomanNumber_3650()
        {
            const string expectedValue = "MMMDCL";
            var actValue = new RomanNumber(3650).Generate();
            Assert.AreEqual(expectedValue, actValue);
        }

        [TestMethod]
        public void GenerateRomanNumber_4000()
        {
            const string expectedValue = "I\u0305V\u0305";
            var actValue = new RomanNumber(4000).Generate();
            Assert.AreEqual(expectedValue, actValue);
        }

        [TestMethod]
        public void GenerateRomanNumber_5000()
        {
            const string expectedValue = "V\u0305";
            var actValue = new RomanNumber(5000).Generate();
            Assert.AreEqual(expectedValue, actValue);
        }

        [TestMethod]
        public void GenerateRomanNumber_5555()
        {
            const string expectedValue = "V̅D\u0305L\u0305V\u0305";
            var actValue = new RomanNumber(5555).Generate();
            Assert.AreEqual(expectedValue, actValue);
        }

        [TestMethod]
        public void GenerateRomanNumber_8000()
        {
            const string expectedValue = "V\u0305I\u0305I\u0305I\u0305";
            var actValue = new RomanNumber(8000).Generate();
            Assert.AreEqual(expectedValue, actValue);
        }

        [TestMethod]
        public void GenerateRomanNumber_8352()
        {
            const string expectedValue = "V\u0305I\u0305I\u0305I\u0305C\u0305C\u0305C\u0305L\u0305I\u0305I\u0305";
            var actValue = new RomanNumber(8352).Generate();
            Assert.AreEqual(expectedValue, actValue);
        }

        [TestMethod]
        public void GenerateRomanNumber_9000()
        {
            const string expectedValue = "I\u0305X\u0305";
            var actValue = new RomanNumber(9000).Generate();
            Assert.AreEqual(expectedValue, actValue);
        }

        [TestMethod]
        public void GenerateRomanNumber_10000()
        {
            const string expectedValue = "X\u0305";
            var actValue = new RomanNumber(10000).Generate();
            Assert.AreEqual(expectedValue, actValue);
        }
    }
}
