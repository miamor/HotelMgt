
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Linq;
using System;
using System.Collections;
using System.Xml.Linq;
using System.Windows.Forms;


using System.Data.OleDb;

namespace HBRS
{
    public partial class frmSelectGuest
    {
        public frmSelectGuest()
        {
            InitializeComponent();

        }

        #region Default Instance

        private static frmSelectGuest defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmSelectGuest Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmSelectGuest();
                    defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
                }

                return defaultInstance;
            }
        }

        static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
        {
            defaultInstance = null;
        }

        #endregion

        public void frmSelectGuest_Load(System.Object sender, System.EventArgs e)
        {
            display_guest();
        }
        private void display_guest()
        {
            Module1.con.Open();
            DataTable Dt = new DataTable("tblGuest");
            OleDbDataAdapter rs = default(OleDbDataAdapter);

            rs = new OleDbDataAdapter("Select * from tblGuest WHERE Remarks = \'Available\' ", Module1.con);

            rs.Fill(Dt);
            int indx = default(int);
            lvGuest.Items.Clear();
            for (indx = 0; indx <= Dt.Rows.Count - 1; indx++)
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = (Dt.Rows[indx]["ID"]).ToString();
                lv.SubItems.Add(Dt.Rows[indx]["GuestFName"].ToString());
                lv.SubItems.Add(Dt.Rows[indx]["GuestMName"].ToString());
                lv.SubItems.Add(Dt.Rows[indx]["GuestLName"].ToString());
                lvGuest.Items.Add(lv);
            }
            rs.Dispose();
            Module1.con.Close();
        }

        public void lvGuest_DoubleClick(object sender, System.EventArgs e)
        {
            frmCheckin.Default.lblGuestID.Text = lvGuest.SelectedItems[0].Text;
            frmCheckin.Default.txtGuestName.Text = lvGuest.SelectedItems[0].SubItems[1].Text + " " + lvGuest.SelectedItems[0].SubItems[2].Text + " " + lvGuest.SelectedItems[0].SubItems[3].Text;

            frmReserve.Default.lblGuestID.Text = lvGuest.SelectedItems[0].Text;
            frmReserve.Default.txtGuestName.Text = lvGuest.SelectedItems[0].SubItems[1].Text + " " + lvGuest.SelectedItems[0].SubItems[2].Text + " " + lvGuest.SelectedItems[0].SubItems[3].Text;
            this.Close();
        }
    }
}
