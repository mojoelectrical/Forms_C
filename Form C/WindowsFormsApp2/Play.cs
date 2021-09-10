using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp2
{
    class Play:Ticket
    {


        private bool refreshmentsServed;
        private int numberOfActors;
        private string playSpecificInfo;


        public Play() : base() { }

        public Play(int seat, string row, string eventDateTime, string eventName, string eventLocation, int numberOfActors, string playSpecificInfo, double ticketCost) : base(seat, row, eventDateTime, eventName, eventLocation, ticketCost) 
        {

            this.numberOfActors = numberOfActors;
            this.playSpecificInfo = playSpecificInfo;
        
        }

        public Play(int seat, string row, string eventDateTime, string eventName, string eventLocation, bool refreshmentsServed, int numberOfActors, string playSpecificInfo, double ticketCost) : base(seat, row, eventDateTime, eventName, eventLocation, ticketCost)
        {

            this.numberOfActors = numberOfActors;
            this.playSpecificInfo = playSpecificInfo;
            this.refreshmentsServed = refreshmentsServed;
        }

        public bool RefreshmentsServed { get {return this.refreshmentsServed; } set { this.refreshmentsServed = value; } }
        public int NumberOfActors { get {return this.numberOfActors; } set { this.numberOfActors = value; } }

        public string PlaySpecificInfo { get { return this.playSpecificInfo; } set { this.playSpecificInfo = value; } }

        public override string ToString()
        {
           // int seat, string row, string eventDateTime, string eventName, string eventLocation, int numberOfActors, string playSpecificInfo, double ticketCost)
            return $"Seat:{base.Seat} \n Row:{base.Row}\nDate:{base.EventDateTime}\nName of Event:{base.EventName}\nLocation:{base.EventLocation}\nActors amount:{numberOfActors}\nInfo:{playSpecificInfo}\nCost{base.TicketCost}";
        }

    }
}
