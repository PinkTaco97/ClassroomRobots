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

        //The layout of the classroom.
        public List<List<Cell>> layout;

        /// <summary>
        /// New Classroom.
        /// </summary>
        /// <param name="teacher"></param>
        /// <param name="className"></param>
        /// <param name="roomNumber"></param>
        public Classroom(string teacher, string className, string roomNumber)
        {
            //Set the Teachers Name.
            this.teacher = teacher;

            //Set the Class Name.
            this.className = className;

            //Set the Room Number.
            this.roomNumber = roomNumber;

            //Setup the list of students.
            this.students = new List<Student>();
        }

        /// <summary>
        /// Classroom with students.
        /// </summary>
        /// <param name="teacher"></param>
        /// <param name="className"></param>
        /// <param name="roomNumber"></param>
        /// <param name="students"></param>
        public Classroom(string teacher, string className, string roomNumber, List<Student> students)
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
