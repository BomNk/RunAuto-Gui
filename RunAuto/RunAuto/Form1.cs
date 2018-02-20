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



namespace RunAuto
{
    public partial class Form1 : Form 
    {
        private SerialPort myport;
        private string in_data="";
        private int data;
        public Form1()
        {
            InitializeComponent();
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 150;

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
                Data_table.Text = "test";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }

        }

        private void myport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            in_data = myport.ReadLine();
            //data = int.Parse(in_data);
            this.Invoke(new EventHandler(data_serialport_Tick));
            //Data_table.Text = in_data;
        }






        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void data_serialport_Tick(object sender, EventArgs e)
        {
            //string in_data = myport.ReadLine();
            //circularProgressBar1.Value = Int32.Parse(in_data);
            data = int.Parse(in_data);
            circularProgressBar1.Value = data;
            circularProgressBar1.Text = in_data;
           //
             Data_table.Text = "Num" + data;
        }
    }
}
