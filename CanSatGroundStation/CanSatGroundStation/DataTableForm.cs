using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CanSatGroundStation
{
    public partial class DataTableForm : Form
    {
        DataTable table = new DataTable();
        Manager manager;

        //<TEAM ID>,<PACKET COUNT>,<MISSION_TIME>,<ALT SENSOR>,<TEMP>,<VOLTAGE>,[<BONUS>]
        public DataTableForm(Manager manager)
        {
            InitializeComponent();
            this.manager = manager;

            table.Columns.Add("TEAM ID");
            table.Columns.Add("PACKET COUNT");
            table.Columns.Add("MISSION_TIME");
            table.Columns.Add("ALT SENSOR");
            table.Columns.Add("TEMPURATURE");
            table.Columns.Add("VOLTAGE");
            table.Columns.Add("BONUS");
        }

        private void DataTableForm_Load(object sender, EventArgs e)
        {
            dgvData.DataSource = table;
        }

        public void messageRecieved(object[] message)
        {
            if (chkAutoLoad.Checked == true)
            {
                UpdateDataTable(manager.readFromLog());
            }
        }

        public void UpdateDataTable(List<object[]> items)
        {
            table.Rows.Clear();
            for (int i = items.Count - 1; i >= 0; i--)
            {
                table.Rows.Add(items[i]);
            }
        }

        private void DataTableForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.MdiFormClosing)
            {
                this.Hide();
                e.Cancel = true;
            }
        }


        private void btnLoadLogData_Click(object sender, EventArgs e)
        {
            UpdateDataTable(manager.readFromLog());
        }

        private void DataTableForm_VisibleChanged(object sender, EventArgs e)
        {
            UpdateDataTable(manager.readFromLog());
        }


    }
}
