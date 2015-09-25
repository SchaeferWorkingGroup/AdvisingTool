using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvisingTool
{
    class Course
    {
        private int course_number;
        private int section_number;
        private int course_hours;
        private string course_type;
        private string course_name;
        private string course_description;
        private LinkedList<Course> prerequisites;

        private readonly string[] coursetype = { "LEC", "IND","RES", "THS", "LAB" };


        //Course constructor without prerequisites
        public Course(int c_number, int s_number, int c_hours, int c_type, string c_name, string c_description)
        {
            course_number = c_number;
            section_number = s_number;
            course_hours = c_hours;
            course_type = coursetype[c_type];
            course_name = c_name;
            course_description = c_description;
        }

        //Course constructor with prerequisites
        public Course(int c_number, int s_number, int c_hours, int c_type, string c_name, string c_description, LinkedList<Course> prereq)
        {
            course_number = c_number;
            section_number = s_number;
            course_hours = c_hours;
            course_type = coursetype[c_type];
            course_name = c_name;
            course_description = c_description;
            prerequisites = prereq;
        }
    }
}
