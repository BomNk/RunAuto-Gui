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
        //string time = "";
        public Form1()
        {

            InitializeComponent();
            getAvailableComponent();
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 200;
            

        }
        void getAvailableComponent()
        {
            String[] Ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(Ports);
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
      
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
            int x = 0;
           
            /* for(int i = 0; i < IntParseFast(str); i++)
             {
                 x++;
             }*/
            x = Int32.Parse(str);

            if (x >= 0 && x < 200)
            {
                circularProgressBar1.Text = str;
                circularProgressBar1.Value =  Int32.Parse(str);
            }
            else
            {
                circularProgressBar1.Text = "Error";
                circularProgressBar1.Value = 0;
            }
                //circularProgressBar1.Update();


            }

        public static int IntParseFast(string value)
        {
            int result = 0;
            StringBuilder x = new StringBuilder();
            x.Append(value);

            for (int i = 0; i < x.Length; i++)
                result = result + ((x[i] - '0')*(10^i));

            return result;
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
            myport.DataReceived += myport_DataReceived;
            stopwatch.Start();
             data_serialport.Start();
            
        }

        private void STOP_Click(object sender, EventArgs e)
        {

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
            real_time.Text = DateTime.Now.TimeOfDay.ToString().Substring(0, 8);
            date_real.Text = DateTime.Now.Date.ToString().Substring(0, 10);
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
            try
            {
                myport.Open();
               // stopwatch.Start();
                
               // data_serialport.Start();


               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
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
