namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            WebApp mayor=new WebApp();

            int result= mayor.ObtenerMayor(10, 5, 2);
            Assert.Equal(10, result);

        }

        [Fact]
        public void Test2()
        {
            WebApp mayor = new WebApp();
            int result = mayor.ObtenerMayor(90, 340, 28);
            Assert.Equal(340, result);
        }

        [Fact]
        public void Test3()
        {
            WebApp mayor = new WebApp();
            int result = mayor.ObtenerMayor(90, 340, 500);
            Assert.Equal(500, result);
        }
    }
}
