using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MarsRoverProject.Enums;

namespace MarsRoverProject
{
    /**
     * The Rover class defines the space explorer that will travel to Mars.
     * Each rover object has x, y coordinates, direction, and course. 
     * The properties are defined under the "properties" region.
     * 
     * @SetRover: Used to assign properties to a rover object derived from the main method.
     * @RoverStatus: Prints the information of rover.
     * @TurnLeft-Right: Defines right-left rotation according to the current direction of rover.
     * @MoveProgress: Moves the rover by processing route information entered by engineers in NASA.
     *
     **/
    public class Rover
    {
        #region properties
        private int x;
        private int y;
        private Directions direction;
        private string route;
        #endregion
        public Rover()
        {
            this.x = 0;
            this.y = 0;
            this.direction = Directions.N;
        }

        public void SetRover(int x, int y, Directions direction)
        {
            this.x = x;
            this.y = y;
            this.direction = direction;
        }
        public void RoverStatus()
        {
            Console.WriteLine(x + " " + y + " " + direction);
        }
        public string Route
        {
            get { return route; }
            set { route = value.Trim().ToUpper(); }
        }
        public void TurnLeft()
        {

            switch (direction)
            {
                case Directions.N:
                    this.direction = Directions.W;
                    break;
                case Directions.E:
                    this.direction = Directions.N;
                    break;
                case Directions.S:
                    this.direction = Directions.E;
                    break;
                case Directions.W:
                    this.direction = Directions.S;
                    break;

            }

        }
        public void TurnRight()
        {

            switch (this.direction)
            {
                case Directions.N:
                    this.direction = Directions.E;
                    break;
                case Directions.E:
                    this.direction = Directions.S;
                    break;
                case Directions.S:
                    this.direction = Directions.W;
                    break;
                case Directions.W:
                    this.direction = Directions.N;
                    break;

            }

        }
        public void Forward()
        {
            switch (this.direction)
            {
                case Directions.N:
                    this.y++;
                    break;
                case Directions.E:
                    this.x++;
                    break;
                case Directions.S:
                    this.y--;
                    break;
                case Directions.W:
                    this.x--;
                    break;
            }
        }

        public void MoveProgress()
        {
            foreach (char move in route)
            {
                switch (move)
                {
                    case 'L':
                        TurnLeft();
                        break;
                    case 'R':
                        TurnRight();
                        break;
                    case 'M':
                        Forward();
                        break;
                    default:
                        Console.WriteLine("Wrong Route Parameter!");
                        break;
                }
            }
        }
    }
}
