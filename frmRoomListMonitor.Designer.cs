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
    public partial class frmRoomListMonitor : System.Windows.Forms.Form
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
            this.lvRoom = new System.Windows.Forms.ListView();
            base.Load += new System.EventHandler(frmRoomListMonitor_Load);
            this.ColumnHeader1 = (System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader());
            this.ColumnHeader2 = (System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader());
            this.ColumnHeader3 = (System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader());
            this.ColumnHeader4 = (System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader());
            this.ColumnHeader5 = (System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader());
            this.SuspendLayout();
            //
            //lvRoom
            //
            this.lvRoom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.ColumnHeader1, this.ColumnHeader2, this.ColumnHeader3, this.ColumnHeader4, this.ColumnHeader5 });
            this.lvRoom.FullRowSelect = true;
            this.lvRoom.GridLines = true;
            this.lvRoom.Location = new System.Drawing.Point(12, 24);
            this.lvRoom.Name = "lvRoom";
            this.lvRoom.Size = new System.Drawing.Size(526, 212);
            this.lvRoom.TabIndex = 62;
            this.lvRoom.UseCompatibleStateImageBehavior = false;
            this.lvRoom.View = System.Windows.Forms.View.Details;
            //
            //ColumnHeader1
            //
            this.ColumnHeader1.Text = "Room Number";
            this.ColumnHeader1.Width = 85;
            //
            //ColumnHeader2
            //
            this.ColumnHeader2.Text = "Room Type";
            this.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader2.Width = 150;
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
            this.ColumnHeader4.Width = 105;
            //
            //ColumnHeader5
            //
            this.ColumnHeader5.Text = "Status";
            this.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader5.Width = 100;
            //
            //frmRoomListMonitor
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF((float)(6.0F), (float)(13.0F));
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 247);
            this.Controls.Add(this.lvRoom);
            this.Name = "frmRoomListMonitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room List";
            this.ResumeLayout(false);

        }
        internal System.Windows.Forms.ListView lvRoom;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.ColumnHeader ColumnHeader4;
        internal System.Windows.Forms.ColumnHeader ColumnHeader5;
    }

}
