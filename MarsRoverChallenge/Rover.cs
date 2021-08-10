using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverChallenge
{
    /*
     * Starting position for Rover is X = 0, Y = 0, Direction = N
     * Three movements for Rover which is Left. Right. & Move
     * Left == L, Right == R, Move == M
     * On movement Rover spins 90 degree in respective direction
     * Move means forward one point.
     * Rover takes string of input to move forward, turn left & turn right
     */

    public class Rover
    {

        public int PostionX { get; set; }
        public int PositionY { get; set; }
        public string Direction { get; set; }

        // Default position is {0,0,N}
        public Rover(int currentX = 0, int currentY = 0, string currentDirection = "N")
        {
            PostionX = currentX;
            PositionY = currentY;
            Direction = currentDirection;
        }

        public void TurnLeft()
        {
            switch (this.Direction)
            {
                case "N":
                    this.Direction = "W";
                    break;
                case "W":
                    this.Direction = "S";
                    break;
                case "S":
                    this.Direction = "E";
                    break;
                case "E":
                    this.Direction = "N";
                    break;
                default:
                    throw new ArgumentException("Invalid Direction");
            }
        }

        public void TurnRight()
        {
            switch (this.Direction)
            {
                case "N":
                    this.Direction = "E";
                    break;
                case "E":
                    this.Direction = "S";
                    break;
                case "S":
                    this.Direction = "W";
                    break;
                case "W":
                    this.Direction = "N";
                    break;
                default:
                    throw new ArgumentException("Invalid Direction");
            }
        }

        public void Move()
        {
            switch (this.Direction)
            {
                case "N":
                    this.PositionY++;
                    break;
                case "S":
                    this.PositionY--;
                    break;
                case "W":
                    this.PostionX--;
                    break;
                case "E":
                    this.PostionX++;
                    break;
                default:
                    throw new ArgumentException("Invalid Movement");
            }
        }

        public void FollowIntruction(string instrucitons)
        {
            char[] commArray = instrucitons.ToUpper().ToCharArray();
            foreach (var command in commArray)
            {
                switch (command)
                {
                    case 'L':
                        TurnLeft();
                        break;
                    case 'R':
                        TurnRight();
                        break;
                    case 'M':
                        Move();
                        break;
                    default:
                        throw new ArgumentException("Invalid Instruction");
                }
            }
        }
    }
}
