
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
    public partial class frmCheckinListMonitor
    {
        public frmCheckinListMonitor()
        {
            InitializeComponent();

        }

        #region Default Instance

        private static frmCheckinListMonitor defaultInstance;

        public static frmCheckinListMonitor Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmCheckinListMonitor();
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

        public void frmCheckinListMonitor_Load(System.Object sender, System.EventArgs e)
        {
            Module1.con.Open();
            DataTable Dt = new DataTable("tblTransaction");
            Module1.rs = new OleDbDataAdapter("Select * from tblTransaction, tblGuest, tblDiscount, tblRoom WHERE tblTransaction.GuestID = tblGuest.ID AND tblTransaction.DiscountID = tblDiscount.ID AND tblTransaction.RoomNum = tblRoom.RoomNumber AND tblTransaction.Remarks = \'Checkin\' AND tblTransaction.Status = \'Active\'", Module1.con);
            Module1.rs.Fill(Dt);

            int indx = default(int);
            lvlcheckin.Items.Clear();
            for (indx = 0; indx <= Dt.Rows.Count - 1; indx++)
            {
                ListViewItem lv = new ListViewItem();
                TimeSpan getdate = new TimeSpan();
                int days = default(int);
                int rate = default(int);
                double subtotal = default(double);
                double total = default(double);
                double advance = default(double);
                double discount = default(double);

                int value = (int)(Conversion.Val(Dt.Rows[indx]["TransID"]));

                lv.Text = "TransID - " + value.ToString("0000");
                lv.SubItems.Add(Dt.Rows[indx]["GuestFName"] + " " + Dt.Rows[indx]["GuestLName"]);
                lv.SubItems.Add(Dt.Rows[indx]["RoomNum"].ToString());

                rate = System.Convert.ToInt32(Dt.Rows[indx]["RoomRate"]);

                lv.SubItems.Add(Dt.Rows[indx]["CheckInDate"].ToString());
                lv.SubItems.Add(Dt.Rows[indx]["CheckOutDate"].ToString());

                dtIn.Value = System.Convert.ToDateTime(Dt.Rows[indx]["CheckOutDate"]);
                dtOut.Value = System.Convert.ToDateTime(Dt.Rows[indx]["CheckInDate"]);

                getdate = dtIn.Value - dtOut.Value;
                days = getdate.Days;

                lv.SubItems.Add(days.ToString());
                lv.SubItems.Add(Dt.Rows[indx]["NoOfChild"].ToString());
                lv.SubItems.Add(Dt.Rows[indx]["NoOfAdult"].ToString());
                advance = System.Convert.ToDouble(Dt.Rows[indx]["AdvancePayment"]);
                lv.SubItems.Add("Php " + (advance).ToString("N"));
                lv.SubItems.Add(Dt.Rows[indx]["DiscountType"].ToString());

                discount = Conversion.Val(Dt.Rows[indx]["DiscountRate"]);

                subtotal = (days * rate) - ((days * rate) * discount);
                total = double.Parse((Conversion.Val(subtotal.ToString()) - Conversion.Val(Dt.Rows[indx]["AdvancePayment"])).ToString("N"));

                if (Conversion.Val(subtotal.ToString()) > Conversion.Val(Dt.Rows[indx]["AdvancePayment"]))
                {
                    lv.SubItems.Add("Php " + Conversion.Val(total.ToString()).ToString("N"));
                }
                else
                {
                    lv.SubItems.Add("Php 0.00");
                }

                lvlcheckin.Items.Add(lv);
            }
            Module1.rs.Dispose();
            Module1.con.Close();
        }
    }
}
