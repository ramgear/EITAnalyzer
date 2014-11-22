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

namespace EITScope
{
    using GraphLib;

    public partial class FrmMain : Form
    {
        SerialPort serial;

        Timer timer;
        const float mSampleTimeUs = 100;

        const int MaxChannelCount = 8;
        const int MaxSample = 1000000;
        bool digitalMode;

        Color[] mColors =
            {
                Color.Red,
                Color.Orange,
                Color.Yellow,
                Color.LightGreen,
                Color.Blue,
                Color.DarkSalmon,
                Color.LightPink,
                Color.White
            };

        public FrmMain()
        {
            InitializeComponent();

            string[] ports = SerialPort.GetPortNames();
            foreach(string port in ports)
                miSerialPort.DropDownItems.Add(new ToolStripButton(port));

            display.PanelLayout = PlotterGraphPaneEx.LayoutMode.STACKED;
            display.MouseWheel += display_MouseWheel;
            this.PrepareDataSource();

            if (miSerialPort.DropDownItems.Count > 0)
            {
                miSerialPort.Text = miSerialPort.DropDownItems[0].Text;
                miStart.Enabled = true;
            }
            else
            {
                statusStrip1.Text = "No serial port detected!";
            }

            foreach (ToolStripItem item in miMode.DropDownItems)
            {
                if (item.Text == "Digital")
                {
                    miMode.Text = item.Text;
                    modeChanged(miMode.Text);
                }
            }

            serial = new SerialPort();
            serial.BaudRate = 115200;
            serial.DataBits = 8;
            serial.Parity = Parity.None;
            serial.StopBits = StopBits.One;
            serial.Handshake = Handshake.None;

            serial.DataReceived += serial_DataReceived;
            serial.ErrorReceived += serial_ErrorReceived;


            timer = new Timer();
            timer.Interval = 500;
            timer.Tick += timer_Tick;

            this.UpdateStatus();
        }

        float normalXRange = -1;
        void display_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                float delta = e.Delta / 12;
                float xrage = display.GraphDisplay.XD1 - display.GraphDisplay.XD0;
                if (normalXRange == -1)
                {
                    normalXRange = xrage;
                }

                xrage += xrage * delta / 100;
                display.GraphDisplay.XD1 = display.GraphDisplay.XD0 + xrage;

