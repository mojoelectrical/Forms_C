using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    //301110711
    class Ticket
    {
        private int seat;
        private string row;
        private string eventDateTime;
        private string eventName;
        private string eventLocation;
        private double ticketCost;

        public Ticket() { }

        public Ticket(int seat, string row, string eventDateTime, string eventName, string eventLocation, double ticketCost):this() {
            this.seat = seat;
            this.row = row;
            this.eventDateTime = eventDateTime;
            this.eventName = eventName;
            this.eventLocation = eventLocation;
            this.ticketCost = ticketCost;
        }

        public Ticket(int seat, string row, string eventDateTime, string eventName, double ticketCost):this()
        {
            this.seat = seat;
            this.row = row;
            this.eventDateTime = eventDateTime;
            this.eventName = eventName;
            this.ticketCost = ticketCost;
        }

        public Ticket(string row, string eventDateTime, string eventName, double ticketCost):this()
        {
            this.row = row;
            this.eventDateTime = eventDateTime;
            this.eventName = eventName;
            this.ticketCost = ticketCost;
        }

        public Ticket(string row, string eventDateTime, double ticketCost):this()
        {
            this.row = row;
            this.eventDateTime = eventDateTime;
            this.ticketCost = ticketCost;
        }

        public Ticket(string row, string eventDateTime):this()
        {
            this.row = row;
            this.eventDateTime = eventDateTime;
        }


        public int Seat { get { return seat; } set { seat = value; } }

        public string EventDateTime { get {return eventDateTime; } set {eventDateTime = value; } }
        
        public string EventName { get {return eventName; } set{ this.eventName = value; } }
        
        public string EventLocation { get {return eventLocation; } set {this.eventLocation = value; } }

        public double TicketCost { get {return this.ticketCost; } set { this.ticketCost = value; } }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
