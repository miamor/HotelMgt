// VBConversions Note: VB project level imports
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
// End of VB project level imports


namespace HBRS
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class frmGuest : System.Windows.Forms.Form
	{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			this.TabControl1 = new System.Windows.Forms.TabControl();
			base.Load += new System.EventHandler(frmGuest_Load);
			this.TabPage1 = new System.Windows.Forms.TabPage();
			this.bttnCancel = new System.Windows.Forms.Button();
			this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
			this.bttnSave = new System.Windows.Forms.Button();
			this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
			this.Label8 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.cboGender = new System.Windows.Forms.ComboBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.txtNumber = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.txtMName = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.txtLName = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.txtFName = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.TabPage2 = new System.Windows.Forms.TabPage();
			this.lvGuest = new System.Windows.Forms.ListView();
			this.Label9 = new System.Windows.Forms.Label();
			this.ColumnHeader1 = (System.Windows.Forms.ColumnHeader) (new System.Windows.Forms.ColumnHeader());
			this.ColumnHeader2 = (System.Windows.Forms.ColumnHeader) (new System.Windows.Forms.ColumnHeader());
			this.ColumnHeader3 = (System.Windows.Forms.ColumnHeader) (new System.Windows.Forms.ColumnHeader());
			this.ColumnHeader4 = (System.Windows.Forms.ColumnHeader) (new System.Windows.Forms.ColumnHeader());
			this.ColumnHeader5 = (System.Windows.Forms.ColumnHeader) (new System.Windows.Forms.ColumnHeader());
			this.ColumnHeader6 = (System.Windows.Forms.ColumnHeader) (new System.Windows.Forms.ColumnHeader());
			this.ColumnHeader7 = (System.Windows.Forms.ColumnHeader) (new System.Windows.Forms.ColumnHeader());
			this.TabControl1.SuspendLayout();
			this.TabPage1.SuspendLayout();
			this.TabPage2.SuspendLayout();
			this.SuspendLayout();
			//
			//TabControl1
			//
			this.TabControl1.Controls.Add(this.TabPage1);
			this.TabControl1.Controls.Add(this.TabPage2);
			this.TabControl1.Location = new System.Drawing.Point(10, 13);
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			this.TabControl1.Size = new System.Drawing.Size(679, 381);
			this.TabControl1.TabIndex = 0;
			//
			//TabPage1
			//
			this.TabPage1.Controls.Add(this.bttnCancel);
			this.TabPage1.Controls.Add(this.bttnSave);
			this.TabPage1.Controls.Add(this.Label8);
			this.TabPage1.Controls.Add(this.txtEmail);
			this.TabPage1.Controls.Add(this.Label7);
			this.TabPage1.Controls.Add(this.cboGender);
			this.TabPage1.Controls.Add(this.Label6);
			this.TabPage1.Controls.Add(this.txtNumber);
			this.TabPage1.Controls.Add(this.Label5);
			this.TabPage1.Controls.Add(this.txtAddress);
			this.TabPage1.Controls.Add(this.Label4);
			this.TabPage1.Controls.Add(this.txtMName);
			this.TabPage1.Controls.Add(this.Label2);
			this.TabPage1.Controls.Add(this.txtLName);
			this.TabPage1.Controls.Add(this.Label1);
			this.TabPage1.Controls.Add(this.txtFName);
			this.TabPage1.Controls.Add(this.Label3);
			this.TabPage1.Location = new System.Drawing.Point(4, 22);
			this.TabPage1.Name = "TabPage1";
			this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage1.Size = new System.Drawing.Size(671, 355);
			this.TabPage1.TabIndex = 0;
			this.TabPage1.Text = "New Guest";
			this.TabPage1.UseVisualStyleBackColor = true;
			//
			//bttnCancel
			//
			this.bttnCancel.Location = new System.Drawing.Point(544, 301);
			this.bttnCancel.Name = "bttnCancel";
			this.bttnCancel.Size = new System.Drawing.Size(100, 31);
			this.bttnCancel.TabIndex = 59;
			this.bttnCancel.Text = "&Cancel";
			this.bttnCancel.UseVisualStyleBackColor = true;
			//
			//bttnSave
			//
			this.bttnSave.Location = new System.Drawing.Point(438, 301);
			this.bttnSave.Name = "bttnSave";
			this.bttnSave.Size = new System.Drawing.Size(100, 31);
			this.bttnSave.TabIndex = 58;
			this.bttnSave.Text = "&Save";
			this.bttnSave.UseVisualStyleBackColor = true;
			//
			//Label8
			//
			this.Label8.AutoSize = true;
			this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label8.Location = new System.Drawing.Point(20, 27);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(167, 24);
			this.Label8.TabIndex = 57;
			this.Label8.Text = "New Guest Form";
			//
			//txtEmail
			//
			this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtEmail.Location = new System.Drawing.Point(157, 250);
			this.txtEmail.Multiline = true;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(210, 25);
			this.txtEmail.TabIndex = 55;
			//
			//Label7
			//
			this.Label7.AutoSize = true;
			this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label7.Location = new System.Drawing.Point(40, 256);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(96, 16);
			this.Label7.TabIndex = 56;
			this.Label7.Text = "Email Address";
			//
			//cboGender
			//
			this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboGender.FormattingEnabled = true;
			this.cboGender.Items.AddRange(new object[] {"Male", "Female"});
			this.cboGender.Location = new System.Drawing.Point(157, 223);
			this.cboGender.Name = "cboGender";
			this.cboGender.Size = new System.Drawing.Size(147, 21);
			this.cboGender.TabIndex = 54;
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label6.Location = new System.Drawing.Point(40, 224);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(53, 16);
			this.Label6.TabIndex = 53;
			this.Label6.Text = "Gender";
			//
			//txtNumber
			//
			this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtNumber.Location = new System.Drawing.Point(157, 190);
			this.txtNumber.Multiline = true;
			this.txtNumber.Name = "txtNumber";
			this.txtNumber.Size = new System.Drawing.Size(210, 25);
			this.txtNumber.TabIndex = 50;
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label5.Location = new System.Drawing.Point(40, 196);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(104, 16);
			this.Label5.TabIndex = 51;
			this.Label5.Text = "Contact Number";
			//
			//txtAddress
			//
			this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtAddress.Location = new System.Drawing.Point(157, 159);
			this.txtAddress.Multiline = true;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(210, 25);
			this.txtAddress.TabIndex = 48;
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label4.Location = new System.Drawing.Point(40, 165);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(59, 16);
			this.Label4.TabIndex = 49;
			this.Label4.Text = "Address";
			//
			//txtMName
			//
			this.txtMName.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtMName.Location = new System.Drawing.Point(157, 128);
			this.txtMName.Multiline = true;
			this.txtMName.Name = "txtMName";
			this.txtMName.Size = new System.Drawing.Size(210, 25);
			this.txtMName.TabIndex = 46;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label2.Location = new System.Drawing.Point(40, 134);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(89, 16);
			this.Label2.TabIndex = 47;
			this.Label2.Text = "Middle Name";
			//
			//txtLName
			//
			this.txtLName.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtLName.Location = new System.Drawing.Point(157, 97);
			this.txtLName.Multiline = true;
			this.txtLName.Name = "txtLName";
			this.txtLName.Size = new System.Drawing.Size(210, 25);
			this.txtLName.TabIndex = 44;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label1.Location = new System.Drawing.Point(40, 103);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(73, 16);
			this.Label1.TabIndex = 45;
			this.Label1.Text = "Last Name";
			//
			//txtFName
			//
			this.txtFName.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtFName.Location = new System.Drawing.Point(157, 66);
			this.txtFName.Multiline = true;
			this.txtFName.Name = "txtFName";
			this.txtFName.Size = new System.Drawing.Size(210, 25);
			this.txtFName.TabIndex = 42;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label3.Location = new System.Drawing.Point(40, 72);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(73, 16);
			this.Label3.TabIndex = 43;
			this.Label3.Text = "First Name";
			//
			//TabPage2
			//
			this.TabPage2.Controls.Add(this.lvGuest);
			this.TabPage2.Controls.Add(this.Label9);
			this.TabPage2.Location = new System.Drawing.Point(4, 22);
			this.TabPage2.Name = "TabPage2";
			this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage2.Size = new System.Drawing.Size(671, 355);
			this.TabPage2.TabIndex = 1;
			this.TabPage2.Text = "Guest List";
			this.TabPage2.UseVisualStyleBackColor = true;
			//
			//lvGuest
			//
			this.lvGuest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {this.ColumnHeader1, this.ColumnHeader2, this.ColumnHeader3, this.ColumnHeader4, this.ColumnHeader5, this.ColumnHeader6, this.ColumnHeader7});
			this.lvGuest.FullRowSelect = true;
			this.lvGuest.GridLines = true;
			this.lvGuest.Location = new System.Drawing.Point(24, 61);
			this.lvGuest.Name = "lvGuest";
			this.lvGuest.Size = new System.Drawing.Size(623, 241);
			this.lvGuest.TabIndex = 59;
			this.lvGuest.UseCompatibleStateImageBehavior = false;
			this.lvGuest.View = System.Windows.Forms.View.Details;
			//
			//Label9
			//
			this.Label9.AutoSize = true;
			this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label9.Location = new System.Drawing.Point(20, 27);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(101, 24);
			this.Label9.TabIndex = 58;
			this.Label9.Text = "Guest List";
			//
			//ColumnHeader1
			//
			this.ColumnHeader1.Text = "ID";
			//
			//ColumnHeader2
			//
			this.ColumnHeader2.Text = "First Name";
			this.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ColumnHeader2.Width = 150;
			//
			//ColumnHeader3
			//
			this.ColumnHeader3.Text = "Middle Name";
			this.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ColumnHeader3.Width = 150;
			//
			//ColumnHeader4
			//
			this.ColumnHeader4.Text = "Last Name";
			this.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ColumnHeader4.Width = 150;
			//
			//ColumnHeader5
			//
			this.ColumnHeader5.Text = "Address";
			this.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ColumnHeader5.Width = 150;
			//
			//ColumnHeader6
			//
			this.ColumnHeader6.Text = "Contact Number";
			this.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ColumnHeader6.Width = 100;
			//
			//ColumnHeader7
			//
			this.ColumnHeader7.Text = "Status";
			this.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ColumnHeader7.Width = 80;
			//
			//frmGuest
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(703, 408);
			this.Controls.Add(this.TabControl1);
			this.Name = "frmGuest";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Guest";
			this.TabControl1.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			this.TabPage1.PerformLayout();
			this.TabPage2.ResumeLayout(false);
			this.TabPage2.PerformLayout();
			this.ResumeLayout(false);
			
		}
		internal System.Windows.Forms.TabControl TabControl1;
		internal System.Windows.Forms.TabPage TabPage1;
		internal System.Windows.Forms.TabPage TabPage2;
		internal System.Windows.Forms.TextBox txtLName;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox txtFName;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.TextBox txtMName;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox txtEmail;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.ComboBox cboGender;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.TextBox txtNumber;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.TextBox txtAddress;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.ListView lvGuest;
		internal System.Windows.Forms.Button bttnCancel;
		internal System.Windows.Forms.Button bttnSave;
		internal System.Windows.Forms.ColumnHeader ColumnHeader1;
		internal System.Windows.Forms.ColumnHeader ColumnHeader2;
		internal System.Windows.Forms.ColumnHeader ColumnHeader3;
		internal System.Windows.Forms.ColumnHeader ColumnHeader4;
		internal System.Windows.Forms.ColumnHeader ColumnHeader5;
		internal System.Windows.Forms.ColumnHeader ColumnHeader6;
		internal System.Windows.Forms.ColumnHeader ColumnHeader7;
	}
	
}
