using MarsRoverChallenge;
using NUnit.Framework;

namespace MarsRoverTestProject
{
    public class RoverShould
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TurnLeft()
        {
            // X = 3, Y = 2 & Direction = South
            Rover roverObj = new Rover(3,2,"S");
            roverObj.TurnLeft(); // Turn left
            Assert.AreEqual(roverObj.Direction,"E"); // new postion should be facing East
        }

        [Test]
        public void TurnRight()
        {
            // X = 3, Y = 2 & Direction = South
            Rover roverObj = new Rover(3, 2, "S");
            roverObj.TurnRight(); // Turn Right
            Assert.AreEqual(roverObj.Direction, "W"); // new postion should be facing West
        }

        [Test]
        public void Move()
        {
            // X = 0, Y = 0 & Direction = North
            Rover roverObj = new Rover(0, 0, "N");
            roverObj.Move(); // X = 0, Y = 1
            Assert.AreEqual(roverObj.PostionX, 0);
            Assert.AreEqual(roverObj.PositionY, 1);
        }

        [Test]
        public void FollowInstruction()
        {
            // X = 0, Y = 0 & Direction = North
            Rover roverOne = new Rover(1, 2, "N");
            roverOne.FollowIntruction("LMLMLMLMM");
            Assert.AreEqual(roverOne.PostionX, 1); // X = 1
            Assert.AreEqual(roverOne.PositionY, 3); // Y = 3
            Assert.AreEqual(roverOne.Direction, "N"); // Direction = N

            // X = 0, Y = 0 & Direction = North
            Rover roverTwo = new Rover(3, 3, "E");
            roverTwo.FollowIntruction("MMRMMRMRRM");
            Assert.AreEqual(roverTwo.PostionX, 5); // X = 5
            Assert.AreEqual(roverTwo.PositionY, 1); // Y = 1
            Assert.AreEqual(roverTwo.Direction, "E"); // Direction = E
        }
    }
}