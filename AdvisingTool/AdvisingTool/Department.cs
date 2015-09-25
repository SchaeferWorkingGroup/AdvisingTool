using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvisingTool
{
    class Department
    {
        private string department_name;
        LinkedList<Course> courses;

        public Department()
        {
            courses = new LinkedList<Course>(courses);

        }

        public void AddCourses(int course_number, int section_number, string course_name, string course_description)
        {
            //adds courses into linked list from file
        }

        private void DeleteCourse(string course_name)
        {
            //deletes course by course name
        }

        private void DeleteCourse (int course_number)
        {
            //deletes course by course number
        }


    /*
        public Course SearchCourse(string course_name)
        {
            Course searched_course;
            //search courses by name
            return searched_course;
        }

        public Course SearchCourse(int course_number)
        {
            Course searched_course;
            //search course by number
            return searched_course;
        }
        */

    }
}
