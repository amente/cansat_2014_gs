namespace CanSatGroundStation
{
    partial class ContainerGraphForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTmp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtgTemp = new CanSatGroundStation.RealTimeGraph();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAlt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtgAlt = new CanSatGroundStation.RealTimeGraph();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 29);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblTmp);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.rtgTemp);
            this.panel2.Location = new System.Drawing.Point(377, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 153);
            this.panel2.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.GreenYellow;
            this.label8.Location = new System.Drawing.Point(277, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 26);
            this.label8.TabIndex = 5;
            this.label8.Text = "°c";
            // 
            // lblTmp
            // 
            this.lblTmp.AutoSize = true;
            this.lblTmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTmp.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblTmp.Location = new System.Drawing.Point(220, 2);
            this.lblTmp.Name = "lblTmp";
            this.lblTmp.Size = new System.Drawing.Size(60, 26);
            this.lblTmp.TabIndex = 4;
            this.lblTmp.Text = "00.0 ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(110, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Temperature ";
            // 
            // rtgTemp
            // 
            this.rtgTemp.BackColor = System.Drawing.Color.Black;
            this.rtgTemp.ForeColor = System.Drawing.Color.White;
            this.rtgTemp.Location = new System.Drawing.Point(0, 30);
            this.rtgTemp.Name = "rtgTemp";
            this.rtgTemp.numXLables = 4;
            this.rtgTemp.numYLables = 5;
            this.rtgTemp.Size = new System.Drawing.Size(280, 125);
            this.rtgTemp.TabIndex = 0;
            this.rtgTemp.YMaximum = 100D;
            this.rtgTemp.YMinimum = 0D;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.lblAlt);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.rtgAlt);
            this.panel3.Location = new System.Drawing.Point(15, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 452);
            this.panel3.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.GreenYellow;
            this.label9.Location = new System.Drawing.Point(271, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 26);
            this.label9.TabIndex = 6;
            this.label9.Text = "m";
            // 
            // lblAlt
            // 
            this.lblAlt.AutoSize = true;
            this.lblAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlt.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblAlt.Location = new System.Drawing.Point(202, 4);
            this.lblAlt.Name = "lblAlt";
            this.lblAlt.Size = new System.Drawing.Size(66, 26);
            this.lblAlt.TabIndex = 5;
            this.lblAlt.Text = "000.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(107, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Altitude";
            // 
            // rtgAlt
            // 
            this.rtgAlt.BackColor = System.Drawing.Color.Black;
            this.rtgAlt.ForeColor = System.Drawing.Color.White;
            this.rtgAlt.Location = new System.Drawing.Point(-3, 27);
            this.rtgAlt.Name = "rtgAlt";
            this.rtgAlt.numXLables = 4;
            this.rtgAlt.numYLables = 11;
            this.rtgAlt.Size = new System.Drawing.Size(359, 433);
            this.rtgAlt.TabIndex = 1;
            this.rtgAlt.YMaximum = 1000D;
            this.rtgAlt.YMinimum = 0D;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel6.Location = new System.Drawing.Point(-1, 565);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(750, 13);
            this.panel6.TabIndex = 5;
            // 
            // ContainerGraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(691, 499);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ContainerGraphForm";
            this.Text = "Container Plot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataGraphForm_FormClosing);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTmp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAlt;

    }
}