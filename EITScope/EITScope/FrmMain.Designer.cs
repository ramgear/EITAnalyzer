namespace EITScope
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.miStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.display = new GraphLib.PlotterDisplayEx();
            this.miStart = new System.Windows.Forms.ToolStripButton();
            this.miSerialPort = new System.Windows.Forms.ToolStripDropDownButton();
            this.miMode = new System.Windows.Forms.ToolStripDropDownButton();
            this.miDigital = new System.Windows.Forms.ToolStripMenuItem();
            this.miAnalog = new System.Windows.Forms.ToolStripMenuItem();
            this.miCapOnChanged = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(5);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miStart,
            this.miStop,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.miSerialPort,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.miMode,
            this.toolStripSeparator3,
            this.miCapOnChanged});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 53);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // miStop
            // 
            this.miStop.AutoSize = false;
            this.miStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.miStop.Enabled = false;
            this.miStop.Image = global::EITScope.Properties.Resources.stop;
            this.miStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.miStop.Name = "miStop";
            this.miStop.Size = new System.Drawing.Size(50, 50);
            this.miStop.Text = "Stop";
            this.miStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.miStop.Click += new System.EventHandler(this.miStop_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 53);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(46, 50);
            this.toolStripLabel1.Text = "Serial:";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 53);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(47, 50);
            this.toolStripLabel2.Text = "Mode:";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 53);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txtStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabel1.Text = "Status:";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStatus
            // 
            this.txtStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.txtStatus.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(719, 17);
            this.txtStatus.Spring = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.display);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 486);
            this.panel1.TabIndex = 2;
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.Transparent;
            this.display.BackgroundColorBot = System.Drawing.Color.Black;
            this.display.BackgroundColorTop = System.Drawing.Color.Black;
            this.display.DashedGridColor = System.Drawing.Color.DarkGray;
            this.display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.display.DoubleBuffering = true;
            this.display.Location = new System.Drawing.Point(0, 0);
            this.display.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.display.Name = "display";
            this.display.PlaySpeed = 0.5F;
            this.display.Size = new System.Drawing.Size(784, 486);
            this.display.SolidGridColor = System.Drawing.Color.DarkGray;
            this.display.TabIndex = 0;
            // 
            // miStart
            // 
            this.miStart.AutoSize = false;
            this.miStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.miStart.Enabled = false;
            this.miStart.Image = global::EITScope.Properties.Resources.start;
            this.miStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.miStart.Name = "miStart";
            this.miStart.Size = new System.Drawing.Size(50, 50);
            this.miStart.Text = "Start";
            this.miStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.miStart.Click += new System.EventHandler(this.miStart_Click);
            // 
            // miSerialPort
            // 
            this.miSerialPort.AutoSize = false;
            this.miSerialPort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.miSerialPort.Image = ((System.Drawing.Image)(resources.GetObject("miSerialPort.Image")));
            this.miSerialPort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.miSerialPort.Name = "miSerialPort";
            this.miSerialPort.Size = new System.Drawing.Size(60, 50);
            this.miSerialPort.Text = "Port";
            this.miSerialPort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.miSerialPort.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuSerialPort_DropDownItemClicked);
            // 
            // miMode
            // 
            this.miMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.miMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDigital,
            this.miAnalog});
            this.miMode.Image = ((System.Drawing.Image)(resources.GetObject("miMode.Image")));
            this.miMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.miMode.Name = "miMode";
            this.miMode.Size = new System.Drawing.Size(51, 50);
            this.miMode.Text = "Mode";
            this.miMode.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.miMode_DropDownItemClicked);
            // 
            // miDigital
            // 
            this.miDigital.Name = "miDigital";
            this.miDigital.Size = new System.Drawing.Size(112, 22);
            this.miDigital.Tag = "1";
            this.miDigital.Text = "Digital";
            // 
            // miAnalog
            // 
            this.miAnalog.Name = "miAnalog";
            this.miAnalog.Size = new System.Drawing.Size(112, 22);
            this.miAnalog.Tag = "2";
            this.miAnalog.Text = "Analog";
            // 
            // miCapOnChanged
            // 
            this.miCapOnChanged.AutoSize = false;
            this.miCapOnChanged.Checked = true;
            this.miCapOnChanged.CheckState = System.Windows.Forms.CheckState.Checked;
            this.miCapOnChanged.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.miCapOnChanged.Image = ((System.Drawing.Image)(resources.GetObject("miCapOnChanged.Image")));
            this.miCapOnChanged.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.miCapOnChanged.Name = "miCapOnChanged";
            this.miCapOnChanged.Size = new System.Drawing.Size(98, 50);
            this.miCapOnChanged.Text = "Cap on changed";
            this.miCapOnChanged.Click += new System.EventHandler(this.miCapOnChanged_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EIT Scope";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripDropDownButton miSerialPort;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton miStart;
        private System.Windows.Forms.ToolStripButton miStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripDropDownButton miMode;
        private System.Windows.Forms.ToolStripMenuItem miDigital;
        private System.Windows.Forms.ToolStripMenuItem miAnalog;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripStatusLabel txtStatus;
        private GraphLib.PlotterDisplayEx display;
        private System.Windows.Forms.ToolStripButton miCapOnChanged;
    }
}

