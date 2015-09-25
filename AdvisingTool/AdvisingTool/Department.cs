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

        public void AddCourse(int course_number, int section_number, int course_hours, int course_type, string course_name, string course_description, LinkedList<Course> prereq)
        {
            Course new_course;

            //adds course into linked list without prereq
            if (prereq == null)
            {
                new_course = new Course(course_number, section_number, course_hours, course_type, course_name, course_description);
                courses.AddLast(new_course);
            }

            //adds course into linked list with prereq
            else
            {
                new_course = new Course(course_number, section_number, course_hours, course_type, course_name, course_description, prereq);
                courses.AddLast(new_course);
            }
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
