using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Nathan Robertson
 * Date: 05/09/2018
 */

namespace ClassroomRobots
{
    /// <summary>
    /// The Desk Class.
    /// </summary>
    public class Desk
    {
        /// <summary>
        /// The Desks postion on the X Axis.
        /// </summary>
        public int x;

        /// <summary>
        /// The Desks position on the Y Axis.
        /// </summary>
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
