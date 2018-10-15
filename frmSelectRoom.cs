
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
    public partial class frmSelectRoom
    {
        public frmSelectRoom()
        {
            InitializeComponent();

        }

        #region Default Instance

        private static frmSelectRoom defaultInstance;

        public static frmSelectRoom Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmSelectRoom();
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

        public void frmSelectRoom_Load(System.Object sender, System.EventArgs e)
        {
            display_room();
        }
        private void display_room()
        {
            Module1.con.Open();
            DataTable Dt = new DataTable("tblRoom");
            OleDbDataAdapter rs = default(OleDbDataAdapter);

            rs = new OleDbDataAdapter("Select * from tblRoom WHERE Status = \'Available\'", Module1.con);

            rs.Fill(Dt);
            int indx = default(int);
            lvRoom.Items.Clear();
            for (indx = 0; indx <= Dt.Rows.Count - 1; indx++)
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = (string)(Dt.Rows[indx]["RoomNumber"]).ToString();
                lv.SubItems.Add(Dt.Rows[indx]["RoomType"].ToString());
                lv.SubItems.Add(Dt.Rows[indx]["RoomRate"].ToString());
                lv.SubItems.Add(Dt.Rows[indx]["NoOfOccupancy"].ToString());
                lvRoom.Items.Add(lv);
            }
            rs.Dispose();
            Module1.con.Close();
        }

        public void lvRoom_DoubleClick(object sender, System.EventArgs e)
        {
            frmCheckin.Default.txtRoomNumber.Text = lvRoom.SelectedItems[0].Text;
            frmCheckin.Default.txtRoomType.Text = lvRoom.SelectedItems[0].SubItems[1].Text;
            frmCheckin.Default.txtRoomRate.Text = lvRoom.SelectedItems[0].SubItems[2].Text;
            frmCheckin.Default.lblNoOfOccupancy.Text = lvRoom.SelectedItems[0].SubItems[3].Text;

            frmReserve.Default.txtRoomNumber.Text = lvRoom.SelectedItems[0].Text;
            frmReserve.Default.txtRoomType.Text = lvRoom.SelectedItems[0].SubItems[1].Text;
            frmReserve.Default.txtRoomRate.Text = lvRoom.SelectedItems[0].SubItems[2].Text;
            frmReserve.Default.lblNoOfOccupancy.Text = lvRoom.SelectedItems[0].SubItems[3].Text;

            this.Close();
        }

        public void lvRoom_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {

        }
    }
}
