using testesonarqube.Controllers;

namespace TestProject2
{
    public class UnitTest1
    {
        private readonly testController controller;

        public UnitTest1( )
        {
            this.controller = new testController();
        }

        [Fact]
        public void Test1()
        {
           var result= controller.BugTeste();
            Assert.Equal(2,result);
        }
    }
}