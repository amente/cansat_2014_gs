namespace CanSatGroundStation
{
    partial class DataGraphForm
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
            this.tlpData = new System.Windows.Forms.TableLayoutPanel();
            this.splBatteryV = new System.Windows.Forms.SplitContainer();
            this.lblBatteryV = new System.Windows.Forms.Label();
            this.rtgBatteryV = new CanSatGroundStation.RealTimeGraph();
            this.splTempurature = new System.Windows.Forms.SplitContainer();
            this.lblTempurature = new System.Windows.Forms.Label();
            this.rtgTempurature = new CanSatGroundStation.RealTimeGraph();
            this.splAltitude = new System.Windows.Forms.SplitContainer();
            this.lblAltitude = new System.Windows.Forms.Label();
            this.rtgAltitude = new CanSatGroundStation.RealTimeGraph();
            this.tlpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splBatteryV)).BeginInit();
            this.splBatteryV.Panel1.SuspendLayout();
            this.splBatteryV.Panel2.SuspendLayout();
            this.splBatteryV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splTempurature)).BeginInit();
            this.splTempurature.Panel1.SuspendLayout();
            this.splTempurature.Panel2.SuspendLayout();
            this.splTempurature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splAltitude)).BeginInit();
            this.splAltitude.Panel1.SuspendLayout();
            this.splAltitude.Panel2.SuspendLayout();
            this.splAltitude.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpData
            // 
            this.tlpData.ColumnCount = 1;
            this.tlpData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpData.Controls.Add(this.splBatteryV, 0, 2);
            this.tlpData.Controls.Add(this.splTempurature, 0, 0);
            this.tlpData.Controls.Add(this.splAltitude, 0, 1);
            this.tlpData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpData.Location = new System.Drawing.Point(0, 0);
            this.tlpData.Name = "tlpData";
            this.tlpData.RowCount = 3;
            this.tlpData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpData.Size = new System.Drawing.Size(751, 478);
            this.tlpData.TabIndex = 1;
            // 
            // splBatteryV
            // 
            this.splBatteryV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splBatteryV.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splBatteryV.Location = new System.Drawing.Point(3, 321);
            this.splBatteryV.Name = "splBatteryV";
            // 
            // splBatteryV.Panel1
            // 
            this.splBatteryV.Panel1.Controls.Add(this.lblBatteryV);
            // 
            // splBatteryV.Panel2
            // 
            this.splBatteryV.Panel2.Controls.Add(this.rtgBatteryV);
            this.splBatteryV.Size = new System.Drawing.Size(745, 154);
            this.splBatteryV.SplitterDistance = 217;
            this.splBatteryV.TabIndex = 18;
            // 
            // lblBatteryV
            // 
            this.lblBatteryV.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBatteryV.AutoSize = true;
            this.lblBatteryV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatteryV.Location = new System.Drawing.Point(22, 70);
            this.lblBatteryV.Name = "lblBatteryV";
            this.lblBatteryV.Size = new System.Drawing.Size(189, 16);
            this.lblBatteryV.TabIndex = 2;
            this.lblBatteryV.Text = "Battery Voltage <Voltage>";
            // 
            // rtgBatteryV
            // 
            this.rtgBatteryV.BackColor = System.Drawing.Color.White;
            this.rtgBatteryV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtgBatteryV.ForeColor = System.Drawing.Color.Black;
            this.rtgBatteryV.Location = new System.Drawing.Point(0, 0);
            this.rtgBatteryV.Name = "rtgBatteryV";
            this.rtgBatteryV.Size = new System.Drawing.Size(524, 154);
            this.rtgBatteryV.TabIndex = 1;
            this.rtgBatteryV.YMaximum = 10D;
            this.rtgBatteryV.YMinimum = 0D;
            // 
            // splTempurature
            // 
            this.splTempurature.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splTempurature.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splTempurature.Location = new System.Drawing.Point(3, 3);
            this.splTempurature.Name = "splTempurature";
            // 
            // splTempurature.Panel1
            // 
            this.splTempurature.Panel1.Controls.Add(this.lblTempurature);
            // 
            // splTempurature.Panel2
            // 
            this.splTempurature.Panel2.Controls.Add(this.rtgTempurature);
            this.splTempurature.Size = new System.Drawing.Size(745, 153);
            this.splTempurature.SplitterDistance = 217;
            this.splTempurature.TabIndex = 16;
            // 
            // lblTempurature
            // 
            this.lblTempurature.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblTempurature.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTempurature.AutoSize = true;
            this.lblTempurature.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempurature.Location = new System.Drawing.Point(22, 69);
            this.lblTempurature.Name = "lblTempurature";
            this.lblTempurature.Size = new System.Drawing.Size(158, 16);
            this.lblTempurature.TabIndex = 2;
            this.lblTempurature.Text = "Tempurature <TEMP>";
            // 
            // rtgTempurature
            // 
            this.rtgTempurature.BackColor = System.Drawing.Color.White;
            this.rtgTempurature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtgTempurature.ForeColor = System.Drawing.Color.Black;
            this.rtgTempurature.Location = new System.Drawing.Point(0, 0);
            this.rtgTempurature.Name = "rtgTempurature";
            this.rtgTempurature.Size = new System.Drawing.Size(524, 153);
            this.rtgTempurature.TabIndex = 1;
            this.rtgTempurature.YMaximum = 30D;
            this.rtgTempurature.YMinimum = -30D;
            // 
            // splAltitude
            // 
            this.splAltitude.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splAltitude.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splAltitude.Location = new System.Drawing.Point(3, 162);
            this.splAltitude.Name = "splAltitude";
            // 
            // splAltitude.Panel1
            // 
            this.splAltitude.Panel1.Controls.Add(this.lblAltitude);
            // 
            // splAltitude.Panel2
            // 
            this.splAltitude.Panel2.Controls.Add(this.rtgAltitude);
            this.splAltitude.Size = new System.Drawing.Size(745, 153);
            this.splAltitude.SplitterDistance = 217;
            this.splAltitude.TabIndex = 17;
            // 
            // lblAltitude
            // 
            this.lblAltitude.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAltitude.AutoSize = true;
            this.lblAltitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltitude.Location = new System.Drawing.Point(22, 69);
            this.lblAltitude.Name = "lblAltitude";
            this.lblAltitude.Size = new System.Drawing.Size(175, 16);
            this.lblAltitude.TabIndex = 2;
            this.lblAltitude.Text = "Altitude <ALT SENSOR>";
            // 
            // rtgAltitude
            // 
            this.rtgAltitude.BackColor = System.Drawing.Color.White;
            this.rtgAltitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtgAltitude.ForeColor = System.Drawing.Color.Black;
            this.rtgAltitude.Location = new System.Drawing.Point(0, 0);
            this.rtgAltitude.Name = "rtgAltitude";
            this.rtgAltitude.Size = new System.Drawing.Size(524, 153);
            this.rtgAltitude.TabIndex = 1;
            this.rtgAltitude.YMaximum = 500D;
            this.rtgAltitude.YMinimum = -100D;
            // 
            // DataGraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 478);
            this.Controls.Add(this.tlpData);
            this.Name = "DataGraphForm";
            this.Text = "DataForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataGraphForm_FormClosing);
            this.tlpData.ResumeLayout(false);
            this.splBatteryV.Panel1.ResumeLayout(false);
            this.splBatteryV.Panel1.PerformLayout();
            this.splBatteryV.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splBatteryV)).EndInit();
            this.splBatteryV.ResumeLayout(false);
            this.splTempurature.Panel1.ResumeLayout(false);
            this.splTempurature.Panel1.PerformLayout();
            this.splTempurature.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splTempurature)).EndInit();
            this.splTempurature.ResumeLayout(false);
            this.splAltitude.Panel1.ResumeLayout(false);
            this.splAltitude.Panel1.PerformLayout();
            this.splAltitude.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splAltitude)).EndInit();
            this.splAltitude.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpData;
        private System.Windows.Forms.SplitContainer splBatteryV;
        private System.Windows.Forms.Label lblBatteryV;
        private RealTimeGraph rtgBatteryV;
        private System.Windows.Forms.SplitContainer splTempurature;
        private System.Windows.Forms.Label lblTempurature;
        private RealTimeGraph rtgTempurature;
        private System.Windows.Forms.SplitContainer splAltitude;
        private System.Windows.Forms.Label lblAltitude;
        private RealTimeGraph rtgAltitude;
    }
}