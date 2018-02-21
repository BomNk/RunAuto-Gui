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

namespace RunAuto
{
    public partial class Form1 : Form 
    {
        private SerialPort myport;
         string in_data="";
         int data = 0;
        public Form1()
        {
            InitializeComponent();

            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 200;
            progressBar1.Maximum = 200;
            progressBar1.Minimum = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
      
        }
        private void connect_Click(object sender, EventArgs e)
        {
            myport = new SerialPort();
            myport.BaudRate = 9600;
            myport.PortName = text_portName.Text;
            myport.Parity = Parity.None;
            myport.DataBits = 8;
            myport.StopBits = StopBits.One;
            myport.DataReceived += myport_DataReceived;
            try{
                myport.Open();
               // Data_table.Text = "test";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }

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
                progressBar1.Value = Int32.Parse(str);
                circularProgressBar1.Value = Int32.Parse(str);
            }
            else
            {
                circularProgressBar1.Text = "Error";
                progressBar1.Value = 0;
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



        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

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
