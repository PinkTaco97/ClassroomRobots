using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomRobots
{
    /// <summary>
    /// The Desk Class.
    /// </summary>
    public class Desk
    {
        //The Desks position.
        public int x;
        public int y;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Desk(int x, int y)
        {
            //Set the Desks position.
            this.x = x;
            this.y = y;
        }
    }
}
