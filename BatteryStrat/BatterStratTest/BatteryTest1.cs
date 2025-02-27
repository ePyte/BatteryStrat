using BatteryStrat;

namespace BatterStratTest
{
    [TestClass]
    public class BatteryTest1
    {
        [TestMethod]
        public void TestLow()
        {
            StringWriter writer = new StringWriter();
            Console.SetOut(writer);

            Context context = new Context();
            context.SetStrategy(new LowBattery());
            context.PerformOperations();

            Assert.AreEqual("Battery percentage is low!\r\nChanging backlight to 10%.\r\n", writer.ToString());
        }

        [TestMethod]
        public void TestMedium()
        {
            StringWriter writer = new StringWriter();
            Console.SetOut(writer);

            Context context = new Context();
            context.SetStrategy(new MediumBattery());
            context.PerformOperations();

            Assert.AreEqual("Battery percentage is OK!\r\nChanging backlight to 50%.\r\n", writer.ToString());
        }

        [TestMethod]
        public void TestHigh()
        {
            StringWriter writer = new StringWriter();
            Console.SetOut(writer);

            Context context = new Context();
            context.SetStrategy(new HighBattery());
            context.PerformOperations();

            Assert.AreEqual("Battery percentage is excellent!\r\nChanging backlight to 100%.\r\n", writer.ToString());
        }
    }
}