using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opgave1Football;

namespace TestOpgave1Football
{
    [TestClass]
    public class UnitTest1
    {
        //TestMethod for the "ID" property on the FootballPlayer Class
        [TestMethod]
        public void TestID()
        {
            //Creates 3 objects of the FootballPlayer Class
            FootballPlayer footballPlayer1 = new FootballPlayer(1, "Søren", 500, 50);
            FootballPlayer footballPlayer2 = new FootballPlayer(2, "Anders", 500, 50);
            FootballPlayer footballPlayer3 = new FootballPlayer(3, "Martin", 500, 50);

            //Checks if the ID of each object is Different
            Assert.IsFalse(footballPlayer1.ID == footballPlayer2.ID);
            Assert.IsFalse(footballPlayer1.ID == footballPlayer3.ID);

            //Try to create a FootballPlayer with an existing ID
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() =>
            {
                FootballPlayer footballPlayer3 = new FootballPlayer(1, "Anders", 500, 50);
            });
        }



        //TestMethod for the "Name" property on the FootballPlayer Class
        [TestMethod]
        public void TestName()
        {
            //Creates 2 Correct Names ("footballPlayer1" has a name on the Lower limit for Name length)(There is no upper limit)
            FootballPlayer footballPlayer1 = new FootballPlayer(4, "Lars", 500, 50);
            FootballPlayer footballPlayer2 = new FootballPlayer(5, "Anders", 500, 50);

            //Checks if the 2 objects are NOT null (eg. they are valid)
            Assert.IsNotNull(footballPlayer1);
            Assert.IsNotNull(footballPlayer2);

            //The Name on this one is too short, and will throw an exception
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() =>
            {
                FootballPlayer footballPlayer3 = new FootballPlayer(6, "A", 500, 50);
            });
        }



        //TestMethod for the "Price" property on the FootballPlayer Class
        [TestMethod]
        public void TestPrice()
        {
            //Creates 2 Correct Prices ("footballPlayer1" has a Price on the Lower limit for price)(There is no Upper limit)
            FootballPlayer footballPlayer1 = new FootballPlayer(7, "Søren", 1, 50);
            FootballPlayer footballPlayer2 = new FootballPlayer(8, "Anders", 666, 50);

            //Checks if the 2 objects are NOT null (eg. they are valid)
            Assert.IsNotNull(footballPlayer1);
            Assert.IsNotNull(footballPlayer2);

            //The Price on this on is an invalid number, and will throw an exception
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() =>
            {
                FootballPlayer footballPlayer3 = new FootballPlayer(9, "Martin", -666, 50);
            });
        }



        //TestMethod for the "ShirtNumber" property on the FootballPlayer Class
        [TestMethod]
        public void TestShirtNumber()
        {
            //Creates 3 Correct Prices ("footballPlayer1" has a Number on the Lower limit for ShirtNumber, and "footballPlayer 3" has a Number on the Upper limit)
            FootballPlayer footballPlayer1 = new FootballPlayer(10, "Søren", 500, 1);
            FootballPlayer footballPlayer2 = new FootballPlayer(11, "Anders", 500, 50);
            FootballPlayer footballPlayer3 = new FootballPlayer(12, "Martin", 500, 100);

            //The Number on the next one is below the Lower Limit, and will throw an exception
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() =>
            {
                FootballPlayer footballPlayer3 = new FootballPlayer(13, "Henning", 500, -5);
            });
            //Same as above, but above the Upper limit, will also throw an exception
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() =>
            {
                FootballPlayer footballPlayer3 = new FootballPlayer(14, "Peter", 500, 666);
            });
        }
    }
}
