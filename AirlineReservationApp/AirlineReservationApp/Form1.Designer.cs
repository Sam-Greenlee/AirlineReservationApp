namespace AirlineReservationApp
{
    partial class frmAirlineReservationApp
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
            this.g = new System.Windows.Forms.GroupBox();
            this.rdoKansas = new System.Windows.Forms.RadioButton();
            this.rdoDenver = new System.Windows.Forms.RadioButton();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtDeparture = new System.Windows.Forms.TextBox();
            this.txtPlane = new System.Windows.Forms.TextBox();
            this.txtPassenger = new System.Windows.Forms.TextBox();
            this.txtSeat = new System.Windows.Forms.TextBox();
            this.btnMakeReservation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstFlightSeats = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.g.SuspendLayout();
            this.SuspendLayout();
            // 
            // g
            // 
            this.g.Controls.Add(this.rdoKansas);
            this.g.Controls.Add(this.rdoDenver);
            this.g.Location = new System.Drawing.Point(12, 12);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(150, 139);
            this.g.TabIndex = 0;
            this.g.TabStop = false;
            this.g.Text = "Flight Locations";
            // 
            // rdoKansas
            // 
            this.rdoKansas.AutoSize = true;
            this.rdoKansas.Location = new System.Drawing.Point(7, 67);
            this.rdoKansas.Name = "rdoKansas";
            this.rdoKansas.Size = new System.Drawing.Size(76, 21);
            this.rdoKansas.TabIndex = 1;
            this.rdoKansas.TabStop = true;
            this.rdoKansas.Text = "Kansas";
            this.rdoKansas.UseVisualStyleBackColor = true;
            this.rdoKansas.CheckedChanged += new System.EventHandler(this.rdoKansas_CheckedChanged);
            // 
            // rdoDenver
            // 
            this.rdoDenver.AutoSize = true;
            this.rdoDenver.Location = new System.Drawing.Point(7, 22);
            this.rdoDenver.Name = "rdoDenver";
            this.rdoDenver.Size = new System.Drawing.Size(75, 21);
            this.rdoDenver.TabIndex = 0;
            this.rdoDenver.TabStop = true;
            this.rdoDenver.Text = "Denver";
            this.rdoDenver.UseVisualStyleBackColor = true;
            this.rdoDenver.CheckedChanged += new System.EventHandler(this.rdoDenver_CheckedChanged);
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(488, 12);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.ReadOnly = true;
            this.txtDestination.Size = new System.Drawing.Size(100, 22);
            this.txtDestination.TabIndex = 1;
            // 
            // txtDeparture
            // 
            this.txtDeparture.Location = new System.Drawing.Point(488, 56);
            this.txtDeparture.Name = "txtDeparture";
            this.txtDeparture.ReadOnly = true;
            this.txtDeparture.Size = new System.Drawing.Size(100, 22);
            this.txtDeparture.TabIndex = 2;
            // 
            // txtPlane
            // 
            this.txtPlane.Location = new System.Drawing.Point(488, 97);
            this.txtPlane.Name = "txtPlane";
            this.txtPlane.ReadOnly = true;
            this.txtPlane.Size = new System.Drawing.Size(100, 22);
            this.txtPlane.TabIndex = 3;
            // 
            // txtPassenger
            // 
            this.txtPassenger.Location = new System.Drawing.Point(488, 134);
            this.txtPassenger.Name = "txtPassenger";
            this.txtPassenger.Size = new System.Drawing.Size(100, 22);
            this.txtPassenger.TabIndex = 4;
            // 
            // txtSeat
            // 
            this.txtSeat.Location = new System.Drawing.Point(488, 179);
            this.txtSeat.Name = "txtSeat";
            this.txtSeat.Size = new System.Drawing.Size(100, 22);
            this.txtSeat.TabIndex = 5;
            // 
            // btnMakeReservation
            // 
            this.btnMakeReservation.Location = new System.Drawing.Point(393, 246);
            this.btnMakeReservation.Name = "btnMakeReservation";
            this.btnMakeReservation.Size = new System.Drawing.Size(195, 39);
            this.btnMakeReservation.TabIndex = 6;
            this.btnMakeReservation.Text = "Make Reservation";
            this.btnMakeReservation.UseVisualStyleBackColor = true;
            this.btnMakeReservation.Click += new System.EventHandler(this.btnMakeReservation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Destination";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Departure";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Plane";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Passenger";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Seat";
            // 
            // lstFlightSeats
            // 
            this.lstFlightSeats.FormattingEnabled = true;
            this.lstFlightSeats.ItemHeight = 16;
            this.lstFlightSeats.Location = new System.Drawing.Point(19, 188);
            this.lstFlightSeats.Name = "lstFlightSeats";
            this.lstFlightSeats.Size = new System.Drawing.Size(336, 292);
            this.lstFlightSeats.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Available Seats";
            // 
            // frmAirlineReservationApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 492);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstFlightSeats);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMakeReservation);
            this.Controls.Add(this.txtSeat);
            this.Controls.Add(this.txtPassenger);
            this.Controls.Add(this.txtPlane);
            this.Controls.Add(this.txtDeparture);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.g);
            this.Name = "frmAirlineReservationApp";
            this.Text = "AirlineReservationApp";
            this.Load += new System.EventHandler(this.frmAirlineReservationApp_Load);
            this.g.ResumeLayout(false);
            this.g.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox g;
        private System.Windows.Forms.RadioButton rdoKansas;
        private System.Windows.Forms.RadioButton rdoDenver;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtDeparture;
        private System.Windows.Forms.TextBox txtPlane;
        private System.Windows.Forms.TextBox txtPassenger;
        private System.Windows.Forms.TextBox txtSeat;
        private System.Windows.Forms.Button btnMakeReservation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstFlightSeats;
        private System.Windows.Forms.Label label6;
    }
}

