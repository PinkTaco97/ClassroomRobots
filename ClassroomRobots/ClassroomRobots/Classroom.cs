using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomRobots
{
    class Classroom
    {
        //The name of the teacher.
        public string teacher;

        //The name of the class.
        public string className;

        //The room number.
        public string roomNumber;

        //A list of students in the class.
        public List<Student> students;

        /// <summary>
        /// Constructor.
        /// </summary>
        public Classroom(string teacher, string className, string roomNumber)
        {
            //Set the Teachers Name.
            this.teacher = teacher;

            //Set the Class Name.
            this.className = className;

            //Set the Room Number.
            this.roomNumber = roomNumber;
        }
    }
}
