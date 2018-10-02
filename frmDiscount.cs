
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
    public partial class frmDiscount
    {
        public frmDiscount()
        {
            InitializeComponent();

        }

        #region Default Instance

        private static frmDiscount defaultInstance;

        public static frmDiscount Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmDiscount();
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

        bool update_discount = false;
        int id;
        public void bttnCancel_Click(System.Object sender, System.EventArgs e)
        {
            clear_txt();
            update_discount = false;
        }

        public void frmDiscount_Load(System.Object sender, System.EventArgs e)
        {
            display_discount();
            clear_txt();
        }

        private void display_discount()
        {
            
        }

        public void TextBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            
        }

        public void bttnSave_Click(System.Object sender, System.EventArgs e)
        {
            

        }

        private void clear_txt()
        {
            txtType.Clear();
            txtRate.Clear();
            update_discount = false;
        }

        public void lvlDiscount_DoubleClick(object sender, System.EventArgs e)
        {
            
        }
    }
}
