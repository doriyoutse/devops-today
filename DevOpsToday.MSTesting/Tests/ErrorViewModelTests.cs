using Microsoft.CSharp

namespace DevOpsToday.MSTesting.Tests
{

    public class ErrorViewModelTests
    {
        [TestMethod]

        public void Test_ShowRequestIdMethod()
        {
            var sut = new ErrorViewModelTests(){RequestId = "Dori"};

            Assert.IsTrue(sut.ShowRequestIdMethod);

        }
    }
}