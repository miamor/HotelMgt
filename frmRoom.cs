
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
    public partial class frmRoom
    {
        public frmRoom()
        {
            InitializeComponent();


        }

        #region Default Instance

        private static frmRoom defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmRoom Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmRoom();
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
        int id;
        public void frmRoom_Load(System.Object sender, System.EventArgs e)
        {
            TabControl1.SelectTab(0);
            display_room();
        }
        private void display_room()
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
                lv.Text = (string)(Dt.Rows[indx]["ID"]).ToString();
                lv.SubItems.Add(Dt.Rows[indx]["RoomNumber"].ToString());
                lv.SubItems.Add(Dt.Rows[indx]["RoomType"].ToString());
                lv.SubItems.Add(Dt.Rows[indx]["RoomRate"].ToString());
                lv.SubItems.Add(Dt.Rows[indx]["NoOfOccupancy"].ToString());
                lvRoom.Items.Add(lv);
            }
            rs.Dispose();
            Module1.con.Close();
        }

        public void bttnCancel_Click(System.Object sender, System.EventArgs e)
        {
            txtID.Clear();
            txtRoomType.Clear();
            txtRoomRate.Clear();
            txtNoOfOccupancy.Clear();
            bttnSave.Text = "&Save";
        }

        public void bttnSave_Click(System.Object sender, System.EventArgs e)
        {
            Module1.con.Open();
            string num = txtID.Text.Trim();
            string type = txtRoomType.Text.Trim();
            string rate = txtRoomRate.Text.Trim();
            string occupancy = txtNoOfOccupancy.Text.Trim();
            string stat = "Available";
            if (type == null || rate == null || occupancy == null)
            {
                Interaction.MsgBox("Please Fill All Fields", Constants.vbInformation, "Note");
            }
            else
            {
                if (bttnSave.Text == "&Save")
                {
                    var sql = "SELECT * FROM tblRoom WHERE RoomNumber = " + Module1.SafeSqlLiteral(num, 2) + "";

                    var cmd = new OleDbCommand(sql, Module1.con);
                    OleDbDataReader dr = cmd.ExecuteReader();

                    try
                    {
                        if (dr.Read() == false)
                        {
                            OleDbCommand add_room = new OleDbCommand("INSERT INTO tblRoom(RoomNumber,RoomType,RoomRate,NoOfOccupancy,Status) values (\'" +
                            Module1.SafeSqlLiteral(num, 2) + "\',\'" +
                            Module1.SafeSqlLiteral(type, 2) + "\',\'" +
                            Module1.SafeSqlLiteral(rate, 2) + "\',\'" +
                            Module1.SafeSqlLiteral(occupancy, 2) + "\',\'" +
                            stat + "\')", Module1.con);
                            add_room.ExecuteNonQuery();
                            add_room.Dispose();
                            Interaction.MsgBox("Room Added!", Constants.vbInformation, "Note");
                            txtID.Clear();
                            txtRoomType.Clear();
                            txtRoomRate.Clear();
                            txtNoOfOccupancy.Clear();
                        }
                        else
                        {
                            Interaction.MsgBox("Room Number Existed!", Constants.vbExclamation, "Note");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    OleDbCommand update_room = new OleDbCommand("UPDATE tblRoom SET RoomNumber= \'" + Module1.SafeSqlLiteral(num, 2) + "\',RoomType = \'" + Module1.SafeSqlLiteral(type, 2) + "\',RoomRate = \'" + Module1.SafeSqlLiteral(rate, 2) + "\',NoOfOccupancy = \'" + Module1.SafeSqlLiteral(occupancy, 2) + "\' WHERE ID = " + id.ToString() + "", Module1.con);
                    update_room.ExecuteNonQuery();
                    update_room.Dispose();
                    Interaction.MsgBox("Room Saved!", Constants.vbInformation, "Note");
                    bttnSave.Text = "&Save";
                    txtID.Clear();
                    txtRoomType.Clear();
                    txtRoomRate.Clear();
                    txtNoOfOccupancy.Clear();
                }
            }
            Module1.con.Close();
            display_room();
        }

        public void lvRoom_DoubleClick(object sender, System.EventArgs e)
        {
            string a = System.Convert.ToString(Interaction.MsgBox("Update selected Item?", (int)Constants.vbQuestion + Constants.vbYesNo, "Update Room"));
            if (a == Constants.vbYes.ToString())
            {
                id = int.Parse(lvRoom.SelectedItems[0].Text);
                txtID.Text = lvRoom.SelectedItems[0].SubItems[1].Text;
                txtRoomType.Text = lvRoom.SelectedItems[0].SubItems[2].Text;
                txtRoomRate.Text = lvRoom.SelectedItems[0].SubItems[3].Text;
                txtNoOfOccupancy.Text = lvRoom.SelectedItems[0].SubItems[4].Text;

                TabControl1.SelectTab(0);
                bttnSave.Text = "&Update";
            }
        }

        public void lvRoom_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {

        }
    }
}
