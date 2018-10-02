
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
        public void frmCheckin_Load(System.Object sender, System.EventArgs e)
        {

        }

        public void transID()
        {

        }

        public void bttnCheckIn_Click_1(System.Object sender, System.EventArgs e)
        {

        }

        public void bttnCancel_Click(System.Object sender, System.EventArgs e)
        {

        }

        public void dtCheckOutDate_ValueChanged_1(System.Object sender, System.EventArgs e)
        {

        }

        public void bttnSearchGuest_Click(System.Object sender, System.EventArgs e)
        {
            // cần ds khách để chọn
        }

        public void bttnSearchRoom_Click(System.Object sender, System.EventArgs e)
        {
            // cần ds phòng để chọn
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
