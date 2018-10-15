
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
    public partial class frmRoomListMonitor
    {
        public frmRoomListMonitor()
        {
            InitializeComponent();

        }

        #region Default Instance

        private static frmRoomListMonitor defaultInstance;

        public static frmRoomListMonitor Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmRoomListMonitor();
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

        public void frmRoomListMonitor_Load(System.Object sender, System.EventArgs e)
        {
            Module1.con.Open();
            DataTable Dt = new DataTable("tblRoom");
            OleDbDataAdapter rs = default(OleDbDataAdapter);

            rs = new OleDbDataAdapter("Select * from tblRoom", Module1.con);

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
                lv.SubItems.Add(Dt.Rows[indx]["Status"].ToString());
                lvRoom.Items.Add(lv);
            }
            rs.Dispose();
            Module1.con.Close();
        }
    }
}
