using NUnit.Framework;
using ConsoleApp;

namespace NUnitTest_Uzduotis_13
{
    public class Tests
    {
        [Test]
        public void TestIf995IsDivisibleBy3WithoutRemainder()
        {
            bool expectedResult = true;
            bool actualResult = Uzduotis13.Is995DivisibleBy3WithoutRemainder();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestIfTodayIsWednesday()
        {
            bool result = Uzduotis13.IsTodayWednesday();
            Assert.IsTrue(result);
        }

        [Test]
        public void TestIfNowIs13h()
        {
            bool result = Uzduotis13.IsNow13h();
            Assert.IsTrue(result);
        }

        [Test]
        public void TestIfThereAre4EvenNumbersInRange1To10()
        {
            bool result = Uzduotis13.AreThere4EvenNumbersInRange1To10();
            Assert.IsTrue(result);
        }
    }
}
