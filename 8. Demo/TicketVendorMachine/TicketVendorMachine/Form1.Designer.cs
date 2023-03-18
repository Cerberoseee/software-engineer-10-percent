namespace TicketVendorMachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tripGrp = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grdTrip = new System.Windows.Forms.DataGridView();
            this.btnNext1 = new System.Windows.Forms.Button();
            this.grpTimeSeat = new System.Windows.Forms.GroupBox();
            this.grdSeat = new System.Windows.Forms.DataGridView();
            this.grdTime = new System.Windows.Forms.DataGridView();
            this.btnNext2 = new System.Windows.Forms.Button();
            this.btnBack1 = new System.Windows.Forms.Button();
            this.tripGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTrip)).BeginInit();
            this.grpTimeSeat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTime)).BeginInit();
            this.SuspendLayout();
            // 
            // tripGrp
            // 
            this.tripGrp.Controls.Add(this.pictureBox1);
            this.tripGrp.Controls.Add(this.grdTrip);
            this.tripGrp.Location = new System.Drawing.Point(27, 12);
            this.tripGrp.Name = "tripGrp";
            this.tripGrp.Size = new System.Drawing.Size(1147, 571);
            this.tripGrp.TabIndex = 0;
            this.tripGrp.TabStop = false;
            this.tripGrp.Text = "Choose your desired trip";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(608, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(533, 522);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // grdTrip
            // 
            this.grdTrip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTrip.Location = new System.Drawing.Point(6, 25);
            this.grdTrip.Name = "grdTrip";
            this.grdTrip.RowHeadersWidth = 62;
            this.grdTrip.RowTemplate.Height = 28;
            this.grdTrip.Size = new System.Drawing.Size(583, 522);
            this.grdTrip.TabIndex = 0;
            this.grdTrip.Click += new System.EventHandler(this.grdTrip_Click);
            // 
            // btnNext1
            // 
            this.btnNext1.Location = new System.Drawing.Point(1019, 611);
            this.btnNext1.Name = "btnNext1";
            this.btnNext1.Size = new System.Drawing.Size(143, 47);
            this.btnNext1.TabIndex = 1;
            this.btnNext1.Text = "Next";
            this.btnNext1.UseVisualStyleBackColor = true;
            this.btnNext1.Click += new System.EventHandler(this.btnNext1_Click);
            // 
            // grpTimeSeat
            // 
            this.grpTimeSeat.Controls.Add(this.grdSeat);
            this.grpTimeSeat.Controls.Add(this.grdTime);
            this.grpTimeSeat.Location = new System.Drawing.Point(21, 12);
            this.grpTimeSeat.Name = "grpTimeSeat";
            this.grpTimeSeat.Size = new System.Drawing.Size(1147, 571);
            this.grpTimeSeat.TabIndex = 2;
            this.grpTimeSeat.TabStop = false;
            this.grpTimeSeat.Text = "Choose your desired depart time and trip";
            // 
            // grdSeat
            // 
            this.grdSeat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSeat.Location = new System.Drawing.Point(554, 25);
            this.grdSeat.Name = "grdSeat";
            this.grdSeat.RowHeadersWidth = 62;
            this.grdSeat.RowTemplate.Height = 28;
            this.grdSeat.Size = new System.Drawing.Size(587, 522);
            this.grdSeat.TabIndex = 1;
            this.grdSeat.Click += new System.EventHandler(this.grdSeat_Click);
            // 
            // grdTime
            // 
            this.grdTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTime.Location = new System.Drawing.Point(6, 25);
            this.grdTime.Name = "grdTime";
            this.grdTime.RowHeadersWidth = 62;
            this.grdTime.RowTemplate.Height = 28;
            this.grdTime.Size = new System.Drawing.Size(502, 522);
            this.grdTime.TabIndex = 0;
            this.grdTime.Click += new System.EventHandler(this.grdTime_Click);
            // 
            // btnNext2
            // 
            this.btnNext2.Location = new System.Drawing.Point(1019, 611);
            this.btnNext2.Name = "btnNext2";
            this.btnNext2.Size = new System.Drawing.Size(143, 47);
            this.btnNext2.TabIndex = 3;
            this.btnNext2.Text = "Next";
            this.btnNext2.UseVisualStyleBackColor = true;
            this.btnNext2.Click += new System.EventHandler(this.btnNext2_Click);
            // 
            // btnBack1
            // 
            this.btnBack1.Location = new System.Drawing.Point(21, 611);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(143, 47);
            this.btnBack1.TabIndex = 4;
            this.btnBack1.Text = "Back";
            this.btnBack1.UseVisualStyleBackColor = true;
            this.btnBack1.Click += new System.EventHandler(this.backBtn1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 670);
            this.Controls.Add(this.btnBack1);
            this.Controls.Add(this.btnNext2);
            this.Controls.Add(this.grpTimeSeat);
            this.Controls.Add(this.btnNext1);
            this.Controls.Add(this.tripGrp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tripGrp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTrip)).EndInit();
            this.grpTimeSeat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox tripGrp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView grdTrip;
        private System.Windows.Forms.Button btnNext1;
        private System.Windows.Forms.GroupBox grpTimeSeat;
        private System.Windows.Forms.DataGridView grdSeat;
        private System.Windows.Forms.DataGridView grdTime;
        private System.Windows.Forms.Button btnNext2;
        private System.Windows.Forms.Button btnBack1;
    }
}

