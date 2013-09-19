namespace ParserSim
{
    partial class MainForm
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
            this.lstValues = new System.Windows.Forms.ListBox();
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lstValues
            // 
            this.lstValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstValues.FormattingEnabled = true;
            this.lstValues.Location = new System.Drawing.Point(0, 0);
            this.lstValues.Name = "lstValues";
            this.lstValues.Size = new System.Drawing.Size(284, 262);
            this.lstValues.TabIndex = 0;
            // 
            // myTimer
            // 
            this.myTimer.Enabled = true;
            this.myTimer.Interval = 1000;
            this.myTimer.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lstValues);
            this.Name = "MainForm";
            this.Text = "Parser Simulator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstValues;
        private System.Windows.Forms.Timer myTimer;
    }
}

