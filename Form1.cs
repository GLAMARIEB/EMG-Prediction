using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Timers;

namespace EMG_Prediction
{
    public partial class Form1 : Form
    {
        string in_data;
        string out_data;
       

        public Form1()
        {
            InitializeComponent();
            getAvailablePorts();

            btn_tConnect.Enabled = true;
            btn_aConnect.Enabled = true;
            btn_tDisconnect.Enabled = false;
            btn_aDisconnect.Enabled = false;

            serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(DataReceived);


        }

      

        private void getAvailablePorts()
        {
            // Get the available COM Ports and put them in the ComboBox1
            String[] ports = SerialPort.GetPortNames();
            Tcomport.Items.AddRange(ports);
            Acomport.Items.AddRange(ports);
        }
        private void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                in_data = serialPort1.ReadLine();
                this.Invoke(new EventHandler(display_event));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Not Recieved");
            }
        }

        private void display_event(object sender, EventArgs e)
        {
            int value;
            
            PredictionBox.Text = in_data;
            value = Convert.ToInt32(PredictionBox.Text);
            if (value == 1)
             {
                MessageBox.Show("Fist");
             }
            else if (value == 2)
            {
                MessageBox.Show("Rest");
            }
            else if (value == 3)
            {
                MessageBox.Show("Open Hand");
            }
            else if (value == 4)
            {
                MessageBox.Show("Wave In");
            }
            else if (value == 5)
            {
                MessageBox.Show("Wave Out");
            }
            else if (value == 6)
            {
                MessageBox.Show("Point");
            }
            else if (value == 7)
            {
                MessageBox.Show("Okay");
            }
            else
            {
                MessageBox.Show("Not in Range");
            }

        }

        private void Btn_tConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (Tcomport.Text == "" || tBaudrate.Text == "")
                {
                    textBox1.Text = "Please select port settings.";
                }
                else
                {
                    // Setup settings for the serial port1
                    serialPort1.PortName = Tcomport.Text;
                    serialPort1.BaudRate = Convert.ToInt32(tBaudrate.Text);
                    serialPort1.Parity = Parity.None;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.DataBits = 8;



                    try
                    {
                        if (!serialPort1.IsOpen)
                            serialPort1.Open();
                    }
                    catch (Exception ex)
                    {
                        textBox1.Text = "Error";
                    }
                    btn_tConnect.Enabled = false;
                    btn_tDisconnect.Enabled = true;
                }
            }
            catch (UnauthorizedAccessException)
            {
                textBox1.Text = "Unauthorized Access";
            }
        }

        private void Btn_tDisconnect_Click(object sender, EventArgs e)
        {
            
            serialPort1.Close();
            btn_tConnect.Enabled = true;
            btn_tDisconnect.Enabled = false;
         
        }

        private void Btn_aConnect_Click(object sender, EventArgs e)
        {

            try
            {
                if (Acomport.Text == "" || aBaudrate.Text == "")
                {
                    textBox3.Text = "Please select port settings.";
                }
                else
                {
                    // Setup settings for the serial port1
                    serialPort2.PortName = Tcomport.Text;
                    serialPort2.BaudRate = Convert.ToInt32(aBaudrate.Text);
                    serialPort2.Parity = Parity.None;
                    serialPort2.StopBits = StopBits.One;
                    serialPort2.DataBits = 8;



                    try
                    {
                        if (!serialPort2.IsOpen)
                        {
                            serialPort2.Open();
                            textBox3.Text = "Connected to Arduino";
                            out_data = textBox3.Text;
                            serialPort2.WriteLine(out_data);
                        }
                    }
                    catch (Exception ex)
                    {
                        textBox3.Text = "Did not connect to arduino";
                    }
                    btn_aConnect.Enabled = false;
                    btn_aDisconnect.Enabled = true;
                }
            }
            catch (UnauthorizedAccessException)
            {
                textBox3.Text = "Unauthorized Access2";
            }
        }

        private void Btn_aDisconnect_Click(object sender, EventArgs e)
        {
            serialPort2.Close();
            btn_aConnect.Enabled = true;
            btn_aDisconnect.Enabled = false;
        }
    }


}
