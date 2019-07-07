using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MarsRoverProject.Enums;

namespace MarsRoverProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var mapDimension = Console.ReadLine().Trim().Split(' ').ToList();
            var startPoint = Console.ReadLine().Trim().Split(' ');
            Rover r = new Rover();

            if (startPoint.Count() == 3)
            {
                r.SetRover(Convert.ToInt32(startPoint[0]), //x
                           Convert.ToInt32(startPoint[1]), //y
                          (Directions)Enum.Parse(typeof(Directions), startPoint[2])); //direction
            }
            r.Route = Console.ReadLine();
            r.MoveProgress();
            r.RoverStatus();
        }
    }
}
