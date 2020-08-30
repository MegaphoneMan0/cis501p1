using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alarmClock
{
    public partial class Alarm501 : Form
    {
        public Alarm501()
        {
            InitializeComponent();




        }

        private void plusButton_Click(object sender, EventArgs e)
        {


            AddEditAlarm dateTimePicker = new AddEditAlarm();
            
            if(dateTimePicker.ShowDialog() == DialogResult.OK)
            {

                myAlarms.Add(dateTimePicker.thisAlarm);

            }


            
        }//adding an alarm

        BindingList<Alarm> myAlarms;

        private void stopButton_Click(object sender, EventArgs e)
        {
            
        }

        private void snoozeButton_Click(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }
    }//end of form






}
