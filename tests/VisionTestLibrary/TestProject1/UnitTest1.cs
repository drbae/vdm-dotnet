using NationalInstruments.Vision.Analysis;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        // The below test is a negative test that checks for the exception in case of null image.
        // Add you Tests in similar manner inside this class.
        [Fact]
        public void NegativeTestColorHistogram()
        {
            bool testResult = true;
            try
            {
                Algorithms.ColorHistogram(null);
                testResult = false;
            }
            catch (ArgumentNullException e)
            {
                testResult = true;
            }
            finally
            {
                Assert.True(testResult, "Failed: Expected error as image was null");
            }
        }

    }
}