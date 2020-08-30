using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms.Design;

namespace alarmClock
{
    public class Alarm
    {

        private bool status; //this determines if the alarm is on(true) or off(false)

        private DateTime alarmTime;


        public Alarm()
        {

            status = false;
            


        }//default constructor




        public Alarm(DateTime dt)
        {

            alarmTime = dt;


        }//filled constructor




        public void setTime(DateTime dt)
        {

            alarmTime = dt;

            

        }//set the time for this alarm





        public void turnOn()
        {
            status = true;
        }//turns the alarm on

        public void turnOff()
        {
            status = false;
        }//turns the alarm off



    

        public bool getStatus()
        {
            return status;
        }//returns the status off(false) or on (true)


    }
}
