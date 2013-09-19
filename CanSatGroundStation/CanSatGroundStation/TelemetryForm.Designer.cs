namespace CanSatGroundStation
{
    partial class TelemetryForm
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
            this.grpTelemetry = new System.Windows.Forms.GroupBox();
            this.tlpTelemetry = new System.Windows.Forms.TableLayoutPanel();
            this.lstTelemetry = new System.Windows.Forms.ListBox();
            this.pnlTelemetry = new System.Windows.Forms.Panel();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.btnReadLog = new System.Windows.Forms.Button();
            this.splSentTelemetry = new System.Windows.Forms.SplitContainer();
            this.txtSendTelem = new System.Windows.Forms.TextBox();
            this.btnSetTelemTemplate = new System.Windows.Forms.Button();
            this.btnSendTelem = new System.Windows.Forms.Button();
            this.lblTelemetryStatus = new System.Windows.Forms.Label();
            this.btnComConnect = new System.Windows.Forms.Button();
            this.cmbComPorts = new System.Windows.Forms.ComboBox();
            this.lblComPorts = new System.Windows.Forms.Label();
            this.grpTelemetry.SuspendLayout();
            this.tlpTelemetry.SuspendLayout();
            this.pnlTelemetry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splSentTelemetry)).BeginInit();
            this.splSentTelemetry.Panel1.SuspendLayout();
            this.splSentTelemetry.Panel2.SuspendLayout();
            this.splSentTelemetry.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTelemetry
            // 
            this.grpTelemetry.Controls.Add(this.tlpTelemetry);
            this.grpTelemetry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTelemetry.Location = new System.Drawing.Point(0, 0);
            this.grpTelemetry.Name = "grpTelemetry";
            this.grpTelemetry.Size = new System.Drawing.Size(575, 363);
            this.grpTelemetry.TabIndex = 4;
            this.grpTelemetry.TabStop = false;
            this.grpTelemetry.Text = "Telemetry";
            // 
            // tlpTelemetry
            // 
            this.tlpTelemetry.ColumnCount = 1;
            this.tlpTelemetry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTelemetry.Controls.Add(this.lstTelemetry, 0, 1);
            this.tlpTelemetry.Controls.Add(this.pnlTelemetry, 0, 0);
            this.tlpTelemetry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTelemetry.Location = new System.Drawing.Point(3, 16);
            this.tlpTelemetry.Name = "tlpTelemetry";
            this.tlpTelemetry.RowCount = 2;
            this.tlpTelemetry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpTelemetry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTelemetry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTelemetry.Size = new System.Drawing.Size(569, 344);
            this.tlpTelemetry.TabIndex = 1;
            // 
            // lstTelemetry
            // 
            this.lstTelemetry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lstTelemetry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTelemetry.FormattingEnabled = true;
            this.lstTelemetry.HorizontalScrollbar = true;
            this.lstTelemetry.Items.AddRange(new object[] {
            "Ground Station Start"});
            this.lstTelemetry.Location = new System.Drawing.Point(3, 83);
            this.lstTelemetry.Name = "lstTelemetry";
            this.lstTelemetry.Size = new System.Drawing.Size(563, 258);
            this.lstTelemetry.TabIndex = 1;
            // 
            // pnlTelemetry
            // 
            this.pnlTelemetry.Controls.Add(this.btnClearLog);
            this.pnlTelemetry.Controls.Add(this.btnReadLog);
            this.pnlTelemetry.Controls.Add(this.splSentTelemetry);
            this.pnlTelemetry.Controls.Add(this.lblTelemetryStatus);
            this.pnlTelemetry.Controls.Add(this.btnComConnect);
            this.pnlTelemetry.Controls.Add(this.cmbComPorts);
            this.pnlTelemetry.Controls.Add(this.lblComPorts);
            this.pnlTelemetry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTelemetry.Location = new System.Drawing.Point(3, 3);
            this.pnlTelemetry.Name = "pnlTelemetry";
            this.pnlTelemetry.Size = new System.Drawing.Size(563, 74);
            this.pnlTelemetry.TabIndex = 2;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearLog.Location = new System.Drawing.Point(404, 0);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(75, 23);
            this.btnClearLog.TabIndex = 6;
            this.btnClearLog.Text = "Clear Log";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // btnReadLog
            // 
            this.btnReadLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReadLog.Location = new System.Drawing.Point(485, 0);
            this.btnReadLog.Name = "btnReadLog";
            this.btnReadLog.Size = new System.Drawing.Size(75, 23);
            this.btnReadLog.TabIndex = 5;
            this.btnReadLog.Text = "Open Log";
            this.btnReadLog.UseVisualStyleBackColor = true;
            this.btnReadLog.Click += new System.EventHandler(this.btnReadLog_Click);
            // 
            // splSentTelemetry
            // 
            this.splSentTelemetry.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splSentTelemetry.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splSentTelemetry.Location = new System.Drawing.Point(0, 51);
            this.splSentTelemetry.Name = "splSentTelemetry";
            // 
            // splSentTelemetry.Panel1
            // 
            this.splSentTelemetry.Panel1.Controls.Add(this.txtSendTelem);
            // 
            // splSentTelemetry.Panel2
            // 
            this.splSentTelemetry.Panel2.Controls.Add(this.btnSetTelemTemplate);
            this.splSentTelemetry.Panel2.Controls.Add(this.btnSendTelem);
            this.splSentTelemetry.Size = new System.Drawing.Size(563, 23);
            this.splSentTelemetry.SplitterDistance = 446;
            this.splSentTelemetry.TabIndex = 4;
            // 
            // txtSendTelem
            // 
            this.txtSendTelem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSendTelem.Location = new System.Drawing.Point(3, 1);
            this.txtSendTelem.Name = "txtSendTelem";
            this.txtSendTelem.Size = new System.Drawing.Size(443, 20);
            this.txtSendTelem.TabIndex = 0;
            // 
            // btnSetTelemTemplate
            // 
            this.btnSetTelemTemplate.Location = new System.Drawing.Point(-1, -1);
            this.btnSetTelemTemplate.Name = "btnSetTelemTemplate";
            this.btnSetTelemTemplate.Size = new System.Drawing.Size(21, 23);
            this.btnSetTelemTemplate.TabIndex = 1;
            this.btnSetTelemTemplate.UseVisualStyleBackColor = true;
            // 
            // btnSendTelem
            // 
            this.btnSendTelem.Location = new System.Drawing.Point(23, -1);
            this.btnSendTelem.Name = "btnSendTelem";
            this.btnSendTelem.Size = new System.Drawing.Size(93, 23);
            this.btnSendTelem.TabIndex = 0;
            this.btnSendTelem.Text = "Send";
            this.btnSendTelem.UseVisualStyleBackColor = true;
            // 
            // lblTelemetryStatus
            // 
            this.lblTelemetryStatus.AutoSize = true;
            this.lblTelemetryStatus.Location = new System.Drawing.Point(3, 27);
            this.lblTelemetryStatus.Name = "lblTelemetryStatus";
            this.lblTelemetryStatus.Size = new System.Drawing.Size(112, 13);
            this.lblTelemetryStatus.TabIndex = 3;
            this.lblTelemetryStatus.Text = "Telemetry Status: N/A";
            // 
            // btnComConnect
            // 
            this.btnComConnect.Location = new System.Drawing.Point(200, 0);
            this.btnComConnect.Name = "btnComConnect";
            this.btnComConnect.Size = new System.Drawing.Size(75, 23);
            this.btnComConnect.TabIndex = 2;
            this.btnComConnect.Text = "Connect";
            this.btnComConnect.UseVisualStyleBackColor = true;
            // 
            // cmbComPorts
            // 
            this.cmbComPorts.FormattingEnabled = true;
            this.cmbComPorts.Location = new System.Drawing.Point(73, 0);
            this.cmbComPorts.Name = "cmbComPorts";
            this.cmbComPorts.Size = new System.Drawing.Size(121, 21);
            this.cmbComPorts.TabIndex = 1;
            // 
            // lblComPorts
            // 
            this.lblComPorts.AutoSize = true;
            this.lblComPorts.Location = new System.Drawing.Point(6, 5);
            this.lblComPorts.Name = "lblComPorts";
            this.lblComPorts.Size = new System.Drawing.Size(64, 13);
            this.lblComPorts.TabIndex = 0;
            this.lblComPorts.Text = "COM Ports: ";
            // 
            // TelemetryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 363);
            this.Controls.Add(this.grpTelemetry);
            this.MinimumSize = new System.Drawing.Size(466, 200);
            this.Name = "TelemetryForm";
            this.Text = "TemetryForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelemetryForm_FormClosing);
            this.Load += new System.EventHandler(this.TelemetryForm_Load);
            this.grpTelemetry.ResumeLayout(false);
            this.tlpTelemetry.ResumeLayout(false);
            this.pnlTelemetry.ResumeLayout(false);
            this.pnlTelemetry.PerformLayout();
            this.splSentTelemetry.Panel1.ResumeLayout(false);
            this.splSentTelemetry.Panel1.PerformLayout();
            this.splSentTelemetry.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splSentTelemetry)).EndInit();
            this.splSentTelemetry.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTelemetry;
        private System.Windows.Forms.TableLayoutPanel tlpTelemetry;
        private System.Windows.Forms.ListBox lstTelemetry;
        private System.Windows.Forms.Panel pnlTelemetry;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Button btnReadLog;
        private System.Windows.Forms.SplitContainer splSentTelemetry;
        private System.Windows.Forms.TextBox txtSendTelem;
        private System.Windows.Forms.Button btnSetTelemTemplate;
        private System.Windows.Forms.Button btnSendTelem;
        private System.Windows.Forms.Label lblTelemetryStatus;
        private System.Windows.Forms.Button btnComConnect;
        private System.Windows.Forms.ComboBox cmbComPorts;
        private System.Windows.Forms.Label lblComPorts;
    }
}