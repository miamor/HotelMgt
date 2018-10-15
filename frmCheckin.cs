
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
    public partial class frmCheckin
    {
        public frmCheckin()
        {
            InitializeComponent();
        }

        #region Default Instance

        private static frmCheckin defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmCheckin Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmCheckin();
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

        int guestID;
        int roomID;
        int trans_ID;

        public void frmCheckin_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {

        }

        private void clear_text()
        {
            txtGuestName.Clear();
            txtRoomNumber.Clear();
            txtRoomType.Clear();
            txtRoomRate.Clear();
            txtChildren.Text = "0";
            txtAdults.Text = "0";
            cboDiscount.Refresh();
            txtAdvance.Clear();
            txtSubTotal.Clear();
            txtTotal.Clear();
            lblDiscountID.Text = "";
            lblDiscountRate.Text = "";
            lblGuestID.Text = "";
            lblAdvancePayment.Text = "";
            lblNoOfOccupancy.Text = "0";

            DateTime time = DateTime.Now;
            string format = "MM/d/yyyy";
            txtCheckInDate.Text = time.ToString(format);
            dtCheckOutDate.Text = System.Convert.ToString(DateTime.Now.AddDays(1));
        }

        public void frmCheckin_Load(System.Object sender, System.EventArgs e)
        {
            clear_text();
            DateTime time = DateTime.Now;
            string format = "MM/d/yyyy";
            txtCheckInDate.Text = time.ToString(format);
            dtCheckOutDate.Text = System.Convert.ToString(DateTime.Now.AddDays(1));
            transID();
            pop_discount();
            display_checkin();
        }

        public void transID()
        {

        }

        public void bttnCheckIn_Click_1(System.Object sender, System.EventArgs e)
        {

        }

        public void bttnCancel_Click(System.Object sender, System.EventArgs e)
        {
            clear_text();
        }

        public void dtCheckOutDate_ValueChanged_1(System.Object sender, System.EventArgs e)
        {

        }

        public void bttnSearchGuest_Click(System.Object sender, System.EventArgs e)
        {
            // ds khách để chọn
            frmSelectGuest.Default.ShowDialog();
        }

        public void bttnSearchRoom_Click(System.Object sender, System.EventArgs e)
        {
            // ds phòng để chọn
            frmSelectRoom.Default.ShowDialog();
        }

        public void txtRoomRate_TextChanged(System.Object sender, System.EventArgs e)
        {

        }

        public void bttnAddAdult_Click(System.Object sender, System.EventArgs e)
        {

        }

        public void bttnAddChildren_Click(System.Object sender, System.EventArgs e)
        {

        }

        public void bttnSubAdult_Click(System.Object sender, System.EventArgs e)
        {

        }

        public void bttnSubChildren_Click(System.Object sender, System.EventArgs e)
        {

        }

        private void pop_discount()
        {
            Module1.con.Open();
            DataTable dt = new DataTable();
            Module1.rs = new OleDbDataAdapter("SELECT * FROM tblDiscount", Module1.con);
            Module1.rs.Fill(dt);

            cboDiscount.Items.Clear();
            int i = default(int);
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                cboDiscount.Items.Add(dt.Rows[i]["DiscountType"]);
            }
            Module1.rs.Dispose();
            Module1.con.Close();
        }

        public void cboDiscount_TextChanged(object sender, System.EventArgs e)
        {

        }

        public void txtAdvance_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

        }

        public void txtAdvance_TextChanged(System.Object sender, System.EventArgs e)
        {

        }

        private void display_checkin()
        {

        }

        public void cboDiscount_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {

        }
    }
}
