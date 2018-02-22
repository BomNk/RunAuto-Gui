namespace RunAuto
{
    partial class Form2
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
            this.connect = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.text_PortName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // connect
            // 
            this.connect.BackColor = System.Drawing.Color.SpringGreen;
            this.connect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.connect.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect.Location = new System.Drawing.Point(27, 64);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(170, 45);
            this.connect.TabIndex = 17;
            this.connect.Text = "CONNECT";
            this.connect.UseVisualStyleBackColor = false;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(21, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 33);
            this.label7.TabIndex = 16;
            this.label7.Text = "PORT";
            // 
            // text_PortName
            // 
            this.text_PortName.Location = new System.Drawing.Point(97, 36);
            this.text_PortName.Name = "text_PortName";
            this.text_PortName.Size = new System.Drawing.Size(100, 20);
            this.text_PortName.TabIndex = 15;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(550, 190);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.text_PortName);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_PortName;
    }
}