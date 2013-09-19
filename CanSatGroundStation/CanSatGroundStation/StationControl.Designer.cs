namespace CanSatGroundStation
{
    partial class StationControl
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
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.stsStatus = new System.Windows.Forms.StatusStrip();
            this.lblMissionTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblState = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.btnTelemetry = new System.Windows.Forms.Button();
            this.btnGraphs = new System.Windows.Forms.Button();
            this.btnTable = new System.Windows.Forms.Button();
            this.stsStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Interval = 1000;
            // 
            // stsStatus
            // 
            this.stsStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMissionTime,
            this.lblState});
            this.stsStatus.Location = new System.Drawing.Point(0, 641);
            this.stsStatus.Name = "stsStatus";
            this.stsStatus.Size = new System.Drawing.Size(1095, 24);
            this.stsStatus.TabIndex = 2;
            this.stsStatus.Text = "statusStrip1";
            // 
            // lblMissionTime
            // 
            this.lblMissionTime.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblMissionTime.Name = "lblMissionTime";
            this.lblMissionTime.Size = new System.Drawing.Size(136, 19);
            this.lblMissionTime.Text = "MISSION TIME: 00:00:00";
            // 
            // lblState
            // 
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(36, 19);
            this.lblState.Text = "State:";
            // 
            // mnuMenu
            // 
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(1095, 24);
            this.mnuMenu.TabIndex = 4;
            // 
            // btnTelemetry
            // 
            this.btnTelemetry.Location = new System.Drawing.Point(0, 0);
            this.btnTelemetry.Name = "btnTelemetry";
            this.btnTelemetry.Size = new System.Drawing.Size(75, 24);
            this.btnTelemetry.TabIndex = 6;
            this.btnTelemetry.Text = "Telemetry";
            this.btnTelemetry.UseVisualStyleBackColor = true;
            this.btnTelemetry.Click += new System.EventHandler(this.btnTelemetry_Click);
            // 
            // btnGraphs
            // 
            this.btnGraphs.Location = new System.Drawing.Point(81, 0);
            this.btnGraphs.Name = "btnGraphs";
            this.btnGraphs.Size = new System.Drawing.Size(75, 24);
            this.btnGraphs.TabIndex = 7;
            this.btnGraphs.Text = "Graphs";
            this.btnGraphs.UseVisualStyleBackColor = true;
            this.btnGraphs.Click += new System.EventHandler(this.btnGraphs_Click);
            // 
            // btnTable
            // 
            this.btnTable.Location = new System.Drawing.Point(163, 0);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(75, 24);
            this.btnTable.TabIndex = 8;
            this.btnTable.Text = "Table";
            this.btnTable.UseVisualStyleBackColor = true;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // StationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1095, 665);
            this.Controls.Add(this.btnTable);
            this.Controls.Add(this.btnGraphs);
            this.Controls.Add(this.btnTelemetry);
            this.Controls.Add(this.stsStatus);
            this.Controls.Add(this.mnuMenu);
            this.ForeColor = System.Drawing.Color.Black;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMenu;
            this.Name = "StationControl";
            this.Text = "Carleton CanSat Ground Station 2014";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.stsStatus.ResumeLayout(false);
            this.stsStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.StatusStrip stsStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblMissionTime;
        private System.Windows.Forms.ToolStripStatusLabel lblState;
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.Button btnTelemetry;
        private System.Windows.Forms.Button btnGraphs;
        private System.Windows.Forms.Button btnTable;

    }
}

