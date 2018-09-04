﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomRobots
{
    /// <summary>
    /// The Student class.
    /// </summary>
    public class Student
    {
        //The students name.
        public string name;
        public int x;
        public int y;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="name">The Students name.</param>
        /// <param name="x">The Students X</param>
        /// <param name="y">The Students Y</param>
        public Student(string name, int x, int y)
        {
            //Set the students variables.
            this.name = name;
            this.x = x;
            this.y = y;
        }
    }
}