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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rtgTemp = new CanSatGroundStation.RealTimeGraph();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rtgAlt = new CanSatGroundStation.RealTimeGraph();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.rtgBat = new CanSatGroundStation.RealTimeGraph();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.rtgLux = new CanSatGroundStation.RealTimeGraph();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 29);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(527, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Show Chart";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Payload",
            "Container",
            "Both"});
            this.comboBox1.Location = new System.Drawing.Point(602, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.rtgTemp);
            this.panel2.Location = new System.Drawing.Point(12, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 172);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(113, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Temperature (°C)";
            // 
            // rtgTemp
            // 
            this.rtgTemp.BackColor = System.Drawing.Color.Black;
            this.rtgTemp.ForeColor = System.Drawing.Color.White;
            this.rtgTemp.Location = new System.Drawing.Point(12, 27);
            this.rtgTemp.Name = "rtgTemp";
            this.rtgTemp.Size = new System.Drawing.Size(336, 142);
            this.rtgTemp.TabIndex = 0;
            this.rtgTemp.YMaximum = 100D;
            this.rtgTemp.YMinimum = 0D;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.rtgAlt);
            this.panel3.Location = new System.Drawing.Point(400, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(338, 172);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(126, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Altitude (m)";
            // 
            // rtgAlt
            // 
            this.rtgAlt.BackColor = System.Drawing.Color.Black;
            this.rtgAlt.ForeColor = System.Drawing.Color.White;
            this.rtgAlt.Location = new System.Drawing.Point(19, 27);
            this.rtgAlt.Name = "rtgAlt";
            this.rtgAlt.Size = new System.Drawing.Size(315, 142);
            this.rtgAlt.TabIndex = 1;
            this.rtgAlt.YMaximum = 1500D;
            this.rtgAlt.YMinimum = 400D;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.rtgBat);
            this.panel4.Location = new System.Drawing.Point(12, 233);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(366, 174);
            this.panel4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(113, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Batetry Voltage (V)";
            // 
            // rtgBat
            // 
            this.rtgBat.BackColor = System.Drawing.Color.Black;
            this.rtgBat.ForeColor = System.Drawing.Color.White;
            this.rtgBat.Location = new System.Drawing.Point(12, 29);
            this.rtgBat.Name = "rtgBat";
            this.rtgBat.Size = new System.Drawing.Size(336, 142);
            this.rtgBat.TabIndex = 1;
            this.rtgBat.YMaximum = 10D;
            this.rtgBat.YMinimum = 0D;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.rtgLux);
            this.panel5.Location = new System.Drawing.Point(400, 233);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(338, 174);
            this.panel5.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(126, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Light Intensity (Lux)";
            // 
            // rtgLux
            // 
            this.rtgLux.BackColor = System.Drawing.Color.Black;
            this.rtgLux.ForeColor = System.Drawing.Color.White;
            this.rtgLux.Location = new System.Drawing.Point(19, 29);
            this.rtgLux.Name = "rtgLux";
            this.rtgLux.Size = new System.Drawing.Size(315, 142);
            this.rtgLux.TabIndex = 2;
            this.rtgLux.YMaximum = 150000D;
            this.rtgLux.YMinimum = 0D;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel6.Location = new System.Drawing.Point(-1, 429);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(750, 13);
            this.panel6.TabIndex = 5;
            // 
            // DataGraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(747, 441);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DataGraphForm";
            this.Text = "Telemetry Chart";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataGraphForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private RealTimeGraph rtgTemp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private RealTimeGraph rtgAlt;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private RealTimeGraph rtgBat;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private RealTimeGraph rtgLux;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;

    }
}