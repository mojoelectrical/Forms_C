
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.processBtn = new System.Windows.Forms.Button();
            this.eventCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rowCB = new System.Windows.Forms.ComboBox();
            this.seatCB = new System.Windows.Forms.ComboBox();
            this.ticketpriceCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // processBtn
            // 
            this.processBtn.Location = new System.Drawing.Point(1074, 1122);
            this.processBtn.Name = "processBtn";
            this.processBtn.Size = new System.Drawing.Size(414, 221);
            this.processBtn.TabIndex = 0;
            this.processBtn.Text = "Process Request";
            this.processBtn.UseVisualStyleBackColor = true;
            this.processBtn.Click += new System.EventHandler(this.processBtn_Click);
            // 
            // eventCB
            // 
            this.eventCB.FormattingEnabled = true;
            this.eventCB.Location = new System.Drawing.Point(756, 223);
            this.eventCB.Name = "eventCB";
            this.eventCB.Size = new System.Drawing.Size(858, 37);
            this.eventCB.TabIndex = 1;
            this.eventCB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(953, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Which event would you like to purchase tickets?";
            // 
            // rowCB
            // 
            this.rowCB.FormattingEnabled = true;
            this.rowCB.Location = new System.Drawing.Point(648, 671);
            this.rowCB.Name = "rowCB";
            this.rowCB.Size = new System.Drawing.Size(429, 37);
            this.rowCB.TabIndex = 3;
            this.rowCB.SelectedIndexChanged += new System.EventHandler(this.rowCB_SelectedIndexChanged);
            // 
            // seatCB
            // 
            this.seatCB.FormattingEnabled = true;
            this.seatCB.Location = new System.Drawing.Point(1465, 671);
            this.seatCB.Name = "seatCB";
            this.seatCB.Size = new System.Drawing.Size(491, 37);
            this.seatCB.TabIndex = 4;
            // 
            // ticketpriceCB
            // 
            this.ticketpriceCB.FormattingEnabled = true;
            this.ticketpriceCB.Location = new System.Drawing.Point(1037, 867);
            this.ticketpriceCB.Name = "ticketpriceCB";
            this.ticketpriceCB.Size = new System.Drawing.Size(577, 37);
            this.ticketpriceCB.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(784, 587);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Row Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(976, 497);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(538, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select Seat and Row number and Ticket Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1684, 586);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Seat Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1246, 770);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ticket Price:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(3844, 2113);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ticketpriceCB);
            this.Controls.Add(this.seatCB);
            this.Controls.Add(this.rowCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eventCB);
            this.Controls.Add(this.processBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button processBtn;
        private System.Windows.Forms.ComboBox eventCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox rowCB;
        private System.Windows.Forms.ComboBox seatCB;
        private System.Windows.Forms.ComboBox ticketpriceCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

