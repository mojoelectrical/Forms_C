using System;
using System.Collections.Generic;
using System.Text;


namespace ClassLibrary1
{
    class Lecture : Ticket
    {
        private bool projectionNeeded;
        private string lectureTopic;

        public Lecture():base() { }

        public Lecture(int seat, string row, string eventDateTime, string eventName, string eventLocation, double ticketCost):base(seat,row,eventDateTime,eventName,eventLocation,ticketCost)
            {

            }
        public Lecture(int seat, string row, string eventDateTime, string eventName, string eventLocation, bool projectionNeeded, string lectureTopic, double ticketCost) : base(seat, row, eventDateTime, eventName, eventLocation, ticketCost) 
        {
            this.projectionNeeded = projectionNeeded;
            this.lectureTopic = lectureTopic;
        }

        public Lecture(string row, string eventDateTime, string lectureTopic) : base(row,eventDateTime) {
            this.lectureTopic = lectureTopic;
        
        }

        public bool ProjectionNeeded { get { return projectionNeeded; } set {projectionNeeded= value; } }

        public string LectureTopic { get {return lectureTopic; } set {lectureTopic = value } }

        public override string ToString()
        {
            return base.ToString();
        }





    }
}
