using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    namespace WindowsFormsApp2
    {
        public class MusicalEvent : Ticket
        {

            private string performerName;
            private bool memoriabilityOnSale;
            private bool backStageOffered;
            private bool signsAutographAvailable;

            public MusicalEvent() : base() { }


            public MusicalEvent(string performerName, string row, string eventDateTime, string eventName, double ticketCost) : base(row, eventDateTime, eventName, ticketCost)
            {
                this.performerName = performerName;
            }
            public MusicalEvent(string performerName, string row, string eventDateTime, string eventName, bool memoriabilityOnSale, bool backStageOffered, bool signsAutographAvailable, double ticketCost) : base(row, eventDateTime, eventName, ticketCost)
            {

                this.performerName = performerName;
                this.memoriabilityOnSale = memoriabilityOnSale;
                this.backStageOffered = backStageOffered;
                this.signsAutographAvailable = signsAutographAvailable;

            }


            public string PerformerName { get { return this.performerName; } set { this.performerName = value; } }

            public bool MemoriabilityOnSale { get { return this.memoriabilityOnSale; } set { this.memoriabilityOnSale = value; } }
            public bool BackStageOffered { get { return this.backStageOffered; } set { this.backStageOffered = value; } }

            public bool SignsAutographAvailable { get { return this.signsAutographAvailable; } set { this.signsAutographAvailable = value; } }

            public override string ToString()
            {
                return base.ToString() + $"\nPerformer Name:{performerName}\nMemoriability:{memoriabilityOnSale}\n BackStage:{backStageOffered}\n Autograph Signings:{signsAutographAvailable}";


            }

        }
    }


