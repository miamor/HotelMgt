
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
            // list rooms
        }

        public void bttnCancel_Click(System.Object sender, System.EventArgs e)
        {

        }

        public void bttnSave_Click(System.Object sender, System.EventArgs e)
        {
            // save room
        }

        public void lvRoom_DoubleClick(object sender, System.EventArgs e)
        {

        }

        public void lvRoom_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {

        }
    }
}
