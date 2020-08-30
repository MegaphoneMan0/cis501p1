using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace alarmClock
{



    public partial class AddEditAlarm : Form
    {



        public Alarm thisAlarm = new Alarm();




        public AddEditAlarm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            DateTime alarmTime = dateTimePicker1.Value;

            thisAlarm.setTime(alarmTime);

            if(onOffButton.Checked == true)
            {
                thisAlarm.turnOn();
            }
            else
            {
                thisAlarm.turnOff();
            }



        }
    }
}
