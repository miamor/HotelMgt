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
    [global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class frmRoom : System.Windows.Forms.Form
    {

        //Form overrides dispose to clean up the component list.
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
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
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoom));
            this.TabControl1 = new System.Windows.Forms.TabControl();
            base.Load += new System.EventHandler(frmRoom_Load);
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            this.bttnSave = new System.Windows.Forms.Button();
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            this.txtNoOfOccupancy = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtRoomRate = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.lvRoom = new System.Windows.Forms.ListView();
            this.lvRoom.DoubleClick += new System.EventHandler(this.lvRoom_DoubleClick);
            this.lvRoom.SelectedIndexChanged += new System.EventHandler(this.lvRoom_SelectedIndexChanged);
            this.ColumnHeader1 = (System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader());
            this.ColumnHeader2 = (System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader());
            this.ColumnHeader3 = (System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader());
            this.ColumnHeader4 = (System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader());
            this.Label5 = new System.Windows.Forms.Label();
            this.ColumnHeader5 = (System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader());
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.SuspendLayout();
            //
            //TabControl1
            //
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Location = new System.Drawing.Point(15, 14);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(481, 314);
            this.TabControl1.TabIndex = 0;
            //
            //TabPage1
            //
            this.TabPage1.Controls.Add(this.bttnCancel);
            this.TabPage1.Controls.Add(this.bttnSave);
            this.TabPage1.Controls.Add(this.txtNoOfOccupancy);
            this.TabPage1.Controls.Add(this.Label4);
            this.TabPage1.Controls.Add(this.txtRoomRate);
            this.TabPage1.Controls.Add(this.Label2);
            this.TabPage1.Controls.Add(this.txtRoomType);
            this.TabPage1.Controls.Add(this.Label1);
            this.TabPage1.Controls.Add(this.txtID);
            this.TabPage1.Controls.Add(this.Label3);
            this.TabPage1.Controls.Add(this.Label9);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(473, 288);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "New Room";
            this.TabPage1.UseVisualStyleBackColor = true;
            //
            //bttnCancel
            //
            this.bttnCancel.Location = new System.Drawing.Point(353, 238);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(100, 31);
            this.bttnCancel.TabIndex = 69;
            this.bttnCancel.Text = "&Cancel";
            this.bttnCancel.UseVisualStyleBackColor = true;
            //
            //bttnSave
            //
            this.bttnSave.Location = new System.Drawing.Point(247, 238);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(100, 31);
            this.bttnSave.TabIndex = 68;
            this.bttnSave.Text = "&Save";
            this.bttnSave.UseVisualStyleBackColor = true;
            //
            //txtNoOfOccupancy
            //
            this.txtNoOfOccupancy.Font = new System.Drawing.Font("Microsoft Sans Serif", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.txtNoOfOccupancy.Location = new System.Drawing.Point(170, 183);
            this.txtNoOfOccupancy.Multiline = true;
            this.txtNoOfOccupancy.Name = "txtNoOfOccupancy";
            this.txtNoOfOccupancy.Size = new System.Drawing.Size(74, 25);
            this.txtNoOfOccupancy.TabIndex = 66;
            //
            //Label4
            //
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.Label4.Location = new System.Drawing.Point(23, 186);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(141, 16);
            this.Label4.TabIndex = 67;
            this.Label4.Text = "Number of Occupancy";
            //
            //txtRoomRate
            //
            this.txtRoomRate.Font = new System.Drawing.Font("Microsoft Sans Serif", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.txtRoomRate.Location = new System.Drawing.Point(170, 141);
            this.txtRoomRate.Multiline = true;
            this.txtRoomRate.Name = "txtRoomRate";
            this.txtRoomRate.Size = new System.Drawing.Size(74, 25);
            this.txtRoomRate.TabIndex = 64;
            //
            //Label2
            //
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.Label2.Location = new System.Drawing.Point(23, 144);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(77, 16);
            this.Label2.TabIndex = 65;
            this.Label2.Text = "Room Rate";
            //
            //txtRoomType
            //
            this.txtRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.txtRoomType.Location = new System.Drawing.Point(170, 100);
            this.txtRoomType.Multiline = true;
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(170, 25);
            this.txtRoomType.TabIndex = 62;
            //
            //Label1
            //
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.Label1.Location = new System.Drawing.Point(23, 103);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(80, 16);
            this.Label1.TabIndex = 63;
            this.Label1.Text = "Room Type";
            //
            //txtID
            //
            this.txtID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.txtID.Location = new System.Drawing.Point(170, 60);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(74, 25);
            this.txtID.TabIndex = 60;
            //
            //Label3
            //
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.Label3.Location = new System.Drawing.Point(23, 63);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(96, 16);
            this.Label3.TabIndex = 61;
            this.Label3.Text = "Room Number";
            //
            //Label9
            //
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", (float)(14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.Label9.Location = new System.Drawing.Point(19, 22);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(113, 24);
            this.Label9.TabIndex = 59;
            this.Label9.Text = "New Room";
            //
            //TabPage2
            //
            this.TabPage2.Controls.Add(this.lvRoom);
            this.TabPage2.Controls.Add(this.Label5);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(473, 288);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Room List";
            this.TabPage2.UseVisualStyleBackColor = true;
            //
            //lvRoom
            //
            this.lvRoom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.ColumnHeader5, this.ColumnHeader1, this.ColumnHeader2, this.ColumnHeader3, this.ColumnHeader4 });
            this.lvRoom.FullRowSelect = true;
            this.lvRoom.GridLines = true;
            this.lvRoom.Location = new System.Drawing.Point(23, 55);
            this.lvRoom.Name = "lvRoom";
            this.lvRoom.Size = new System.Drawing.Size(429, 212);
            this.lvRoom.TabIndex = 61;
            this.lvRoom.UseCompatibleStateImageBehavior = false;
            this.lvRoom.View = System.Windows.Forms.View.Details;
            //
            //ColumnHeader1
            //
            this.ColumnHeader1.Text = "Room Number";
            this.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader1.Width = 80;
            //
            //ColumnHeader2
            //
            this.ColumnHeader2.Text = "Room Type";
            this.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader2.Width = 130;
            //
            //ColumnHeader3
            //
            this.ColumnHeader3.Text = "Room Rate";
            this.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader3.Width = 80;
            //
            //ColumnHeader4
            //
            this.ColumnHeader4.Text = "No Of Occupancy";
            this.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader4.Width = 100;
            //
            //Label5
            //
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", (float)(14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.Label5.Location = new System.Drawing.Point(19, 22);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(102, 24);
            this.Label5.TabIndex = 60;
            this.Label5.Text = "Room List";
            //
            //ColumnHeader5
            //
            this.ColumnHeader5.Text = "ID";
            this.ColumnHeader5.Width = 30;
            //
            //frmRoom
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF((float)(6.0F), (float)(13.0F));
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 344);
            this.Controls.Add(this.TabControl1);
            this.Icon = (System.Drawing.Icon)(resources.GetObject("$this.Icon"));
            this.Name = "frmRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room";
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
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtID;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtRoomType;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtNoOfOccupancy;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtRoomRate;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ListView lvRoom;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.ColumnHeader ColumnHeader4;
        internal System.Windows.Forms.Button bttnCancel;
        internal System.Windows.Forms.Button bttnSave;
        internal System.Windows.Forms.ColumnHeader ColumnHeader5;
    }

}
