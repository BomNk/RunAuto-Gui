namespace RunAuto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.START = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.set_time = new System.Windows.Forms.Label();
            this.STOP = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.text_speed = new System.Windows.Forms.Label();
            this.down = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.text_kao = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.data_serialport = new System.Windows.Forms.Timer(this.components);
            this.add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.real_time = new System.Windows.Forms.Label();
            this.date_real = new System.Windows.Forms.Label();
            this.connect1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer_time = new System.Windows.Forms.Timer(this.components);
            this.Test = new System.Windows.Forms.Button();
            this.pnlVideo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.ForeColor = System.Drawing.Color.Blue;
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(46, 37);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.Red;
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.Size = new System.Drawing.Size(210, 199);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "   bpm";
            this.circularProgressBar1.TabIndex = 0;
            this.circularProgressBar1.Text = "0";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.UseWaitCursor = true;
            this.circularProgressBar1.Value = 68;
            this.circularProgressBar1.Click += new System.EventHandler(this.circularProgressBar1_Click);
            // 
            // START
            // 
            this.START.BackColor = System.Drawing.Color.SpringGreen;
            this.START.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.START.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.START.Location = new System.Drawing.Point(46, 512);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(228, 100);
            this.START.TabIndex = 1;
            this.START.Text = "START";
            this.START.UseVisualStyleBackColor = false;
            this.START.Click += new System.EventHandler(this.START_Click);
            // 
            // set_time
            // 
            this.set_time.AutoSize = true;
            this.set_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.set_time.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.set_time.Location = new System.Drawing.Point(327, 508);
            this.set_time.Name = "set_time";
            this.set_time.Size = new System.Drawing.Size(425, 108);
            this.set_time.TabIndex = 2;
            this.set_time.Text = "00:00:00";
            // 
            // STOP
            // 
            this.STOP.BackColor = System.Drawing.Color.Red;
            this.STOP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.STOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.STOP.Location = new System.Drawing.Point(790, 512);
            this.STOP.Name = "STOP";
            this.STOP.Size = new System.Drawing.Size(222, 100);
            this.STOP.TabIndex = 3;
            this.STOP.Text = "STOP";
            this.STOP.UseVisualStyleBackColor = false;
            this.STOP.Click += new System.EventHandler(this.STOP_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(38, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "SPEED";
            // 
            // text_speed
            // 
            this.text_speed.AutoSize = true;
            this.text_speed.BackColor = System.Drawing.Color.Transparent;
            this.text_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.text_speed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.text_speed.Location = new System.Drawing.Point(49, 328);
            this.text_speed.Name = "text_speed";
            this.text_speed.Size = new System.Drawing.Size(98, 108);
            this.text_speed.TabIndex = 5;
            this.text_speed.Text = "0";
            // 
            // down
            // 
            this.down.BackColor = System.Drawing.Color.Red;
            this.down.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.down.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.down.ForeColor = System.Drawing.Color.Black;
            this.down.Location = new System.Drawing.Point(194, 405);
            this.down.Name = "down";
            this.down.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.down.Size = new System.Drawing.Size(79, 72);
            this.down.TabIndex = 7;
            this.down.Text = "-";
            this.down.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.down.UseVisualStyleBackColor = false;
            this.down.Click += new System.EventHandler(this.down_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(784, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // text_kao
            // 
            this.text_kao.AutoSize = true;
            this.text_kao.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.text_kao.ForeColor = System.Drawing.Color.Cyan;
            this.text_kao.Location = new System.Drawing.Point(840, 145);
            this.text_kao.Name = "text_kao";
            this.text_kao.Size = new System.Drawing.Size(180, 73);
            this.text_kao.TabIndex = 9;
            this.text_kao.Text = "0000";
            this.text_kao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(798, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 85);
            this.label5.TabIndex = 10;
            this.label5.Text = "Km/Hr";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(834, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 112);
            this.label6.TabIndex = 11;
            this.label6.Text = "00";
            // 
            // data_serialport
            // 
            this.data_serialport.Interval = 10;
            this.data_serialport.Tick += new System.EventHandler(this.data_serialport_Tick);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Lime;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.add.ForeColor = System.Drawing.Color.Black;
            this.add.Location = new System.Drawing.Point(194, 278);
            this.add.Name = "add";
            this.add.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.add.Size = new System.Drawing.Size(79, 72);
            this.add.TabIndex = 16;
            this.add.Text = "+";
            this.add.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(870, 616);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(732, 616);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "Time ";
            // 
            // real_time
            // 
            this.real_time.AutoSize = true;
            this.real_time.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.real_time.ForeColor = System.Drawing.Color.Lime;
            this.real_time.Location = new System.Drawing.Point(779, 616);
            this.real_time.Name = "real_time";
            this.real_time.Size = new System.Drawing.Size(94, 28);
            this.real_time.TabIndex = 19;
            this.real_time.Text = "00:00:00";
            // 
            // date_real
            // 
            this.date_real.AutoSize = true;
            this.date_real.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_real.ForeColor = System.Drawing.Color.Lime;
            this.date_real.Location = new System.Drawing.Point(918, 616);
            this.date_real.Name = "date_real";
            this.date_real.Size = new System.Drawing.Size(102, 28);
            this.date_real.TabIndex = 20;
            this.date_real.Text = "00/00/00";
            // 
            // connect1
            // 
            this.connect1.BackColor = System.Drawing.Color.Lime;
            this.connect1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.connect1.Location = new System.Drawing.Point(931, 11);
            this.connect1.Name = "connect1";
            this.connect1.Size = new System.Drawing.Size(107, 23);
            this.connect1.TabIndex = 22;
            this.connect1.Text = "connect_arduino";
            this.connect1.UseVisualStyleBackColor = false;
            this.connect1.Click += new System.EventHandler(this.connect1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(823, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(102, 21);
            this.comboBox1.TabIndex = 23;
            // 
            // timer_time
            // 
            this.timer_time.Tick += new System.EventHandler(this.timer_time_Tick);
            // 
            // Test
            // 
            this.Test.Location = new System.Drawing.Point(798, 365);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(75, 23);
            this.Test.TabIndex = 24;
            this.Test.Text = "Test";
            this.Test.UseVisualStyleBackColor = true;
            // 
            // pnlVideo
            // 
            this.pnlVideo.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pnlVideo.Location = new System.Drawing.Point(336, 21);
            this.pnlVideo.Name = "pnlVideo";
            this.pnlVideo.Size = new System.Drawing.Size(395, 484);
            this.pnlVideo.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1050, 646);
            this.Controls.Add(this.pnlVideo);
            this.Controls.Add(this.Test);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.connect1);
            this.Controls.Add(this.date_real);
            this.Controls.Add(this.real_time);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_kao);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.down);
            this.Controls.Add(this.text_speed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.STOP);
            this.Controls.Add(this.set_time);
            this.Controls.Add(this.START);
            this.Controls.Add(this.circularProgressBar1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Button START;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label set_time;
        private System.Windows.Forms.Button STOP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label text_speed;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label text_kao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer data_serialport;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label real_time;
        private System.Windows.Forms.Label date_real;
        private System.Windows.Forms.Button connect1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timer_time;
        private System.Windows.Forms.Button Test;
        private System.Windows.Forms.Panel pnlVideo;
    }
}

