using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms.Design;

namespace alarmClock
{
    public class alarm
    {

        private bool status; //this determines if the alarm is on(true) or off(false)

        private int hour; //the hour of the alarm
        private int minute; //the minute of the alarm
        private int second; //the second of the alarm

        private bool amPM; //this bool is true if am, false if pm

        public alarm()
        {

            status = false;
            hour = 0;
            minute = 0;
            second = 0;

            amPM = true;

        }//default constructor




        public alarm(int h,int m,int s, bool b)
        {

            hour = h;
            minute = m;
            second = s;

            amPM = b;

        }//filled constructor




        public void setTime(int h, int m, int s, bool b)
        {

            hour = h;
            minute = m;
            second = s;

            amPM = b;

        }//set the time for this alarm





        public void turnOn()
        {
            status = true;
        }//turns the alarm on

        public void turnOff()
        {
            status = false;
        }//turns the alarm off



        public int getHour()
        {
            return hour;
        }//returns the hour

        public int getMinute()
        {
            return minute;
        }//returns the minute
        public int getSecond()
        {
            return second;
        }//returns the second


        public bool getAmPm()
        {
            return amPM;
        }//returns am(true) or pm(false)

        public bool getStatus()
        {
            return status;
        }//returns the status off(false) or on (true)


    }
}
