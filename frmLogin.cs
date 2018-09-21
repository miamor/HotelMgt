
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
using Microsoft.VisualBasic.CompilerServices;

namespace HBRS
{
	public partial class frmLogin
	{
		public frmLogin()
		{
			InitializeComponent();
			
		}

        #region Default Instance

        private static frmLogin defaultInstance;

        public static frmLogin Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmLogin();
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
		public void OK_Click(System.Object sender, System.EventArgs e)
		{
			
			if (UsernameTextBox.Text.Trim() == "" || PasswordTextBox.Text.Trim() == "")
			{
				Interaction.MsgBox("Please Enter Both Fields!", Constants.vbInformation, "Note");
			}
			else
			{
				Module1.con.Open();
				var sql = "SELECT * FROM tblUser WHERE username = \'" + Module1.SafeSqlLiteral(UsernameTextBox.Text, 2) + "\' AND password = \'" + Module1.SafeSqlLiteral(PasswordTextBox.Text, 2) + "\'";
				
				var cmd = new OleDbCommand(sql, Module1.con);
				OleDbDataReader dr = cmd.ExecuteReader();
				
				try
				{
					if (dr.Read() == false)
					{
						Interaction.MsgBox("Login Failed!", Constants.vbCritical, "Note");
					}
					else
					{
						Interaction.MsgBox("Login Successful!", Constants.vbInformation, "Note");
						frmMain.Default.status.Items[0].Text = "Login as : " + UsernameTextBox.Text.Trim();
						DateTime datenow = DateTime.Now;
						frmMain.Default.status.Items[2].Text = "Date and Time : " + datenow.ToString("MMMM dd, yyyy") + " " + DateAndTime.TimeOfDay;
						Module1.con.Close();
						this.Hide();
						frmMain.Default.ShowDialog();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
					
				}
				
				Module1.con.Close();
			}
			
		}
		
		public void Cancel_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
			ProjectData.EndApp();
		}

	}
	
}
