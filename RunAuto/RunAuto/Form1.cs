using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using System.Diagnostics;

using Microsoft.DirectX.AudioVideoPlayback;
using System.IO;





namespace RunAuto
{
    public partial class Form1 : Form 
    {
        private SerialPort myport;
       
        string in_data="";
         int data = 0;
        Stopwatch stopwatch = new Stopwatch();
        int H=0,M=0,S=0,ss;

        int speedMotor = 0;
        public string text_portName = "";

        // Video //
        private Video video;
        private string[] videoPaths;
        private string folderPath = @"C:\Users\tanap\Documents\[C# Winforms] Create your own Video Player (DirectX)\";
        //private int selectedIndex = 0;
        private Size formSize;
        private Size pnlSize;
        //

        //string time = "";
        public Form1()
        {
            
            InitializeComponent();
            getAvailableComponent();
            timer_time.Start();
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 200;
            circularProgressBar1.Value = 0;

           

        }
        void getAvailableComponent()
        {
            String[] Ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(Ports);
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            formSize = new Size(this.Width, this.Height);
            pnlSize = new Size(pnlVideo.Width, pnlVideo.Height);
            videoPaths = Directory.GetFiles(folderPath, "*.wmv");

            video = new Video(videoPaths[0]);
            video.Owner = pnlVideo;
            pnlVideo.Size = pnlSize;

            video.Play();

            //video.Ending += new EventHandler(BackLoop);

            //video.Stop();
        }
        private void BackLoop(object sender, EventArgs e)
        {

            video.CurrentPosition = 0;// Video keeps looping...

        }


        private void myport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string str = myport.ReadLine();

            // data_serialport.Enabled = true;
            //data_serialport.Start();
            this.BeginInvoke(new LineReceivedEvent(LineReceived),str);
            
            //Data_table.Text = in_data;
        }
        private delegate void LineReceivedEvent(string line);
        private void LineReceived(string str)
        {
            try
            {
                int x = 0;
                string[] aa = str.Split('/');
                /* for(int i = 0; i < IntParseFast(str); i++)
                 {
                     x++;
                 }*/
                x = Int32.Parse(aa[0]);
                //x[1] = Int32.Parse(aa[1]);
                text_kao.Text = aa[1];
                if (x >= 0 && x < 200)
                {
                    circularProgressBar1.Text = aa[0];
                    circularProgressBar1.Value = Int32.Parse(aa[0]);


                }
                else
                {
                    circularProgressBar1.Text = "Error";
                    circularProgressBar1.Value = 0;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
                
                //circularProgressBar1.Update();


        }

       




        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            if (speedMotor < 5) {
                speedMotor++;
                text_speed.Text = speedMotor + ""; 
            }
            
        }

        private void START_Click(object sender, EventArgs e)
        {

            try
            {
                myport.Open();
                myport.DataReceived += myport_DataReceived;
                stopwatch.Start();
                data_serialport.Start();
                // stopwatch.Start();

                // data_serialport.Start();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
         
            
        }

        private void STOP_Click(object sender, EventArgs e)
        {
            myport.Write("000");
            circularProgressBar1.Value = 0;
            circularProgressBar1.Text = "0";
            
            myport.Close();
            stopwatch.Stop();
            data_serialport.Stop();
            
             
        }

        private void timer_time_Tick(object sender, EventArgs e)
        {
            real_time.Text = DateTime.Now.TimeOfDay.ToString().Substring(0, 8);
            date_real.Text = DateTime.Now.Date.ToString().Substring(0, 10);
        }

       

        private void down_Click(object sender, EventArgs e)
        {
            if (speedMotor > 0)
            {
                speedMotor--;
                text_speed.Text = speedMotor + "";
            }
        }

        private void data_serialport_Tick(object sender, EventArgs e)
        {
            myport.Write(speedMotor + "");
            data++;
            // time.Text = data + "";
            //set_time.Text = DateTime.Now.TimeOfDay.ToString().Substring(0,8);  
           
            // show RealTime

           
            // ... This takes 10 seconds to finish.

            // Stop.
            //stopwatch.Stop();

            // Write hours, minutes and seconds.
            //Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);


            set_time.Text = stopwatch.Elapsed.ToString().Substring(0,8);


        }

        private void connect1_Click(object sender, EventArgs e)
        {
            myport = new SerialPort();
            myport.BaudRate = 9600;
            myport.PortName = comboBox1.Text;
            myport.Parity = Parity.None;
            myport.DataBits = 8;
            myport.StopBits = StopBits.One;
           // myport.DataReceived += myport_DataReceived;
           /* try
            {
                
               // stopwatch.Start();
                
               // data_serialport.Start();


               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }*/
        }





        /*
       private void data_serialport_Tick(object sender, EventArgs e)
       {
           //string in_data = myport.ReadLine();
           //in_data = myport.ReadLine();
           //circularProgressBar1.Value = Int32.Parse(in_data);

           //data = Int32.Parse(in_data);
           circularProgressBar1.Text = in_data;
           //data = Int32.Parse(in_data);
           circularProgressBar1.Value = data;

           //Data_table.Text = "Num = " + data;
       }*/
    }
}
