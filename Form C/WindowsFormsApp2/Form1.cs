
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    //MichaelAsafo #301110711
    //Richard Hickey #301188051
    public partial class Form1 : Form
    {
       Lecture clubager;

        List<Play> PlaysL = new List<Play>();
        List<Lecture> LecturesL = new List<Lecture>();
        List<MusicalEvent> MusicalEventsL = new List<MusicalEvent>();
        BindingSource swimmerBind = new BindingSource();
        BindingSource clubBind = new BindingSource();
        
        public Form1()
        {
            InitializeComponent();
            PlaysL = new List<Play>();
            LecturesL = new List<Lecture>();
            MusicalEventsL = new List<MusicalEvent>();

            eventCB.Items.Add("Play");
            eventCB.Items.Add("Musical Events");
            eventCB.Items.Add("Lecture");

            rowCB.Items.Add("A");
            rowCB.Items.Add("B");
            rowCB.Items.Add("C");
            rowCB.Items.Add("D");
            rowCB.Items.Add("E");
            rowCB.Items.Add("F");
            rowCB.Items.Add("G");
            rowCB.Items.Add("H");
            rowCB.Items.Add("I");

            seatCB.Items.Add(1);
            seatCB.Items.Add(2);
            seatCB.Items.Add(3);
            seatCB.Items.Add(4);
            seatCB.Items.Add(5); 
            seatCB.Items.Add(6);
            seatCB.Items.Add(7);
            seatCB.Items.Add(8);
            seatCB.Items.Add(9);
            seatCB.Items.Add(10);

            ticketpriceCB.Items.Add("50");
            ticketpriceCB.Items.Add("100");
            ticketpriceCB.Items.Add("150");
            ticketpriceCB.Items.Add("200");



        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void processBtn_Click(object sender, EventArgs e)
        {
            //int seat, string row, string eventDateTime, string eventName, string eventLocation, int numberOfActors, string playSpecificInfo, double ticketCost
            if (eventCB.Text == "Play") {

                int n = Convert.ToInt32(seatCB.Text);
                Play new_play = new Play(Convert.ToInt32(seatCB.Text),rowCB.Text,"Place","New Place", "New Location", 34,"Info", Double.Parse(ticketpriceCB.Text));
                PlaysL.Add(new_play);
                MessageBox.Show(new_play.ToString());
                
            }

            if (eventCB.Text == "Musical Events") {
                int n = Convert.ToInt32(seatCB.Text);
                //string performerName, string row, string eventDateTime, string eventName, bool memoriabilityOnSale, bool backStageOffered, bool signsAutographAvailable, double ticketCost) : base(row, eventDateTime, eventName, ticketCost)
                MusicalEvent new_musical = new MusicalEvent("Rocky", rowCB.Text, "Place", "New Place",true, false, true, Double.Parse(ticketpriceCB.Text));
                new_musical.Seat = n;
                MusicalEventsL.Add(new_musical);
                MessageBox.Show(new_musical.ToString());

            }

            if (eventCB.Text == "Lecture"){
                //int seat, string row, string eventDateTime, string eventName, string eventLocation, bool projectionNeeded, string lectureTopic, double ticketCost
                int n = Convert.ToInt32(seatCB.Text);
                Lecture new_lecture = new Lecture(n, rowCB.Text, "2020/06/23", "School", "Toronto", false, "Programming", Double.Parse(ticketpriceCB.Text));
               
                LecturesL.Add(new_lecture);
                MessageBox.Show(new_lecture.ToString());

            }
        }

        private void rowCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
