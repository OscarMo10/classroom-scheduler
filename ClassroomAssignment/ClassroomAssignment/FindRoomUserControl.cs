using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassroomAssignment.Model;
using ClassroomAssignment.Model.Repo;
using System.Collections;

namespace ClassroomAssignment
{

    public partial class FindRoomUserControl : UserControl
    {
        //hardcoded course repo 
        private Repo.HardCodedCourseRepo myhardCodedCourseRepo = new Repo.HardCodedCourseRepo();
        private List<Course> myCourses;
        private List<Course> results;
        
        public FindRoomUserControl()
        {
            InitializeComponent();
        }

        private void FindRoomButton1_Click(object sender, EventArgs e)
        {
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*
           if(myCourses != null)
           {

               //return results of class. 
               IEnumerable results = myCourses.Where(x => x.RoomAssignment == "PKI 157");


               //iterate and print text
               foreach(Course x in results)
               {

                   textBox1.Text = x.RoomAssignment;
                   //textBox1.Text = x.CourseName;
                   //textBox1.Text = x.MeetingPattern;
               }
             else
               {
               textBox1.Text = "no Text!";
              }

           */
        }





    }
}
