namespace TestABC
{
    [TestClass]
    public class TestABC
    {
        private ABC.C c = new ABC.C();
        private ABC.B b = new ABC.B();
        private ABC.A a = new ABC.A();
        private ABC.D d = new ABC.D();

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

        [TestMethod]
        public void TestOpenDayA()
        {
            Assert.AreEqual("Les portes ouverte du CPNV sont le " + DateTime.Today.ToString(), a.OpenDay());
        }

        [TestMethod]
        public void TestOpenDayB()
        {
            Assert.AreEqual("Les portes ouverte du CPNV sont le " + DateTime.Today.ToString() + " heu non, dans 2 jours", b.OpenDay());
        }

        [TestMethod]
        public void TestOpenDayC()
        {
            Assert.AreEqual("Les portes ouverte du CPNV sont... bof. je n'y vais pas !", c.OpenDay());
        }

        [TestMethod]
        public void TestOpenDayD()
        {
            Assert.AreEqual("Les portes ouverte du CPNV sont le " + DateTime.Today.ToString() + " et on attend 15'000 personne", d.OpenDay());
        }
    }
}