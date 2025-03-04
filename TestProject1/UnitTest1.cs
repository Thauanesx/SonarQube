
using testesonarqube.Controllers;

namespace TestProject1
{
    public class UnitTest1
    {
        private readonly testController controller=new testController();
          [Fact]
        public void Test1()
        {
            var a = controller.Index();
            Assert.NotNull(a); 
        } 
    }
}
