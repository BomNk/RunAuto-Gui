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
            this.time = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.up = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.text_portName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.connect = new System.Windows.Forms.Button();
            this.data_serialport = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
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
            this.circularProgressBar1.Location = new System.Drawing.Point(63, 37);
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
            this.circularProgressBar1.Text = "85";
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
            this.START.Location = new System.Drawing.Point(45, 523);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(228, 100);
            this.START.TabIndex = 1;
            this.START.Text = "START";
            this.START.UseVisualStyleBackColor = false;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.time.Location = new System.Drawing.Point(342, 511);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(425, 108);
            this.time.TabIndex = 2;
            this.time.Text = "00:00:00";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Exit.Location = new System.Drawing.Point(829, 511);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(170, 112);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = false;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(49, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 108);
            this.label3.TabIndex = 5;
            this.label3.Text = "5";
            // 
            // up
            // 
            this.up.BackColor = System.Drawing.Color.Lime;
            this.up.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.up.Location = new System.Drawing.Point(192, 278);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(81, 75);
            this.up.TabIndex = 6;
            this.up.Text = "+";
            this.up.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.up.UseVisualStyleBackColor = false;
            this.up.Click += new System.EventHandler(this.button3_Click);
            // 
            // down
            // 
            this.down.BackColor = System.Drawing.Color.Red;
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
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(862, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(800, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 73);
            this.label4.TabIndex = 9;
            this.label4.Text = "1,153";
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
            this.label6.Location = new System.Drawing.Point(833, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 112);
            this.label6.TabIndex = 11;
            this.label6.Text = "10";
            // 
            // text_portName
            // 
            this.text_portName.Location = new System.Drawing.Point(899, 231);
            this.text_portName.Name = "text_portName";
            this.text_portName.Size = new System.Drawing.Size(100, 20);
            this.text_portName.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(823, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 33);
            this.label7.TabIndex = 13;
            this.label7.Text = "PORT";
            // 
            // connect
            // 
            this.connect.BackColor = System.Drawing.Color.SpringGreen;
            this.connect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.connect.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect.Location = new System.Drawing.Point(829, 257);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(170, 41);
            this.connect.TabIndex = 14;
            this.connect.Text = "CONNECT";
            this.connect.UseVisualStyleBackColor = false;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // data_serialport
            // 
            this.data_serialport.Interval = 10;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(360, 62);
            this.progressBar1.Maximum = 1024;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(149, 23);
            this.progressBar1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1024, 653);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.text_portName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.down);
            this.Controls.Add(this.up);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.time);
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
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_portName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Timer data_serialport;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

