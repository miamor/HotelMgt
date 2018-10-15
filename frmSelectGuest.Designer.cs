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
    public partial class frmSelectGuest : System.Windows.Forms.Form
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
            this.lvGuest = new System.Windows.Forms.ListView();
            base.Load += new System.EventHandler(frmSelectGuest_Load);
            this.lvGuest.DoubleClick += new System.EventHandler(this.lvGuest_DoubleClick);
            this.ColumnHeader1 = (System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader());
            this.ColumnHeader2 = (System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader());
            this.ColumnHeader3 = (System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader());
            this.ColumnHeader4 = (System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader());
            this.SuspendLayout();
            //
            //lvGuest
            //
            this.lvGuest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.ColumnHeader1, this.ColumnHeader2, this.ColumnHeader3, this.ColumnHeader4 });
            this.lvGuest.FullRowSelect = true;
            this.lvGuest.GridLines = true;
            this.lvGuest.Location = new System.Drawing.Point(12, 22);
            this.lvGuest.Name = "lvGuest";
            this.lvGuest.Size = new System.Drawing.Size(459, 211);
            this.lvGuest.TabIndex = 60;
            this.lvGuest.UseCompatibleStateImageBehavior = false;
            this.lvGuest.View = System.Windows.Forms.View.Details;
            //
            //ColumnHeader1
            //
            this.ColumnHeader1.Text = "ID";
            this.ColumnHeader1.Width = 40;
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
            this.ColumnHeader4.Width = 110;
            //
            //frmSelectGuest
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF((float)(6.0F), (float)(13.0F));
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 257);
            this.Controls.Add(this.lvGuest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSelectGuest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Double click to select guest";
            this.ResumeLayout(false);

        }
        internal System.Windows.Forms.ListView lvGuest;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.ColumnHeader ColumnHeader4;
    }

}
