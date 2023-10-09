using DiceClass;
namespace TestDado
{
    [TestClass]
    public class TestDado
    {
        [TestMethod]
        public void Corectly_Dado()
        {
            Dice DiceOne = new Dice(6);
            Assert.AreEqual(6, DiceOne.NumFace);
        }

        [TestMethod]
        public void InCorectly_Dado()
        {
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => { Dice dadoUno = new Dice(3);}) ;
        }
        
    }
}