                display.Refresh();
            }
            catch (Exception ex)
            {
                this.ExceptionHandler(ex);
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                display.Refresh();
            }catch(Exception ex)
            {
                this.ExceptionHandler(ex);
            }
        }

        List<DataSource> dsDigitalList;
        List<DataSource> dsAnalogList;

        private void modeChanged(string mode)
        {
            this.SuspendLayout();
            
            display.DataSources.Clear();

            if (mode.ToLower() == "digital")
            {
                digitalMode = true;
                display.DataSources.AddRange(dsDigitalList);
            }
            else
            {
                digitalMode = false;
                display.DataSources.AddRange(dsAnalogList);
            }

            this.ResumeLayout();
            display.Refresh();
        }

        private void PrepareDataSource()
        {
            dsDigitalList = new List<DataSource>();
            dsAnalogList = new List<DataSource>();

            display.SetDisplayRangeX(0, 100);

            DataSource ds;

            // Digital data source
            bool testVal = false;
            for (int i = 0; i < MaxChannelCount; i++)
            {
                ds = new DataSource();
                ds.Name = "Ch " + i;
                ds.Length = MaxSample;
                ds.GraphColor = mColors[i];
                ds.OnRenderXAxisLabel += RenderXLabel;
                ds.OnRenderYAxisLabel += RenderYLabel;
                ds.AutoScaleY = false;
                ds.SetDisplayRangeY(0, 1.3F);
                ds.SetGridDistanceY(1);

                testVal = false;
                for (int j = 0; j < ds.Length; j++ )
                {
                    if (j % 10 == 0)
                        testVal = !testVal;
                    ds.Samples[j].x = j;
                    ds.Samples[j].y = 0;
                }

                dsDigitalList.Add(ds);
            }

            // Digital data source
            ds = new DataSource();
            ds.Name = "Analog 0";
            ds.Length = MaxSample;
            ds.GraphColor = mColors[0];
            ds.OnRenderXAxisLabel += RenderXLabel;
            ds.OnRenderYAxisLabel += RenderYLabel;
            ds.AutoScaleY = false;
            ds.SetDisplayRangeY(-1, 5.1F);
            ds.SetGridDistanceY(1);
            for (int j = 0; j < ds.Length; j++)
            {
                ds.Samples[j].x = j;
                ds.Samples[j].y = 0;
            }
            dsAnalogList.Add(ds);
        }

        private String RenderXLabel(DataSource s, int idx)
        {
            int Value = (int)(s.Samples[idx].x / 10);
            String Label = "" + Value + "ms";
            return Label;
        }

        private String RenderYLabel(DataSource s, float value)
        {
            return String.Format("{0:0.0}", value);
        }

        void serial_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            try
            {
                serial.DiscardInBuffer();
                serial.DiscardOutBuffer();
            }
            catch (Exception ex)
            {
                this.ExceptionHandler(ex);
            }
        }

        int mDataIndex = 0;
        void serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                int data;
                DataSource ds;

                // Read received data
                while(serial.BytesToRead > 0)
                {
                    data = serial.ReadByte();

                    if(digitalMode)
                    {
                        for(int i = 0; i < MaxChannelCount; i++)
                        {
                            ds = display.DataSources[i];
                            ds.Samples[mDataIndex].y = (data >> i) & 1;
                        }
                    }
                    else
                    {
                        ds = display.DataSources[0];
                        ds.Samples[mDataIndex].y = (5.0F/256) * data;

                    }

                    mDataIndex++;
                }
            }
            catch (Exception ex)
            {
                this.ExceptionHandler(ex);
            }
        }

        #region Utilities
        void UpdateStatus()
        {
        }

        void ExceptionHandler(Exception ex)
        {
            MessageBox.Show(ex.Message, "Exception Dialog", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

        void mnuSerialPort_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                miSerialPort.Text = e.ClickedItem.Text;
            }
            catch(Exception ex)
            {
                this.ExceptionHandler(ex);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void miMode_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                if (miMode.Text != e.ClickedItem.Text)
                {
                    miMode.Text = e.ClickedItem.Text;
                    modeChanged(miMode.Text);
                }
            }
            catch (Exception ex)
            {
                this.ExceptionHandler(ex);
            }
        }

        private void miStart_Click(object sender, EventArgs e)
        {
            try
            {
                serial.PortName = miSerialPort.Text;

                serial.Open();
                serial.DiscardInBuffer();
                serial.DiscardOutBuffer();

                // Stop capture first
                serial.WriteLine("stop");

                // Send capture mode
                string cfg = "cfg=";
                cfg += miMode.Text.ToLower() == "digital" ? "1" : "0";
                cfg += ",";
                cfg += miCapOnChanged.Checked ? "1" : "0";
                serial.WriteLine(cfg);

                // Start capture
                serial.WriteLine("start");
                serial.DtrEnable = true;

                // Enable/Disable controls
                miStart.Enabled = false;
                miStop.Enabled = true;
                miSerialPort.Enabled = false;
                miMode.Enabled = false;
                miCapOnChanged.Enabled = false;
                timer.Enabled = true;
            }
            catch (Exception ex)
            {
                this.ExceptionHandler(ex);
            }
        }

        private void miStop_Click(object sender, EventArgs e)
        {
            try
            {
                // Stop capture
                serial.WriteLine("stop");

                serial.DtrEnable = false;
                serial.DiscardInBuffer();
                serial.DiscardOutBuffer();
                serial.Close();
                timer.Enabled = false;

                // Enable/Disable controls
                miStart.Enabled = true;
                miStop.Enabled = false;
                miSerialPort.Enabled = true;
                miMode.Enabled = true;
                miCapOnChanged.Enabled = true;
            }
            catch (Exception ex)
            {
                this.ExceptionHandler(ex);
            }
        }

        private void miCapOnChanged_Click(object sender, EventArgs e)
        {
            try
            {
                miCapOnChanged.Checked = !miCapOnChanged.Checked;
            }
            catch (Exception ex)
            {
                this.ExceptionHandler(ex);
            }
        }
    }
}
