namespace CanSatGroundStation
{
    partial class DataTableForm
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnLoadLogData = new System.Windows.Forms.Button();
            this.chkAutoLoad = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 24);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(751, 410);
            this.dgvData.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(751, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnLoadLogData
            // 
            this.btnLoadLogData.Location = new System.Drawing.Point(0, 0);
            this.btnLoadLogData.Name = "btnLoadLogData";
            this.btnLoadLogData.Size = new System.Drawing.Size(102, 24);
            this.btnLoadLogData.TabIndex = 2;
            this.btnLoadLogData.Text = "Load Log Data";
            this.btnLoadLogData.UseVisualStyleBackColor = true;
            this.btnLoadLogData.Click += new System.EventHandler(this.btnLoadLogData_Click);
            // 
            // chkAutoLoad
            // 
            this.chkAutoLoad.AutoSize = true;
            this.chkAutoLoad.Location = new System.Drawing.Point(108, 5);
            this.chkAutoLoad.Name = "chkAutoLoad";
            this.chkAutoLoad.Size = new System.Drawing.Size(75, 17);
            this.chkAutoLoad.TabIndex = 3;
            this.chkAutoLoad.Text = "Auto Load";
            this.chkAutoLoad.UseVisualStyleBackColor = true;
            // 
            // DataTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 434);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.chkAutoLoad);
            this.Controls.Add(this.btnLoadLogData);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DataTableForm";
            this.Text = "DataTable";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataTableForm_FormClosing);
            this.Load += new System.EventHandler(this.DataTableForm_Load);
            this.VisibleChanged += new System.EventHandler(this.DataTableForm_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnLoadLogData;
        private System.Windows.Forms.CheckBox chkAutoLoad;
    }
}