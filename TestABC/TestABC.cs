namespace TestABC
{
    [TestClass]
    public class TestABC
    {
        private ABC.C c = new ABC.C();
        private ABC.B b = new ABC.B();
        private ABC.A a = new ABC.A();

        [TestMethod]
        public void TestA()
        {
            Assert.AreEqual("Coucou je suis A", a.ToString());
        }

        [TestMethod]
        public void TestB()
        {
            Assert.AreEqual("Coucou je suis A, et B", b.ToString());
        }
        
        [TestMethod]
        public void TestC()
        {
            Assert.AreEqual("Je suis malade avec un certificat!", c.ToString());
        }
    }
}