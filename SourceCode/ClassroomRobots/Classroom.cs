using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomRobots
{
    /// <summary>
    /// The Classroom Class.
    /// </summary>
    public class Classroom
    {
        /// <summary>
        /// The name of the teacher.
        /// </summary>
        public string teacher;

        /// <summary>
        /// The name of the class.
        /// </summary>
        public string className;

        /// <summary>
        /// The room number.
        /// </summary>
        public string roomNumber;

        /// <summary>
        /// A list of students in the class.
        /// </summary>
        public List<Student> students;

        /// <summary>
        /// The layout of the classroom.
        /// </summary>
        public List<Desk> desks = new List<Desk>();

        /// <summary>
        /// The size of the classrooom
        /// </summary>
        public int size = 5;

        /// <summary>
        /// New Classroom.
        /// </summary>
        /// <param name="teacher"></param>
        /// <param name="className"></param>
        /// <param name="roomNumber"></param>
        public Classroom(string teacher, string className, string roomNumber, int size)
        {
            //Set the Teachers Name.
            this.teacher = teacher;

            //Set the Class Name.
            this.className = className;

            //Set the Room Number.
            this.roomNumber = roomNumber;

            //Set the Room Size.
            this.size = size;

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
